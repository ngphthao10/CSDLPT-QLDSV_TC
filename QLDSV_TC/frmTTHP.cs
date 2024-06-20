using DevExpress.XtraGrid;
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
    public partial class frmTTHP : Form
    {
        private int vitriCTHP = 0;
        public frmTTHP()
        {
            InitializeComponent();
        }

        private void loadFrmHP()
        {
            try
            {
                this.SP_GETHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_GETHOCPHI_MASVTableAdapter.Fill(this.QLDSV_TCDataSetSV3.SP_GETHOCPHI_MASV, txtMaSV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadFrmCTHP()
        {
            try
            {
                String nienKhoa = gridViewHP.GetFocusedDataRow()["NIENKHOA"].ToString();
                int hocKy = Convert.ToInt32(gridViewHP.GetFocusedDataRow()["HOCKY"]);

                this.SP_GETCTHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_GETCTHOCPHITableAdapter.Fill(this.QLDSV_TCDataSetSV3.SP_GETCTHOCPHI, txtMaSV.Text, nienKhoa, hocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkDataInput()
        {
            if (dateNgay.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Ngày đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSoTien.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Số tiền đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int needToPay = int.Parse(gridViewHP.GetFocusedDataRow()["HOCPHI"].ToString()) - int.Parse(gridViewHP.GetFocusedDataRow()["DADONG"].ToString());
            if (Convert.ToInt32(txtSoTien.Text.Replace(".", "")) > needToPay)
            {
                MessageBox.Show("Số tiền không được lớn hơn số tiền cần đóng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmTTHP_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSetSV3.EnforceConstraints = false;
            txtHoTen.Visible = txtMaLop.Visible = lblHoTen.Visible = lblMaLop.Visible = false;
            btnNopHP.Enabled = btnGhiHP.Enabled  = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSetSV3.SINHVIEN);

            if (Program.mGroup != "PKT")
            {
                MessageBox.Show("Bạn không có quyền truy cập màn hình này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnTaiHP_Click(object sender, EventArgs e)
        {
            DataTable sinhVienTable = SINHVIENTableAdapter.GetData(); 
            DataRow[] sinhVienRows = sinhVienTable.Select("masv = '" + txtMaSV.Text + "'");

            if (sinhVienRows.Length > 0)
            {
                txtHoTen.Visible = txtMaLop.Visible = lblHoTen.Visible = lblMaLop.Visible = true;
                string hoTen = sinhVienRows[0]["HO"].ToString() + " " + sinhVienRows[0]["TEN"].ToString();
                string malop = sinhVienRows[0]["MALOP"].ToString();
                txtHoTen.Text = hoTen;
                txtMaLop.Text = malop;
                loadFrmHP();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên bạn vừa nhập!\nVui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewHP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnNopHP.Enabled = gcCTHP.Enabled = true;
            panelCTHP.Enabled = false;
            if (Convert.ToInt32(gridViewHP.GetFocusedDataRow()["HOCPHI"]) == Convert.ToInt32(gridViewHP.GetFocusedDataRow()["DADONG"]))
                btnNopHP.Enabled = btnGhiHP.Enabled = false;
            else
                btnNopHP.Enabled = btnGhiHP.Enabled = true;
            loadFrmCTHP();
        }

        private void btnNopHP_Click(object sender, EventArgs e)
        {
            dateNgay.Properties.MaxValue = DateTime.Now.AddYears(0);
            btnPhucHoi.Visible = panelCTHP.Enabled = true;
            bdsCTHP.AddNew();
            dateNgay.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            int candong = int.Parse(gridViewHP.GetFocusedDataRow()["HOCPHI"].ToString()) - int.Parse(gridViewHP.GetFocusedDataRow()["DADONG"].ToString());
            txtSoTien.Text = String.Format("{0:n0}", candong);
            vitriCTHP = bdsCTHP.Count - 1;  
            btnNopHP.Enabled = false;
            btnGhiHP.Enabled = true;
        }

        private void btnGhiHP_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                //int money = int.Parse(gridViewCTHP.GetFocusedDataRow()["SOTIENDONG"].ToString());
                int money = int.Parse(txtSoTien.Text.ToString());
                DialogResult dialog =
                    MessageBox.Show("Bạn cần kiểm tra trước khi thanh toán:" +
                    "\n\nMSSV: " + txtMaSV.Text +
                    "\n\nHọ và tên: " + txtHoTen.Text +
                    "\n\nSố tiền thanh toán: " + String.Format("{0:n0}", money) + " VND"
                    , "Thông báo!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

                    String nienKhoa = gridViewHP.GetFocusedDataRow()["NIENKHOA"].ToString();
                    int hocKy = int.Parse(gridViewHP.GetFocusedDataRow()["HOCKY"].ToString());
                    DateTime dateTime = Convert.ToDateTime(gridViewCTHP.GetFocusedDataRow()["NGAYDONG"]);

                    // Chuyển đổi DateTime thành chuỗi với định dạng chỉ có ngày tháng
                    String dateString = dateTime.ToString("dd/MM/yyyy");

                    String strLenh = "EXEC dbo.SP_DongHocPhi '" + txtMaSV.Text + "', '"
                                    + nienKhoa + "', '" + hocKy + "', '" + dateString + "', '" + money + "'" ;
                    System.Diagnostics.Debug.Print(strLenh);

                    int result = Program.ExecSqlNonQuery(strLenh);

                    if (result != 0)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi thực thi thủ tục lưu trữ.");
                        return;
                    }
                    Program.conn.Close();

                    loadFrmHP();
                    loadFrmCTHP();
                    MessageBox.Show("Thanh toán học phí thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bdsCTHP.RemoveCurrent();
                    bdsCTHP.CancelEdit();
                    MessageBox.Show("Thao tác thanh toán đã hủy!", "Thông báo!", MessageBoxButtons.OK);
                }

                vitriCTHP = -1;
                btnPhucHoi.Visible = false;
                btnGhiHP.Enabled = false;
                if (Convert.ToInt32(gridViewHP.GetFocusedDataRow()["HOCPHI"]) == Convert.ToInt32(gridViewHP.GetFocusedDataRow()["DADONG"]))
                    btnNopHP.Enabled = btnGhiHP.Enabled = false;
                else
                    btnNopHP.Enabled = btnGhiHP.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnGhiHP.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin học phí của sinh viên.\nBạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (dateNgay.Text.ToString() != null  || txtSoTien.Text.Trim().ToString() != null)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bdsCTHP.CancelEdit();
                    loadFrmCTHP();
                    if (btnNopHP.Enabled == false) { bdsCTHP.Position = vitriCTHP; }
                    btnGhiHP.Enabled = false;
                    btnNopHP.Enabled = true;
                    btnPhucHoi.Visible = false;
                    vitriCTHP = -1;
                }
            }
        }
    }
}
