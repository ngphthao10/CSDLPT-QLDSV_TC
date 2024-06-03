using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Model;
using QLDSV_TC.DSTableAdapters;
using Siticone.Desktop.UI.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        //private Stack<ProcessStore> processStoreStack = new Stack<ProcessStore>();
        public string makhoa = "";
        public int vitri = 0;
        public int vitriSV = 0;
        public String malop = "";
        public String masv = "";
        public frmLop()
        {
            InitializeComponent();
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            gridViewLop.ColumnPanelRowHeight =  gridViewLop.RowHeight = 32;
            gridViewSV.ColumnPanelRowHeight = gridViewSV.RowHeight = 32;
            DS.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            //makhoa = ((DataRowView)bdsLop[3])["makhoa"].ToString(); //tìm ẩn lổi :)))
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = true;
            }
        }
        private static string GetMaKhoa()
        {
            DataTable dt = Program.ExecSqlDataTable("Select MAKHOA FROM KHOA");
            String datarowkhoa = dt.Rows[0][0].ToString();
            return datarowkhoa;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            bdsLop.AddNew();
            gridViewLop.SetFocusedRowCellValue("MAKHOA", GetMaKhoa());
            txtMaKhoa.Text = GetMaKhoa();

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = groupBoxLop.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit(); 
            if(btnThem.Enabled == false) { bdsLop.Position = vitri; }
            gcLop.Enabled = true;
            groupBoxLop.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled=false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên trong lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.DS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }

                if(bdsLop.Count == 0) btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoaHoc.Focus();
                return;
            }

            string query = "DECLARE @return_value INT " +
                           "EXEC @return_value = [dbo].[SP_CHECKMALOP]  N'" + txtMaLop.Text.Trim() + "' " +
                           "SELECT @return_value";

            int resultMa = Program.CheckPrimaryKey(query);

            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database.\nVui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (resultMa == 2)
            {
                MessageBox.Show("Mã lớp đã tồn tại ở khoa khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                    MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

            }
            gcLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBoxLop.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

            //btnThem.Enabled = cmbKhoa.Enabled = true;
            //btnGhi.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = false;
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
            if (!Program.KetNoi())
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                btnPhucHoi.Enabled = false;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaKhoa.Enabled = false;
            vitri = bdsLop.Position;
            groupBoxLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = false;
        }


        private void btnTaiSV_Click(object sender, EventArgs e)
        {
            try
            {
                malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                gridViewSV.ColumnPanelRowHeight = gridViewSV.RowHeight = 32;
                qLDSV_TCDataSet.EnforceConstraints = false;
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void defaultValueInputSV()
        {
            this.qLDSV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            this.qLDSV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            this.qLDSV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.defaultPasswordSV;
            this.qLDSV_TCDataSet.SINHVIEN.MALOPColumn.DefaultValue = malop;

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateEdit.MaxValue = DateTime.Now.AddYears(-18);
            colNGAYSINH.ColumnEdit = dateEdit;
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            defaultValueInputSV();
            bdsSV.AddNew();

            btnThemSV.Enabled = btnXoaSV.Enabled = btnHieuChinhSV.Enabled = btnReloadSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSV.Enabled = panelSV.Enabled = true;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "" && txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            string query = "DECLARE @return_value INT " +
                           "EXEC @return_value = [dbo].[SP_CHECKMASV]  N'" + txtMaSV.Text.Trim() + "' " +
                           "SELECT @return_value";
            int resultMa = Program.CheckPrimaryKey(query);

            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database.\nVui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (resultMa == 2)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại ở khoa khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

            }
            gcSV.Enabled = true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnHieuChinhSV.Enabled = btnReloadSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(bdsDangKy.Count);
            if (bdsDangKy.Count> 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã đăng ký lớp tín chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSV.RemoveCurrent();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }

                if (bdsSV.Count == 0) btnXoaSV.Enabled = false;
            }
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThemSV.Enabled == false) { bdsSV.Position = vitri; }
            gcSV.Enabled = true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnHieuChinhSV.Enabled = btnReloadSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = false;
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHieuChinhSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = false;
            vitriSV = bdsSV.Position;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnReloadSV.Enabled = btnHieuChinhSV.Enabled = false;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = true;
            gcSV.Enabled = false;
        }

        private void btnReloadSV_Click(object sender, EventArgs e)
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

        }
    }
}