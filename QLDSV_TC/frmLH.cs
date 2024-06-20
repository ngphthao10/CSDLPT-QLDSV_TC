using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using Siticone.Desktop.UI.WinForms.Enums;
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
    public partial class frmLH : DevExpress.XtraEditors.XtraForm
    {
        private int vitriLop = 0;
        string malop = "";
        private String flag = "";
        public frmLH()
        {
            InitializeComponent();
        }

        private void frmLH_Load(object sender, EventArgs e)
        {
            gridViewLop.ColumnPanelRowHeight = gridViewLop.RowHeight = 25;
            QLDSV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            //makhoa = ((DataRowView)bdsLop[3])["makhoa"].ToString(); //tìm ẩn lổi :)))
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnGhi.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnGhi.Enabled = false;
            }

        }

        private static string GetMaKhoa()
        {
            DataTable dt = Program.ExecSqlDataTable("Select MAKHOA FROM KHOA");
            String datarowkhoa = dt.Rows[0][0].ToString();
            return datarowkhoa;
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
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
                btnPhucHoi.Enabled = false;
            }
        }
        private bool checkDataLop()
        {
            if (txtMaLop.ToString().Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenLop.ToString().Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtKhoaHoc.ToString().Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (flag == "THEM")
            {
                string query = "DECLARE @return_value INT " +
                               "EXEC @return_value = [dbo].[SP_CHECKMALOP]  N'" + txtMaLop.Text.Trim() + "' " +
                               "SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (flag == "THEM" || flag == "CHINHSUA")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKTENLOP]" +

                               " N'" + txtMaLop.Text.ToString() + "', " +

                               " N'" + txtTenLop.Text.ToString() + "' " +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitriLop = bdsLop.Position;
            bdsLop.AddNew();
            txtMaKhoa.Text = GetMaKhoa();

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = false;
            panelLop.Enabled = true;

            flag = "THEM"; //gán cờ là THEM 
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {

            txtMaKhoa.Enabled = false; //không cho sửa mã khoa
            vitriLop = bdsLop.Position;
            panelLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = false;

            flag = "CHINHSUA"; //gán cờ là SUA
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (bdsSV.Count > 0)
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
                    this.LOPTableAdapter.Update(this.QLDSV_TCDataSet.LOP);
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }

                //nếu không còn lớp nào thì ẩn nút xóa
                if (bdsLop.Count == 0) btnXoa.Enabled = false;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flag == "THEM" || flag == "CHINHSUA")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bdsLop.CancelEdit();
                    if (btnThem.Enabled == false) { bdsLop.Position = vitriLop; }
                    gcLop.Enabled = true;
                    panelLop.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                    flag = "";
                    vitriLop = -1;
                }
            }
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flag != "CHINHSUA" && flag != "THEM")
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (checkDataLop())
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    DataRow row = ((DataRowView)bdsLop[bdsLop.Position]).Row;
                    this.LOPTableAdapter.Update(row);

                    MessageBox.Show("Ghi lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flag = "";
                vitriLop = -1;
                panelLop.Enabled = gcLop.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnReload.Enabled = cmbKhoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
        } 

        private void btnTaiSV_Click(object sender, EventArgs e)
        {
            string malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            if(malop == null)
            {
                MessageBox.Show("Lớp hiện chưa có sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucSV ucsv = new ucSV(malop);
            if (panelucSV.Controls.Count > 0 )
            {
                panelucSV.Controls.Clear();
            }
            panelucSV.Controls.Add(ucsv);
            ucsv.BringToFront();
            ucsv.Dock = DockStyle.Fill;
        }
    }
}