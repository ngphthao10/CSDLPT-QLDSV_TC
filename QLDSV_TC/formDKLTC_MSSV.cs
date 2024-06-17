using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
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
    public partial class formDKLTC_MSSV : Form
    {
        private int result;
        public formDKLTC_MSSV()
        {
            InitializeComponent();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (checkMaSV())
            {
                formDKLTC form = new formDKLTC(tfMSSV.Text);
                form.FormClosed += (s, args) => this.Close();

                form.Show();
                this.Hide(); // Ẩn form hiện tại

            }
            
        }

        private bool checkMaSV()
        {
            if (tfMSSV == null)
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tfMSSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không thể là chuỗi rỗng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (tfMSSV.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không được quá 10 ký tự", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                SqlDataReader reader = Program.ExecSqlDataReader("EXEC SP_CHECKMASV " + "'" + tfMSSV.Text + "'");
                if (reader != null && reader.Read())
                {
                    result = reader.GetInt32(0);
                    if (result == 0)
                    {
                        MessageBox.Show("Mã sinh viên không tồn tại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        return false;
                    }
                    else changeServer();
                }
                reader.Close();
            }
            return true;
        }

        // THÊM HÀM CHUYỂN SERVER KHI NHẬP VÀO ĐÚNG MSSV 
        private void changeServer()
        {
            if (result == 2)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else if (result == 1)
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formDKLTC_MSSV_Load(object sender, EventArgs e)
        {

        }
    }
}
