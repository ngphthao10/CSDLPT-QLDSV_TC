using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class Fxrpt_BangDiemTongKet : Form
    {
        string maLop;
        public Fxrpt_BangDiemTongKet()
        {
            InitializeComponent();
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

        private void Fxrpt_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            //cmbTenLop.SelectedIndex = 0;

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;

            cmbTenLop.SelectedIndex = 0;
            txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
            maLop = txtMaLop.Text;
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Xrpt_BangDiemTongKetVer2 rpt = new Xrpt_BangDiemTongKetVer2(maLop);
                rpt.lblLop.Text = maLop;
                SqlDataReader dr = Program.ExecSqlDataReader("Select * FROM LOP where malop = '" + maLop + "'");

                if (dr.Read())
                {
                    String makhoa = dr["MAKHOA"].ToString();
                    String khoahoc = dr["KHOAHOC"].ToString();

                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                }
                dr.Close();

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                Xrpt_BangDiemTongKetVer2 rpt = new Xrpt_BangDiemTongKetVer2(maLop);
                rpt.lblLop.Text = maLop;
                SqlDataReader dr = Program.ExecSqlDataReader("Select * FROM LOP where malop = '" + maLop + "'");
                if (dr.Read())
                {
                    String makhoa = dr["MAKHOA"].ToString();
                    String khoahoc = dr["KHOAHOC"].ToString();

                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                }
                dr.Close();

                if (File.Exists(@"D:\ReportBangDiemTongKet.pdf"))
                {
                    DialogResult dialog = MessageBox.Show("File ReportBangDiemTongKet.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"D:\ReportBangDiem.pdf");
                        MessageBox.Show("File ReportBangDiem.pdf đã được ghi thành công tại ổ D", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    rpt.ExportToPdf(@"D:\ReportBangDiemTongKet.pdf");
                    MessageBox.Show("File ReportBangDiemTongKet.pdf đã được ghi thành công tại ổ D", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportBangDiemTongKet.pdf", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
