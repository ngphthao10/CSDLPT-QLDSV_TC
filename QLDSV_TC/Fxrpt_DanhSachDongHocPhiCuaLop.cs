using DevExpress.XtraReports.UI;
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
    public partial class Fxrpt_DanhSachDongHocPhiCuaLop : Form
    {
        string maLop;
        public Fxrpt_DanhSachDongHocPhiCuaLop()
        {
            InitializeComponent();

        }
        private void fillComboboxNienKhoa()
        {
            int currentYear = DateTime.Now.Year;

            for (int i = 2020; i <= currentYear - 1; i++)
                cmbNienKhoa.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
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
                DataTable dt = Program.ExecSqlDataTable("Select MAKHOA FROM LOP where malop = '" + maLop + "'");
                String makhoa = dt.Rows[0][0].ToString();
                rpt.lblKhoa.Text = makhoa;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}
