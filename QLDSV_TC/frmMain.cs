using DevExpress.XtraBars;
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
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        public void HienThiMenu()
        {
            lblMaGV.Text = "Mã GV: " + Program.username;
            lblHoTen.Text = "Họ tên: " + Program.mHoten;
            lblNhom.Text = "Nhóm: " + Program.mGroup;
            // Phân quyền
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                this.btDKLTC.Visibility = BarItemVisibility.Never;
            }

            if(Program.mGroup == "SV")
            {
                this.btMoLTC.Visibility = BarItemVisibility.Never;
                this.btReportDSLTC.Visibility = BarItemVisibility.Never;
                this.btnDongHP.Visibility = BarItemVisibility.Never;
                this.btnTTDHP.Visibility = BarItemVisibility.Never;
            }
            
        }
        private void btTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmTaoTK));
            if (form != null) form.Activate();
            else
            {
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

                Program.frmChinh.Close();
                Program.bds_dspm.RemoveFilter();
                frmMain fr = new frmMain();
                fr.ShowDialog();
            }
        }

        private void btMoLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form form = this.CheckExists(typeof(formLopTinChi));
            //if (form != null) form.Activate();
            //else
            //{
            //    formLopTinChi f = new formLopTinChi();
            //    f.Show();
            //}
        }

        private void btDKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form form = this.CheckExists(typeof(formDKLTC_MSSV));
            //if (form != null) form.Activate();
            //else
            //{
            //    formDKLTC_MSSV f = new formDKLTC_MSSV();
            //    f.Show();
            //}
        }

        private void btReportDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form form = this.CheckExists(typeof(Frpt_DSLTCTheoKhoa));
            //if (form != null) form.Activate();
            //else
            //{
            //    Frpt_DSLTCTheoKhoa f = new Frpt_DSLTCTheoKhoa();
            //    f.Show();
            //}
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
    }
}