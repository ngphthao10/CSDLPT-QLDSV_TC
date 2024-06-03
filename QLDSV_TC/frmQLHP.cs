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
    public partial class frmQLHP : Form
    {
        private string masv = "";
        private int vitriCTHP = 0;
        public frmQLHP()
        {
            InitializeComponent();
        }

        private void frmQLHP_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet.EnforceConstraints = false;
            txtHoTen.Visible = txtMaLop.Visible = lblHoTen.Visible = lblMaLop.Visible = false;
            //this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
        }
        private void loadFrmHP()
        {
            try
            {
                this.SP_GETHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_GETHOCPHI_MASVTableAdapter.Fill(this.QLDSV_TCDataSet.SP_GETHOCPHI_MASV, txtMaSV.Text);
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
                this.SP_GETCTHOCPHITableAdapter.Fill(this.QLDSV_TCDataSet.SP_GETCTHOCPHI, txtMaSV.Text, nienKhoa, hocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkdataInput()
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
            return true;
        }

        private void btnTaiHP_Click(object sender, EventArgs e)
        {
            loadFrmHP();
            // Lấy dữ liệu từ table adapter và đổ vào DataTable
            DataTable sinhVienTable = SINHVIENTableAdapter.GetData(); // Giả sử sinhVienTableAdapter là tên của đối tượng của SINHVIENTableAdapter

            // Tìm kiếm sinh viên trong DataTable dựa trên masv
            DataRow[] sinhVienRows = sinhVienTable.Select("masv = '" + masv + "'");

            if (sinhVienRows.Length > 0)
            {
                // Lấy thông tin họ tên của sinh viên
                string hoTen = sinhVienRows[1]["HO"].ToString() + " " + sinhVienRows[1]["TEN"].ToString(); // Giả sử "hoten" là tên trường chứa họ tên của sinh viên
                string malop = sinhVienRows[6]["MALOP"].ToString();
                txtHoTen.Text = hoTen;
                txtMaLop.Text = malop;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên bạn vừa nhập!\nVui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
