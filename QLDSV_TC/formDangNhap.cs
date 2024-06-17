using DevExpress.XtraEditors;
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
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection conn_publisher = new SqlConnection();
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu gốc" +
                    "\n Bạn xem lại tên server của Publisher và tên CSDL của trong chuỗi kết nối\n" + ex.Message);
            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi combox khoa!!" + ex.Message);
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM DBO.V_DS_PHANMANH");
            cmbKhoa.SelectedText = "";
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (tfUsername.Text.Trim() == "" || tfPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username và password không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            // hàm kiểm tra username & password có phải của sinh viên hay không


            Program.mlogin = tfUsername.Text;
            Program.password = tfPassword.Text;

            if (Program.KetNoi() == 0) return;
            Program.mKhoa = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_LayThongTinDangNhap '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0); // lấy username
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu" +
                    "\nBạn vui lòng xem lại username và password!");
                return;
            }

            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.formChinh.lbmaNV.Text = "Mã NV: " + Program.username;
            Program.formChinh.lbHoTen.Text = "Họ tên: " + Program.mHoTen;
            Program.formChinh.lbNhom.Text = "Nhóm: " + Program.mGroup;
            Program.formChinh.HienThiMenu();
            Program.formChinh.rbQuanLyLTC.Visible = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {



        }
    }
}