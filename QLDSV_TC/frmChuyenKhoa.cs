using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmChuyenKhoa : Form
    {
        private string masv = "";
        private string maLop = "";
        public frmChuyenKhoa(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }
        private bool CheckData()
        {
            if (txtMaLop.Text == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void frmChuyenKhoa_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;

            cmbTenLop.SelectedIndex = 0;
            txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
            txtMaSV.Text = masv;
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
                maLop = txtMaLop.Text;
            }
            catch (Exception ex) { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable sinhVienTable = SINHVIENTableAdapter.GetData();
            DataRow[] sinhVienRows = sinhVienTable.Select("masv = '" + txtMaSV.Text + "'");

           
            string hoTen = sinhVienRows[0]["HO"].ToString() + " " + sinhVienRows[0]["TEN"].ToString();
            string malop = sinhVienRows[0]["MALOP"].ToString();

            if (CheckData())
            {

                DialogResult dialog =
                    MessageBox.Show("Bạn cần kiểm tra trước thực hiện chuyển đổi:" +
                    "\n\nMã số sinh viên  : " + txtMaSV.Text +
                    "\n\nHọ và tên        : " + hoTen +
                    "\n\nMã lớp hiện tại  : " + malop +
                    "\n\nMã lớp chuyển tới: " + txtMaLop.Text
                    , "Thông báo!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

                    String strLenh = "EXEC dbo.SP_CHUYENLOP_SV '" + masv + "', '"  + txtMaLop.Text.Trim() + "'";
                    System.Diagnostics.Debug.Print(strLenh);

                    int result = Program.ExecSqlNonQuery(strLenh);

                    if (result != 0)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi thực thi thủ tục lưu trữ.");
                        return;
                    }
                    Program.conn.Close();
                    MessageBox.Show("Thực hiện chuyển đổi lớp thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác chuyển đổi đã được hủy!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mPhanManh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            }
        }
    }
}
