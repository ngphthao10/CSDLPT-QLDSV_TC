using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class Frpt_DSSV_DKLTC : Form
    {
        int maLTC = -1;
        string makhoa = "";
        public Frpt_DSSV_DKLTC()
        {
            InitializeComponent();
        }

        private void Frpt_DSSV_DKLTC_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            fillComboboxMH();
            fillComboboxNK();
        }

        private void fillComboboxNK()
        {
            cmbNK.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT DISTINCT NIENKHOA FROM LOPTINCHI");
            cmbNK.DisplayMember = "NIENKHOA";
            cmbNK.ValueMember = "NIENKHOA";
        }

        private void fillComboboxMH()
        {
            lkMH.Properties.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT MAMH, TENMH FROM MONHOC");
            lkMH.Properties.DisplayMember = "TENMH";
            lkMH.Properties.ValueMember = "MAMH";
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            if (checkLTC())
            {
                if (makhoa == "VT")
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
                }
                else
                {
                    Xrpt_DSSV_DKLTC rpt = new Xrpt_DSSV_DKLTC(maLTC);

                    // fill thông tin cho report
                    rpt.lbKhoa.Text = "KHOA " + getTenKhoa().ToUpper();
                    rpt.lbNK.Text = cmbNK.Text;
                    rpt.lbHK.Text = cmbHK.Text;
                    rpt.lbMH.Text = lkMH.Text.ToString();
                    rpt.lbNhom.Text = tfNhom.Text;

                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }

                
            }
        }

        private bool checkLTC()
        {
            SqlDataReader reader = Program.ExecSqlDataReader("EXEC SP_CHECKLTC_DSSVDK '" +
                    cmbNK.SelectedValue.ToString() + "', " + cmbHK.Text + ", '" + lkMH.EditValue.ToString().Trim() + "', " + tfNhom.Text);
            Debug.WriteLine("EXEC SP_CHECKLTC_DSSVDK " +
                    cmbNK.SelectedValue.ToString() + ", " + cmbHK.SelectedItem.ToString() + ", '" + lkMH.EditValue.ToString().Trim() + "', " + tfNhom.Text);
            if (reader != null && reader.Read())
            {
                if (reader.GetInt32(0) == -1)
                {
                    MessageBox.Show("Không tìm thấy lớp tín chỉ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                else
                {
                    maLTC = int.Parse(reader["MALTC"].ToString());
                    makhoa = reader["MAKHOA"].ToString();
                }
            }
            reader.Close();
            return true;
        }

        private string getTenKhoa()
        {
            string tenkhoa = "";
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT TENKHOA FROM KHOA");
            if (reader != null && reader.Read())
            {
                tenkhoa = reader.GetString(0);
            }
            reader.Close();
            return tenkhoa;
        }

    }
}
