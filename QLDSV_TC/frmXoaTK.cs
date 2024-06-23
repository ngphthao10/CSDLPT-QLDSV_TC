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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QLDSV_TC
{
    public partial class frmXoaTK : Form
    {
        public frmXoaTK()
        {
            InitializeComponent();
        }

        private void frmXoaTK_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM V_DS_LOGINNAME_USERNAME where LoginName <> '" + Program.mloginDN +"' ORDER BY Username ";
            lkTen.Properties.DataSource = (DataTable)Program.ExecSqlDataTable(query);
            lkTen.Properties.ValueMember = "UserName";
            lkTen.Properties.DisplayMember = "HOTEN";
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if( lkTen.Text == "[EditValue is null]")
            {
                MessageBox.Show("Chưa chọn thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string username = "";
            string loginname = "";

            SqlDataReader reader = Program.ExecSqlDataReader("SELECT * FROM V_DS_LOGINNAME_USERNAME WHERE UserName = '" + lkTen.EditValue.ToString() + "'");
            if (reader != null && reader.Read())
            {
                username = reader.GetString(0);
                loginname = reader.GetString(1);
            }
            reader.Close();

            string query = "DECLARE @return_value INT EXEC @return_value=[dbo].[Xoa_Login] '" + loginname.Trim() + "','" + username.Trim() + "' "
                           + " SELECT @return_value"; 

            int resultMa = Program.CheckPrimaryKey(query);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lkTen.Properties.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT * FROM V_DS_LOGINNAME_USERNAME");
                lkTen.Properties.ValueMember = "UserName";
                lkTen.Properties.DisplayMember = "HOTEN";
            }
        }   
    }
}
