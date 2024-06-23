using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLDSV_TC;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmDangNhap frmDN;
        public frmMain()
        {
            InitializeComponent();

           
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }
        private void btDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDN = new frmDangNhap();
            frmDN.Show();
            frmDN.txtTenDN.Focus();
        }

        public void HienThiMenu()
        {
            // Phân quyền
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                this.btnMonHoc.Visibility = BarItemVisibility.Always;
                this.btMoLTC.Visibility = BarItemVisibility.Always;
                this.btDKLTC.Visibility = BarItemVisibility.Never;
                this.btReportDSLTC.Visibility = BarItemVisibility.Always;
                this.btReportDSSV_DKLTC.Visibility = BarItemVisibility.Always;
                this.btnQLSV.Visibility = BarItemVisibility.Always;
                this.btnQLLH.Visibility = BarItemVisibility.Always;
                this.btnBDTK.Visibility = BarItemVisibility.Always;
                this.btnNhapDiem.Visibility = BarItemVisibility.Always;
                this.btnBDTK2.Visibility = BarItemVisibility.Always;
                this.btnBDMH_LTC.Visibility = BarItemVisibility.Always;
                this.btnPhieuDiem.Visibility = BarItemVisibility.Always;
                this.btTaoTK.Visibility = BarItemVisibility.Always;
                this.btXoaTK.Visibility = BarItemVisibility.Always;
                this.rb_sub_diem.Visible = true;
                this.rbSub_ReportLTC.Visible = true;
            }

            if (Program.mGroup == "SV")
            {
                this.btnMonHoc.Visibility = BarItemVisibility.Never;
                this.btMoLTC.Visibility = BarItemVisibility.Never;
                this.btDKLTC.Visibility = BarItemVisibility.Always;
                this.btReportDSLTC.Visibility = BarItemVisibility.Never;
                this.btReportDSSV_DKLTC.Visibility = BarItemVisibility.Never;
                this.btnQLSV.Visibility = BarItemVisibility.Never;
                this.btnQLLH.Visibility = BarItemVisibility.Never;
                this.btnBDTK.Visibility = BarItemVisibility.Never;
                this.btnNhapDiem.Visibility = BarItemVisibility.Never;
                this.btnBDTK2.Visibility = BarItemVisibility.Never;
                this.btnBDMH_LTC.Visibility = BarItemVisibility.Never;
                this.btnPhieuDiem.Visibility = BarItemVisibility.Always;
                this.btTaoTK.Visibility = BarItemVisibility.Never;
                this.btXoaTK.Visibility = BarItemVisibility.Never;
                this.rb_sub_diem.Visible = false;
                this.rbSub_ReportLTC.Visible = false;
            }

            if (Program.mGroup == "PKT")
            {
                this.btnDongHP.Visibility = BarItemVisibility.Always;
                this.btnTTDHP.Visibility = BarItemVisibility.Always;
                this.btTaoTK.Visibility = BarItemVisibility.Always;
                this.btXoaTK.Visibility = BarItemVisibility.Always;
            }
        }
        private void btTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmTaoTK));
            if (form != null) form.Activate();
            else
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                frmTaoTK f = new frmTaoTK();
                f.Show();
            }
        }

        private void btDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                Program.bds_dspm.RemoveFilter();
                frmDN.loadData();

                // ẩn nút đăng xuất, show nút đăng nhập
                btDangNhap.Visibility = BarItemVisibility.Always;
                btDangXuat.Visibility = BarItemVisibility.Never;
                btTaoTK.Visibility = BarItemVisibility.Never;
                btXoaTK.Visibility = BarItemVisibility.Never;

                // ẩn các rb
                rbpQLSV.Visible = rbpQLHP.Visible = rbpQLD.Visible = rbQuanLyLTC.Visible = false;
            }
        }

        private void btMoLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formLopTinChi));
            if (form != null) form.Activate();
            else
            {
                formLopTinChi f = new formLopTinChi();
                f.Show();
            }
        }

        private void btDKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formDangKyLTC));
            if (form != null) form.Activate();
            else
            {
                formDangKyLTC f = new formDangKyLTC(Program.username);
                f.Show();
            }
        }

        private void btReportDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Frpt_DSLTCTheoKhoa));
            if (form != null) form.Activate();
            else
            {
                Frpt_DSLTCTheoKhoa f = new Frpt_DSLTCTheoKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLLH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmLH));
            if (form != null) form.Activate();
            else
            {
                frmLH f = new frmLH();
                f.btnTaiSV.Visible = false;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLSV_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmLH f = new frmLH();
            f.bar1.Visible = false;
            f.Show();
        }

        private void btnBDTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Fxrpt_BangDiemTongKet));
            if (form != null) form.Activate();
            else
            {
                Fxrpt_BangDiemTongKet f = new Fxrpt_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDTK2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Fxrpt_BangDiemTongKet));
            if (form != null) form.Activate();
            else
            {
                Fxrpt_BangDiemTongKet f = new Fxrpt_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDongHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmTTHP));
            if (form != null) form.Activate();
            else
            {
                frmTTHP f = new frmTTHP();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnTTDHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Fxrpt_DanhSachDongHocPhiCuaLop));
            if (form != null) form.Activate();
            else
            {
                Fxrpt_DanhSachDongHocPhiCuaLop f = new Fxrpt_DanhSachDongHocPhiCuaLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btReportDSSV_DKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Frpt_DSSV_DKLTC));
            if (form != null) form.Activate();
            else
            {
                Frpt_DSSV_DKLTC f = new Frpt_DSSV_DKLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmMonHoc));
            if (form != null) form.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmNhapDiem));
            if (form != null) form.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Frpt_BangDiemMHLTC));
            if (form != null) form.Activate();
            else
            {
                Frpt_BangDiemMHLTC f = new Frpt_BangDiemMHLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                Form form = this.CheckExists(typeof(Frpt_PhieuDiemSV));
                if (form != null) form.Activate();
                else
                {
                    Frpt_PhieuDiemSV f = new Frpt_PhieuDiemSV();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else if (Program.mGroup == "SV")
            {
                Form form = this.CheckExists(typeof(Xrpt_PhieuDiemSV));
                if (form != null) form.Activate();
                else
                {
                    Xrpt_PhieuDiemSV rpt = new Xrpt_PhieuDiemSV(Program.username);
                    rpt.lbMASV.Text = Program.username;
                    rpt.lbHOTENSV.Text = Program.mHoten;

                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
            }

        }

        private void btXoaTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmXoaTK));
            if (form != null) form.Activate();
            else
            {
                frmXoaTK f = new frmXoaTK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}