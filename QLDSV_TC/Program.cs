using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QLDSV_TC
{
    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=LAPTOP-CC48TIIO;Initial Catalog=QLDSV_TC;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV_TC";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";

        public static int mKhoa;
        public static string makhoa;
        public static BindingSource bds_dspm = new BindingSource();
        public static formMain formChinh;
        public static int mPhanManh = 0;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog="
                    + Program.database + ";User ID=" + Program.mlogin
                    + ";password=" + Program.password + ";TrustServerCertificate=True";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu ." +
                    "\nBạn xem lại username và password." + e.Message + Program.connstr, "", MessageBoxButtons.OK);
               
                return 0;
            }
        }

        // Thực thi lệnh đọc, không hiệu chỉnh
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader = null;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

        }

        // Thực thi lệnh đọc, hiệu chỉnh table
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt);
                Program.conn.Close();
                return dt;
            }
            catch(SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

        }

        // Hiệu chỉnh, trả về số row affected
        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //10'

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            try
            {
                sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
                Program.conn.Close();
                return e.State; // trạng thái lỗi gửi từ RAISERROR trong SQL Server qua
            }
        }
        public static int CheckPrimaryKey(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;
            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formChinh = new formMain();
            Application.Run(formChinh);
        }
    }
}
