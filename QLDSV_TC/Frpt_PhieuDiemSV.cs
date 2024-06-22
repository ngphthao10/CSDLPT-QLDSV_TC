using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV_TC.DS1TableAdapters;
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
    public partial class Frpt_PhieuDiemSV : Form
    {
        string masv;
        string hotensv;
        public Frpt_PhieuDiemSV()
        {
            InitializeComponent();
        }

        private void Frpt_PhieuDiemSV_Load(object sender, EventArgs e)
        {
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS1.SINHVIEN);

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;

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
                txtHOTENSV.Text = "";
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS1.SINHVIEN);
            }
        }

        private string checkMaSV(string masv)
        {
            var sinhVien = this.SINHVIENTableAdapter.GetData().FirstOrDefault(sv => sv.MASV.Trim().Equals(masv.Trim(), StringComparison.OrdinalIgnoreCase));
            return sinhVien != null ? sinhVien.HOTENSV : null;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            masv = cmbMASV.Text.Trim();
            hotensv = txtHOTENSV.Text;
            if (checkMaSV(masv) == null)
            {
                txtHOTENSV.Text = "";
                MessageBox.Show("Không tìm thấy mã sinh viên trong khoa này!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHOTENSV.Focus();
                return;
            }
            else
            {
                hotensv = checkMaSV(masv);
                txtHOTENSV.Text = hotensv.ToString();
            }
            Xrpt_PhieuDiemSV rpt = new Xrpt_PhieuDiemSV(masv);
            rpt.lbMASV.Text = masv;
            rpt.lbHOTENSV.Text = hotensv;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void cmbMASV_SelectedIndexChanged(object sender, EventArgs e)
        {
            masv = cmbMASV.Text.Trim();
            hotensv = checkMaSV(masv);
            txtHOTENSV.Text = hotensv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
