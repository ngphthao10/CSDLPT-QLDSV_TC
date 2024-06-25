using DevExpress.Xpo.Metadata;
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
    public partial class frmMonHoc : Form
    {
        private int vitri = 0;
        private string tenmh = "";
        private string flatmode = "";

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbPM.DataSource = Program.bds_dspm;
            cmbPM.DisplayMember = "TENPM";
            cmbPM.ValueMember = "TENSERVER";
            cmbPM.SelectedIndex = Program.mPhanManh;
            panelControl2.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                cmbPM.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = true;
            }
            else if (Program.mGroup == "KHOA")
            {
                cmbPM.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = true;
            }
            else
            {
                cmbPM.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnReload.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMONHOC.Position;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            txtMaMH.Enabled = true;
            bdsMONHOC.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMonHoc.Enabled = false;
            flatmode = "add";
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            if (btnThem.Enabled == false)
                bdsMONHOC.Position = vitri;
            gcMonHoc.Enabled = true;
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMONHOC.Position;
            tenmh = txtTenMH.Text;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            txtMaMH.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcMonHoc.Enabled = false;
            flatmode = "edit";
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                MessageBox.Show("Tải lại trang thành công!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int checkMonHoc_LTC(string maMH)
        {
            string query = "EXEC SP_CHECKMAMH_LTC" + " '" + maMH + "'";
            return Program.CheckPrimaryKey(query);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = "";
            //if (bdsLOPTINCHI.Count > 0 )
            //{
            //    MessageBox.Show("Không thể xóa môn học này vì đã có lớp tín chỉ", "", MessageBoxButtons.OK);
            //    return;
            //}
            if (checkMonHoc_LTC(txtMaMH.Text.Trim()) == 1)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString();
                    bdsMONHOC.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                    MessageBox.Show("Xóa môn học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMONHOC.Position = bdsMONHOC.Find("MAMH", maMH);
                    return;
                }
            }
            if (bdsMONHOC.Count == 0) btnXoa.Enabled = false;
        }

        private bool checkMaMH(string maMH)
        {
            return this.MONHOCTableAdapter.GetData().Any(monHoc => monHoc.MAMH.Trim().ToUpper() == maMH.Trim().ToUpper());
        }

        private bool checkTenMH(string maMH, string tenMH)
        {
            return this.MONHOCTableAdapter.GetData().Any(monHoc => monHoc.MAMH.Trim().ToUpper() != maMH.Trim().ToUpper() && monHoc.TENMH.Trim().ToUpper() == tenMH.Trim().ToUpper());
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return;
            }

            if (txtMaMH.Text.Length > 10)
            {
                MessageBox.Show("Mã môn học không dài quá 10 ký tự!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMH.Focus();
                return;
            }
            if (flatmode == "edit" && tenmh != txtTenMH.Text)
            {
                if (checkTenMH(txtMaMH.Text.Trim(), txtTenMH.Text.Trim()))
                {
                    MessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return;
                }
            }
            if (flatmode == "add")
            {
                if (checkMaMH(txtMaMH.Text.Trim()))
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return;
                }

                if (checkTenMH(txtMaMH.Text.Trim(), txtTenMH.Text.Trim()))
                {
                    MessageBox.Show("Tên môn học đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return;
                }
            }

            if (txtTenMH.Text.Length > 50)
            {
                MessageBox.Show("Tên môn học không dài quá 50 ký tự!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return;
            }
            if (!int.TryParse(txtSoTietLT.Text, out int result))
            {
                MessageBox.Show("Số tiết lý thuyết không hợp lệ!", "", MessageBoxButtons.OK);
                txtSoTietLT.Focus();
                return;
            }
            if (!int.TryParse(txtSoTietTH.Text, out int result1))
            {
                MessageBox.Show("Số tiết thực hành không hợp lệ!", "", MessageBoxButtons.OK);
                txtSoTietTH.Focus();
                return;
            }
            if ((int.Parse(txtSoTietLT.Text) + int.Parse(txtSoTietTH.Text)) % 15 != 0)
            {
                MessageBox.Show("Số tiết lý thuyết cộng số tiết thực hành phải là bội của 15!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTietTH.Focus();
                return;
            }
            if ((int.Parse(txtSoTietLT.Text) + int.Parse(txtSoTietTH.Text)) == 0)
            {
                MessageBox.Show("Số tiết lý thuyết và số tiết thực hành không đồng thời bằng 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTietTH.Focus();
                return;
            }

            try
            {
                bdsMONHOC.EndEdit();
                bdsMONHOC.ResetCurrentItem();
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                MessageBox.Show("Ghi môn học thành công!", "Thành công");
                panelControl1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gcMonHoc.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            panelControl2.Enabled = false;
        }

        private void cmbPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPM.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbPM.SelectedValue.ToString();
            if (cmbPM.SelectedIndex != Program.mPhanManh)
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
                MessageBox.Show("Lỗi kết nối về phân mảnh mới", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}
