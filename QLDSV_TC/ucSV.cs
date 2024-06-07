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
    public partial class ucSV : UserControl
    {
        private string malop = "";
        private string flag = "";
        private int vitriSV = 0;
        public ucSV(string malop)
        {
            InitializeComponent();
            this.malop = malop;
            txtMaLop.Text = malop;
        }

        private void ucSV_Load(object sender, EventArgs e)
        {
            gridViewSV.ColumnPanelRowHeight = gridViewSV.RowHeight = 25;
            QLDSV_TCDataSet.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN,malop);
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.QLDSV_TCDataSet.DANGKY);

            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private bool checkDataSinhVien()
        {
            if (txtMaSV.ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHo.ToString().Trim() == "" && txtTen.ToString().Trim() == "")
            {
                MessageBox.Show("Họ và tên không được trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (flag == "THEM")
            {
                string query = "DECLARE @return_value INT " +
                               "EXEC @return_value = [dbo].[SP_CHECKMASV]  N'" + txtMaSV.Text.Trim() + "' " +
                               "SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dateNS.Properties.MaxValue = DateTime.Now.AddYears(-18);
            vitriSV = bdsSV.Position;
            bdsSV.AddNew();
            txtMaLop.Text = this.malop;
            
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcSV.Enabled = false;
            panelSV.Enabled = true;

            flag = "THEM"; //gán cờ là THEM 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            txtMaLop.Enabled = false; // không cho sửa mã lớp
    
            dateNS.Properties.MaxValue = DateTime.Now.AddYears(-18);
            vitriSV = bdsSV.Position;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcSV.Enabled = false;
            panelSV.Enabled = true;

            flag = "CHINHSUA"; //gán cờ là SUA
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (bdsDK.Count > 0)
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
                    this.SINHVIENTableAdapter.Update(this.QLDSV_TCDataSet.SINHVIEN);
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN, malop);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }

                if (bdsSV.Count == 0) btnXoa.Enabled = false;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (checkDataSinhVien())
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    DataRow row = ((DataRowView)bdsSV[bdsSV.Position]).Row;
                    this.SINHVIENTableAdapter.Update(row);

                    MessageBox.Show("Ghi sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flag = "";
                vitriSV = -1;
                panelSV.Enabled = gcSV.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
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
                    bdsSV.CancelEdit();
                    if (btnThem.Enabled == false) { bdsSV.Position = vitriSV; }
                    gcSV.Enabled = true;
                    panelSV.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                    flag = "";
                    vitriSV = -1;
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN, malop);
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.QLDSV_TCDataSet.DANGKY);
        }

    }
}
