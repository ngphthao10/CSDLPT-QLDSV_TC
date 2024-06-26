﻿using DevExpress.XtraPrinting.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private String maSV;
        private String hotenSV;
        private String makhoa;
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nXem lại tên server của Publisher và tên CSDL trong chuỗi kết nối.\n", ex.Message, MessageBoxButtons.OK);
                return 0;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("select * from V_DS_PHANMANH");
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = checkTKSV();
            if (result == 1)
            {
                Program.mlogin = "sinhvien";
                Program.password = "123";
            }
            else if (result == -1) return;
            else
            {
                Program.mlogin = txtTenDN.Text;
                Program.password = txtMatKhau.Text;
            }

            // kết nối bằng login
            if (Program.KetNoi() == 0) return;
            Program.mPhanManh = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "exec SP_LayThongTinDangNhap '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login không có quyền truy cập dữ liệu!\nKiểm tra lại Tên đăng nhập và Password", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Program.mHoten = Program.myReader.GetString(1);
            } catch (Exception ex)
            {
                Program.username = maSV;
                Program.mHoten = hotenSV;
            }
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.frmMain.lblMaGV.Text = "Mã ND: " + Program.username;
            Program.frmMain.lblHoTen.Text = "Họ tên: " + Program.mHoten;
            Program.frmMain.lblNhom.Text = "Nhóm: " + Program.mGroup;
            Program.frmMain.HienThiMenu();

            if (Program.mGroup == "PGV")
            {
                Program.frmMain.rbQuanLyLTC.Visible = true;
                Program.frmMain.rbpQLSV.Visible = true;
                Program.frmMain.rbpQLD.Visible = true;
                Program.frmMain.rbpQLHP.Visible = false;
            }
            else if (Program.mGroup == "KHOA")
            {
                Program.frmMain.rbQuanLyLTC.Visible = true;
                Program.frmMain.rbpQLSV.Visible = true;
                Program.frmMain.rbpQLD.Visible = true;
                Program.frmMain.rbpQLHP.Visible = false;
            }
            else if (Program.mGroup == "PKT")
            {
                Program.frmMain.rbQuanLyLTC.Visible = false;
                Program.frmMain.rbpQLSV.Visible = false;
                Program.frmMain.rbpQLD.Visible = false;
                Program.frmMain.rbpQLHP.Visible = true;
            }
            else
            { //nhom SV
                Program.frmMain.rbQuanLyLTC.Visible = true;
                Program.frmMain.rbpQLSV.Visible = false;
                Program.frmMain.rbpQLD.Visible = true;
                Program.frmMain.rbpQLHP.Visible = false;
            }

            // ẩn nút đăng nhập, show nút đăng xuất
            Program.frmMain.btDangNhap.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            Program.frmMain.btDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.Close();
        }
        public void loadData()
        {
            cmbKhoa.SelectedItem = Program.mGroup;

            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.myReader = null;

            txtTenDN.Text = null;
            txtMatKhau.Text = null;
            txtTenDN.Focus();

            Program.frmMain.lblMaGV.Text = "Mã ND: ";
            Program.frmMain.lblHoTen.Text = "Họ tên: ";
            Program.frmMain.lblNhom.Text = "Nhóm: ";
        }

        public int checkTKSV()
        {
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();

            if (cmbKhoa.SelectedIndex == 0) makhoa = "CNTT";
            else if (cmbKhoa.SelectedIndex == 1) makhoa = "VT";
            else return 0;
           
            string query = "EXEC SP_CHECKSV_LOGIN '" + txtTenDN.Text + "', '" + txtMatKhau.Text + "', '" + makhoa + "'";
            Debug.WriteLine(query);
            using (SqlCommand cmd = new SqlCommand(query, conn_publisher))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader == null || !reader.Read()) return 0;
                    try
                    {
                        maSV = reader["MASV"].ToString();
                        hotenSV = reader["HOTEN"].ToString();
                    } catch (Exception ex)
                    {
                        int result = reader.GetInt32(0);
                        conn_publisher.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Sinh viên hiện đã nghỉ học!", "", MessageBoxButtons.OK);
                            return -1;
                        }
                        else return 0;
                    }
                }
            }
            conn_publisher.Close();
            return 1;
        }
    }
}
