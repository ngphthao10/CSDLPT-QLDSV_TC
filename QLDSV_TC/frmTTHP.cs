using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmTTHP : Form
    {
        private int vitriCTHP = 0;
        public frmTTHP()
        {
            InitializeComponent();
        }

        private void loadFrmHP()
        {
            try
            {
                this.SP_GETHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_GETHOCPHI_MASVTableAdapter.Fill(this.QLDSV_TCDataSetSV3.SP_GETHOCPHI_MASV, txtMaSV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadFrmCTHP()
        {
            try
            {
                String nienKhoa = gridViewHP.GetFocusedDataRow()["NIENKHOA"].ToString();
                int hocKy = Convert.ToInt32(gridViewHP.GetFocusedDataRow()["HOCKY"]);

                this.SP_GETCTHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_GETCTHOCPHITableAdapter.Fill(this.QLDSV_TCDataSetSV3.SP_GETCTHOCPHI, txtMaSV.Text, nienKhoa, hocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkDataInput()
        {
            if (dateNgay.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Ngày đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoTien.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Số tiền đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int needToPay = int.Parse(gridViewHP.GetFocusedDataRow()["HOCPHI"].ToString()) - int.Parse(gridViewHP.GetFocusedDataRow()["DADONG"].ToString());
            if (Convert.ToInt32(txtSoTien.Text.Replace(".", "")) > needToPay)
            {
                MessageBox.Show("Số tiền không được lớn hơn số tiền cần đóng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmTTHP_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSetSV3.EnforceConstraints = false;
            txtHoTen.Visible = txtMaLop.Visible = lblHoTen.Visible = lblMaLop.Visible = false;
            btnNopHP.Enabled = btnGhiHP.Enabled  = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSetSV3.SINHVIEN);

        }

        private void btnTaiHP_Click(object sender, EventArgs e)
        {
            DataTable sinhVienTable = SINHVIENTableAdapter.GetData(); 
            DataRow[] sinhVienRows = sinhVienTable.Select("masv = '" + txtMaSV.Text + "'");

            if (sinhVienRows.Length > 0)
            {
                txtHoTen.Visible = txtMaLop.Visible = lblHoTen.Visible = lblMaLop.Visible = true;
                string hoTen = sinhVienRows[0]["HO"].ToString() + " " + sinhVienRows[0]["TEN"].ToString(); // Giả sử "hoten" là tên trường chứa họ tên của sinh viên
                string malop = sinhVienRows[0]["MALOP"].ToString();
                txtHoTen.Text = hoTen;
                txtMaLop.Text = malop;
                loadFrmHP();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên bạn vừa nhập!\nVui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewHP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnNopHP.Enabled = btnGhiHP.Enabled = true;
            if (Convert.ToInt32(gridViewHP.GetFocusedDataRow()["HOCPHI"]) == Convert.ToInt32(gridViewHP.GetFocusedDataRow()["DADONG"]))
                btnNopHP.Enabled = btnGhiHP.Enabled = false;

            else
                btnNopHP.Enabled = btnGhiHP.Enabled = true;
            loadFrmCTHP();
        }

        private void btnNopHP_Click(object sender, EventArgs e)
        {
            dateNgay.Properties.MaxValue = DateTime.Now.AddYears(0);

            bdsCTHP.AddNew();
            vitriCTHP = bdsCTHP.Count - 1;
            gcCTHP.Enabled = false;
            btnNopHP.Enabled = false;
            btnGhiHP.Enabled = true;
        }

        private void btnGhiHP_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                int money = int.Parse(gridViewCTHP.GetFocusedDataRow()["SOTIENDONG"].ToString());


                DialogResult dialog =
                    MessageBox.Show("Bạn cần kiểm tra trước khi thanh toán:" +
                    "\n\nMSSV: " + txtMaSV.Text +
                    "\n\nHọ và tên: " + txtHoTen.Text +
                    "\n\nSố tiền thanh toán: " + String.Format("{0:n0}", money) + " VND"
                    , "Thông báo!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

                    String nienKhoa = gridViewHP.GetFocusedDataRow()["NIENKHOA"].ToString();
                    int hocKy = int.Parse(gridViewHP.GetFocusedDataRow()["HOCKY"].ToString());
                    DateTime dateTime = Convert.ToDateTime(gridViewCTHP.GetFocusedDataRow()["NGAYDONG"]);

                    String spString = "dbo.SP_DONGHOCPHI";
                    SqlCommand command = Program.conn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spString;
                    command.Parameters.Add("@MASV", SqlDbType.NChar).Value = txtMaSV.Text;
                    command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                    command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocKy;
                    command.Parameters.Add("@NGAYDONG", SqlDbType.DateTime).Value = dateTime;
                    command.Parameters.Add("@SOTIENDONG", SqlDbType.Int).Value = money;

                    command.ExecuteNonQuery();
                    Program.conn.Close();

                    loadFrmHP();
                    loadFrmCTHP();
                    MessageBox.Show("Thanh toán học phí thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bdsCTHP.RemoveCurrent();
                    bdsCTHP.CancelEdit();
                    MessageBox.Show("Thao tác thanh toán đã hủy!", "Thông báo!", MessageBoxButtons.OK);
                }

                vitriCTHP = -1;
                btnNopHP.Enabled = btnGhiHP.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnGhiHP.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin học phí của sinh viên.\nBạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
