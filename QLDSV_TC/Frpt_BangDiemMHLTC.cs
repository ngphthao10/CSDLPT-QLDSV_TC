using DevExpress.CodeParser;
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
    public partial class Frpt_BangDiemMHLTC : Form
    {
        public Frpt_BangDiemMHLTC()
        {
            InitializeComponent();
        }

        private void Frpt_BangDiemMHLTC_Load(object sender, EventArgs e)
        {
            this.lOPTINCHI1TableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS1.LOPTINCHI1' table. You can move, or remove it, as needed.
            this.lOPTINCHI1TableAdapter.Fill(this.dS1.LOPTINCHI1);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS1.MONHOC);
            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS1.nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Fill(this.dS1.nhom);

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;

            cmbHocKy.Items.Add(1);
            cmbHocKy.Items.Add(2);
            cmbHocKy.Items.Add(3);
            cmbHocKy.SelectedIndex = 0;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
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
                MessageBox.Show("Lỗi kết nối về phân mảnh mới", "", MessageBoxButtons.OK);
            else
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS1.MONHOC);
                this.lOPTINCHI1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHI1TableAdapter.Fill(this.dS1.LOPTINCHI1);
                this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhomTableAdapter.Fill(this.dS1.nhom);
            }
        }

        private int checkLTC (string NienKhoa, int HocKy, string MonHoc, int nhom)
        {
            string query = "EXEC SP_CHECKLTC_BangDiemMHLTC '" + NienKhoa + "'," + HocKy + ", N'" + MonHoc + "'," + nhom;
            return Program.CheckPrimaryKey(query);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string NienKhoa = cmbNienKhoa.Text;
            int HocKy = int.Parse(cmbHocKy.Text);
            string MonHoc = cmbMonHoc.Text;
            int Nhom = int.Parse(cmbNhom.Text);

            if (checkLTC(NienKhoa, HocKy, MonHoc, Nhom) == -1)
            {
                MessageBox.Show("Không tìm thấy lớp tín chỉ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Xrpt_BangDiemMHLTC rpt = new Xrpt_BangDiemMHLTC(NienKhoa, HocKy, MonHoc, Nhom);
            rpt.lbKhoa.Text = cmbKhoa.Text;
            rpt.lbNienKhoa.Text = cmbNienKhoa.Text;
            rpt.lbHocKy.Text = cmbHocKy.Text;
            rpt.lbMonHoc.Text = cmbMonHoc.Text;
            rpt.lbNhom.Text = cmbNhom.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
