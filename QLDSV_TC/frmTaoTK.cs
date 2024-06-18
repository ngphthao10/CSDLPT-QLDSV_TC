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
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private bool checkFormData()
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtTenDN.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Tài khoản không được chứa khoảng trắng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtMK.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtConfirmMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác thực mật khẩu không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMK.Text != txtConfirmMK.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không trùng khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbGV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giảng viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void getTeacher(string makhoa)
        {
            string command = "SELECT MAGV, HOTEN = RTRIM(MAGV) + ' - ' + HO + ' ' + TEN FROM GIANGVIEN " +
                "WHERE MAKHOA='" + makhoa + "'";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsGV = new BindingSource();
            bdsGV.DataSource = data;
            cmbGV.DataSource = bdsGV;
            cmbGV.DisplayMember = "HOTEN";
            cmbGV.ValueMember = "MAGV";
        }

        private void getAllTeacher()
        {
            string command = "SELECT MAGV, HOTEN = RTRIM(MAGV) + ' - ' + HO + ' ' + TEN FROM GIANGVIEN";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsGV = new BindingSource();
            bdsGV.DataSource = data;
            cmbGV.DataSource = bdsGV;
            cmbGV.DisplayMember = "HOTEN";
            cmbGV.ValueMember = "MAGV";
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {   
            if (Program.mGroup != "PKT")
                Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;
         

            if (Program.mGroup == "PGV")
            {
                if (Program.mPhanManh == 0)
                {
                    getTeacher("CNTT");
                }
                else
                {
                    getTeacher("VT");
                }
                cmbKhoa.Enabled = true;
                rdgGroup.Properties.Items[0].Enabled = true; 
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.Properties.Items[2].Enabled = false;
                rdgGroup.SelectedIndex = 0;
            }
            else if (Program.mGroup == "Khoa")
            {
                if(Program.mPhanManh == 0)
                {
                    getTeacher("CNTT");
                }
                else
                {
                    getTeacher("VT");
                }
                cmbKhoa.Enabled = false;
                rdgGroup.Properties.Items[0].Enabled = false;
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.Properties.Items[2].Enabled = false;
                rdgGroup.SelectedIndex = 1; 
            }
            else
            {
                getAllTeacher();
                cmbKhoa.Enabled = false;
                rdgGroup.Properties.Items[0].Enabled = false;
                rdgGroup.Properties.Items[1].Enabled = false;
                rdgGroup.Properties.Items[2].Enabled = true;
                rdgGroup.SelectedIndex = 2;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim().Length > 0 || txtMK.Text.Trim().Length > 0 || txtConfirmMK.Text.Trim().Length > 0 || cmbGV.SelectedIndex == -1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            if (cmbKhoa.SelectedIndex == 0)
            {
                getTeacher("CNTT");
            }
            else if (cmbKhoa.SelectedIndex == 1)
            {
                getTeacher("VT");
            }
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
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (checkFormData())
            {
                String login = txtTenDN.Text.Trim();
                String password = txtMK.Text.Trim();
                String user = cmbGV.SelectedValue.ToString().Trim();
                String role = rdgGroup.EditValue.ToString();
                String query = " DECLARE @return_value INT EXEC @return_value = [dbo].[SP_TAOLOGIN]" +
                               " N'" + login + "', " +
                               " N'" + password + "', " +
                               " N'" + user + "', " +
                               " N'" + role + "'" +
                               " SELECT @return_value";
       
                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Giảng viên này đã có tài khoản. Vui lòng chọn lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultMa == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenDN.Text = txtMK.Text = txtConfirmMK.Text = "";

                }
            }
        }
    }
}