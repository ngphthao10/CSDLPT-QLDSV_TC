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
    public partial class Fxrpt_DanhSachDongHocPhiCuaLop : Form
    {
        string maLop;
        public Fxrpt_DanhSachDongHocPhiCuaLop()
        {
            InitializeComponent();

        }
        private void fillComboboxNienKhoa()
        {
            //int currentYear = DateTime.Now.Year;

            //for (int i = 2020; i <= currentYear - 1; i++)
            //    cmbNienKhoa.Items.Add((i.ToString() + "-" + (i + 1).ToString()));

            string command = "SELECT DISTINCT NIENKHOA FROM HOCPHI";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsNK = new BindingSource();
            bdsNK.DataSource = data;
            cmbNienKhoa.DataSource = bdsNK;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }
        private bool checkData()
        {
            if (txtMaLop.Text == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbNienKhoa.Text == "")
            {
                MessageBox.Show("Niên khóa không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbHocKy.Text == "")
            {
                MessageBox.Show("Học kỳ không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Fxrpt_DanhSachDongHocPhiCuaLop_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet.EnforceConstraints = false;
            fillComboboxNienKhoa();
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            cmbTenLop.SelectedIndex = 0;
            txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
            maLop = txtMaLop.Text;
            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
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
            if (checkData())
            {
                Xrpt_DanhSachDongHocPhiCuaLop rpt = new Xrpt_DanhSachDongHocPhiCuaLop(maLop, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                rpt.lblMaLop.Text = maLop;

                SqlDataReader dr = Program.ExecSqlDataReader("Select MAKHOA FROM LOP where malop = '" + maLop + "'");
                if (dr.Read())
                {
                    String makhoa = dr["MAKHOA"].ToString();
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
                Xrpt_DanhSachDongHocPhiCuaLop rpt = new Xrpt_DanhSachDongHocPhiCuaLop(maLop, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                rpt.lblMaLop.Text = maLop;
                SqlDataReader dr = Program.ExecSqlDataReader("Select MAKHOA FROM LOP where malop = '" + maLop + "'");
                if (dr.Read())
                {
                    String makhoa = dr["MAKHOA"].ToString();
                    rpt.lblKhoa.Text = makhoa;
                }
                dr.Close();

                if (File.Exists(@"D:\ReportDanhSachDongHocPhi.pdf"))
                {
                    DialogResult dialog = MessageBox.Show("File ReportDanhSachDongHocPhi.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"D:\ReportDSDongHocPhi.pdf");
                        MessageBox.Show("File ReportDSDongHocPhi.pdf đã được ghi thành công tại ổ D", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    rpt.ExportToPdf(@"D:\ReportDanhSachDongHocPhi.pdf");
                    MessageBox.Show("File ReportDanhSachDongHocPhi.pdf đã được ghi thành công tại ổ D", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDanhSachDongHocPhi.pdf", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
