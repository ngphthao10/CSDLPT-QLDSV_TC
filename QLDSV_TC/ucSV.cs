using DevExpress.Pdf.Native;
using System;
using System.Collections;
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
        Stack ds_phuchoi = new Stack();
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

            panelSV.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private bool checkDataSinhVien()
        {
            if (txtMaSV.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHo.Text.ToString().Trim() == "" && txtTen.ToString().Trim() == "")
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
            txtMaSV.Enabled = true;
            txtMaLop.Text = this.malop;
            txtPass.Text = "123";
            ckbPhai.Checked = ckbNghi.Checked = false;
            
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcSV.Enabled = false;
            panelSV.Enabled = true;

            flag = "THEM"; //gán cờ là THEM 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            txtMaLop.Enabled = txtMaSV.Enabled = false; // không cho sửa mã lớp
    
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
            int phai = ckbPhai.Checked ? 1 : 0;
            int nghihoc = ckbNghi.Checked ? 1 : 0;
            string query_phuchoi = "INSERT INTO SINHVIEN(MASV, HO, TEN, PHAI, NGAYSINH, DIACHI, MALOP, DANGHIHOC, PASSWORD) " +
            " VALUES( '" + txtMaSV.Text.Trim() + "', N'" + txtHo.Text.Trim() + "','" +
                        txtTen.Text.Trim() + "', " + phai + ", '" +
                        dateNS.Text.ToString() + "', '" + txtDiaChi.Text.Trim() + "', '" + txtMaLop.Text.Trim() + "', " +
                        nghihoc + ", '" + txtPass.Text.Trim() + "' ) ";
            Console.WriteLine(query_phuchoi);
            ds_phuchoi.Push(query_phuchoi);
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSV.RemoveCurrent();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.QLDSV_TCDataSet.SINHVIEN);
                    MessageBox.Show("Ghi sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = btnSua.Enabled = true;
                    btnGhi.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN, malop);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
            else
            {
                ds_phuchoi.Pop();
            }
            //nếu không còn lớp nào thì ẩn nút xóa
            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            //Lay du lieu truoc khi chon btnGHI
            String maSV= txtMaSV.Text.Trim();
            DataRowView datarow = ((DataRowView)bdsSV[bdsSV.Position]);
            String ho = datarow["HO"].ToString();
            String ten = datarow["TEN"].ToString();
            bool phai_input = Convert.ToBoolean(datarow["PHAI"].ToString());
            int phai = phai_input ? 1 : 0;
            String ngaysinh = datarow["NGAYSINH"].ToString();
            String diachi = datarow["DIACHI"].ToString();
            String malop = datarow["MALOP"].ToString();
            bool danghihoc_input = Convert.ToBoolean(datarow["DANGHIHOC"].ToString());
            int danghihoc = danghihoc_input ? 1 : 0;
            Console.WriteLine(ngaysinh + " " + phai + " " + danghihoc);
            String password = datarow["PASSWORD"].ToString();
            if (checkDataSinhVien())
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    try
                    {
                        String query_phuchoi = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (flag == "THEM")
                        {
                            query_phuchoi = "DELETE SINHVIEN WHERE MASV = '" + txtMaSV.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin*/
                        else
                        {
                            query_phuchoi = "UPDATE SINHVIEN SET TEN = N'" + ten + "'," + "HO = N'" + ho + "'," + "PHAI = " + phai + "," +
                                "NGAYSINH = '" + ngaysinh + "'," + "DIACHI = N'" + diachi + "'," + "MALOP = '" + malop + "'," + 
                                "DANGHIHOC =" + danghihoc + "," + "PASSWORD = N'" + password + "' " +
                                "WHERE MASV = '" + maSV + "'";
                        }
                        Console.WriteLine(query_phuchoi);
                        ds_phuchoi.Push(query_phuchoi);
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
                }
                else
                {
                    return;
                }

                flag = "";
                vitriSV = -1;
                gcSV.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = panelSV.Enabled = false;
            }
            else
            {
                txtHo.Text = ho;
                txtTen.Text = ten;
                if(phai == 0) ckbPhai.Checked = false;
                else ckbPhai.Checked = true;
                txtDiaChi.Text = diachi;
                dateNS.Text = ngaysinh;
                if (danghihoc == 0) ckbNghi.Checked = false;
                else ckbNghi.Checked = true;
                txtPass.Text = password;
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
                    panelSV.Enabled = btnGhi.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnPhucHoi.Enabled = true;
                    flag = "";
                    vitriSV = -1;
                }
            }
            else
            {
                bdsSV.CancelEdit();
                String query_phuchoi = ds_phuchoi.Pop().ToString();
                Program.ExecSqlNonQuery(query_phuchoi);
                bdsSV.Position = vitriSV;
                this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN, malop);
            }
            if (ds_phuchoi.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnPhucHoi.Enabled = false;
                return;
            }

           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.FillBy(this.QLDSV_TCDataSet.SINHVIEN, malop);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.QLDSV_TCDataSet.DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            string masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString().Trim();
            frmChuyenKhoa frm = new frmChuyenKhoa(masv);
            frm.ShowDialog();
        }
    }
}
