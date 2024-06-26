﻿using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using Siticone.Desktop.UI.WinForms.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmLH : DevExpress.XtraEditors.XtraForm
    {
        private int vitriLop = 0;
        string malop = "";
        string tenlop = "";
        private String flag = "";
        Stack ds_phuchoi = new Stack();
        public frmLH()
        {
            InitializeComponent();
        }

        private void frmLH_Load(object sender, EventArgs e)
        {
            gridViewLop.ColumnPanelRowHeight = gridViewLop.RowHeight = 25;
            QLDSV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);


            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                panelLop.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                panelKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                panelLop.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }

        }

        private static string GetMaKhoa()
        {
            DataTable dt = Program.ExecSqlDataTable("Select MAKHOA FROM KHOA");
            String datarowkhoa = dt.Rows[0][0].ToString();
            return datarowkhoa;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
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
                MessageBox.Show("Đã xảy ra lỗi khi kết nối về khoa mới!", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
                btnPhucHoi.Enabled = false;
            }
        }
        public static bool checkNienKhoa(string nk)
        {
            string pattern = @"^\d{4}-\d{4}$";
            if (Regex.IsMatch(nk, pattern))
            {
                string[] years = nk.Split('-');
                int startYear = int.Parse(years[0]);
                int endYear = int.Parse(years[1]);
                return startYear < endYear;
            }

            return false;
        }
        private bool checkDataLop()
        {
            if (txtMaLop.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenLop.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtKhoaHoc.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!checkNienKhoa(txtKhoaHoc.Text.ToString())) 
            {
                MessageBox.Show("Khóa học không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (int.Parse(txtKhoaHoc.Text.ToString().Trim().Substring(0,4)) < DateTime.Now.Year) 
            {
                MessageBox.Show("Không được mở lớp trong quá khứ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (int.Parse(txtKhoaHoc.Text.ToString().Trim().Substring(5,4)) > DateTime.Now.Year + 7)
            {
                MessageBox.Show("Khóa học chỉ kéo dài tối đa 7 năm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string query = "DECLARE @return_value INT " +
                            "EXEC @return_value = [dbo].[SP_CHECKLOP]  N'" + txtMaLop.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "' " +
                            "SELECT @return_value";
            if (flag == "THEM")
            {

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở khoa khác.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 3)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(resultMa == 4)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            else if(flag =="CHINHSUA" && tenlop != txtTenLop.Text)
            {
                int resultMa = Program.CheckPrimaryKey(query);
                Console.WriteLine(resultMa);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 3)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 4)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác.\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitriLop = bdsLop.Position;
            bdsLop.AddNew();
            txtMaKhoa.Text = GetMaKhoa();
            txtMaLop.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = cmbKhoa.Enabled = false;
            panelLop.Enabled = true;

            flag = "THEM"; //gán cờ là THEM 
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {

            txtMaLop.Enabled = txtMaKhoa.Enabled = false; //không cho sửa mã khoa
            tenlop = txtTenLop.Text.Trim();
            vitriLop = bdsLop.Position;
            panelLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = cmbKhoa.Enabled = false;

            flag = "CHINHSUA"; //gán cờ là SUA
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên trong lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query_phuchoi = "INSERT INTO LOP(MALOP, TENLOP, KHOAHOC, MAKHOA) " +
            " VALUES( '" + txtMaLop.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "','" +
                        txtKhoaHoc.Text.Trim() + "', '" + txtMaKhoa.Text.Trim() + "' ) ";

            ds_phuchoi.Push(query_phuchoi);

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.QLDSV_TCDataSet.LOP);
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnSua.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    btnGhi.Enabled  = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }

            }
            else
            {
                ds_phuchoi.Pop();
            }
            //nếu không còn lớp nào thì ẩn nút xóa
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
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
                    bdsLop.CancelEdit();
                    if (btnThem.Enabled == false) { bdsLop.Position = vitriLop; }
                    gcLop.Enabled = true;
                    panelLop.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    btnGhi.Enabled = false;
                    flag = "";
                    vitriLop = -1;
                }
            }
            else
            {
                bdsLop.CancelEdit();
                String query_phuchoi = ds_phuchoi.Pop().ToString();
                Program.ExecSqlNonQuery(query_phuchoi);
                bdsLop.Position = vitriLop;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            }

            if (ds_phuchoi.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnPhucHoi.Enabled = false;
                return;
            }
           
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flag != "CHINHSUA" && flag != "THEM")
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            //Lay du lieu truoc khi chon btnGHI
            String malop = txtMaLop.Text.Trim();
            DataRowView datarow = ((DataRowView)bdsLop[bdsLop.Position]);
            String tenlop = datarow["TENLOP"].ToString();
            String khoahoc = datarow["KHOAHOC"].ToString();

            if (checkDataLop())
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialog == DialogResult.OK)
                {
                    try
                    {
                        String query_phuchoc = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (flag == "THEM")
                        {
                            query_phuchoc = "DELETE LOP WHERE MALOP = '" + txtMaLop.Text.Trim() + "'";
                        }
                        /*trước khi ấn btnGHI là sửa thông tin*/
                        else
                        {
                            query_phuchoc = "UPDATE LOP SET TENLOP = N'" + tenlop + "'," +
                                "KHOAHOC = '" + khoahoc + "'" +
                                "WHERE MALOP = '" + malop + "'";
                        }

                        ds_phuchoi.Push(query_phuchoc);
                        bdsLop.EndEdit();
                        bdsLop.ResetCurrentItem();

                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        DataRow row = ((DataRowView)bdsLop[bdsLop.Position]).Row;
                        this.LOPTableAdapter.Update(row);

                        MessageBox.Show("Ghi lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                flag = "";
                vitriLop = -1;
                gcLop.Enabled = cmbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = btnReload.Enabled = cmbKhoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = panelLop.Enabled = false;
            }
            else
            {
                txtTenLop.Text = tenlop;
                txtKhoaHoc.Text = khoahoc;
            }
        } 

        private void btnTaiSV_Click(object sender, EventArgs e)
        {
            string malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            if(malop == null)
            {
                MessageBox.Show("Lớp hiện chưa có sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucSV ucsv = new ucSV(malop);
            if (panelucSV.Controls.Count > 0 )
            {
                panelucSV.Controls.Clear();
            }
            panelucSV.Controls.Add(ucsv);
            ucsv.BringToFront();
            ucsv.Dock = DockStyle.Fill;
        }

       
    }
}