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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLDSV_TC
{
    public partial class Frpt_DSLTCTheoKhoa : Form
    {
        public Frpt_DSLTCTheoKhoa()
        {
            InitializeComponent();
        }

        private void Frpt_DSLTCTheoKhoa_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            fillComboboxNK();
            if (Program.KetNoi() == 0)
            {
                return;
            }

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mKhoa)
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                fillComboboxNK();
            }
        }

        private void fillComboboxNK()
        {
            String cmd = "SELECT DISTINCT NIENKHOA FROM LOPTINCHI";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;

            cmbNienKhoa.DataSource = bds;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            Xrpt_DSLTCTheoKhoa rpt = new Xrpt_DSLTCTheoKhoa(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            rpt.lbKhoa.Text = cmbKhoa.Text;
            rpt.lbNienKhoa.Text = cmbNienKhoa.Text;
            rpt.lbHocKy.Text = cmbHocKy.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHocKy.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT DISTINCT HOCKY FROM LOPTINCHI WHERE NIENKHOA = '" + cmbNienKhoa.Text + "'");
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
        }
    }
}
