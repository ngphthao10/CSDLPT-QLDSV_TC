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
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
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
            Form form = this.CheckExists(typeof(formDangNhap));
            if (form != null)
                form.Activate();
            else
            {
                formDangNhap f = new formDangNhap(); 
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            lbmaNV.Text = "Mã NV: " + Program.username;
            lbHoTen.Text = "Họ tên: " + Program.mHoTen;
            lbNhom.Text = "Nhóm: " + Program.mGroup;
            // Phân quyền
            // tiếp tục if trên Program.mGroup để bật/ tắt menu chính
        }
        private void btTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

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
            Form form = this.CheckExists(typeof(formDKLTC_MSSV));
            if (form != null) form.Activate();
            else
            {
                formDKLTC_MSSV f = new formDKLTC_MSSV();
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
                f.Show();
            }
        }

        private void bt_DSSV_DKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Frpt_DSSV_DKLTC));
            if (form != null) form.Activate();
            else
            {
                Frpt_DSSV_DKLTC f = new Frpt_DSSV_DKLTC();
                f.Show();
            }
        }
    }
}