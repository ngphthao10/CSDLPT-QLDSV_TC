﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Accessibility;
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
    public partial class formLopTinChi : DevExpress.XtraEditors.XtraForm
    {

        string maKhoa;
        int vitri = -1;
        int maLTC = -1;
        public formLopTinChi()
        {
            InitializeComponent();
        }

        private void formLopTinChi_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            bdsLTC.ResetBindings(false);

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

            this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            maKhoa = getMaKhoa();
            setTenMH();
            setTenGV();

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;
            else cmbKhoa.Enabled = false;
            Debug.WriteLine(maKhoa);
        }

        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maLTC = int.Parse(((DataRowView)bdsLTC.Current)["MALTC"].ToString()) + 1;
            DS.LOPTINCHI.MAKHOAColumn.DefaultValue = maKhoa;

            vitri = bdsLTC.Position;
            bdsLTC.AddNew();

            pnThongTin.Enabled = true;   gridControlLTC.Enabled = false;
            btThem.Enabled = btChinhSua.Enabled = btXoa.Enabled = btReload.Enabled = btThoat.Enabled = true;
            btGhi.Enabled = btPhucHoi.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mKhoa)
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

                maKhoa = getMaKhoa();

                fillComboboxMH();
                fillComboboxGV();
                cmbHK.SelectedItem = "2021-2022";
            }
        }

        private List<String> getNienKhoa_HKLast()
        {
            List<String> list = new List<string>();
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT NIENKHOA, HOCKY FROM LOPTINCHI WHERE MALTC = (SELECT MAX(MALTC) FROM LOPTINCHI)");
            if (reader != null && reader.Read())
            {
                list.Add(reader.GetString(0));
                list.Add((String)reader.GetString(1));
            }
            reader.Close();
            return list;
        }

        private String getMaKhoa()
        {
            String makhoa = "";
            string query = "SELECT MAKHOA FROM KHOA";
            SqlDataReader reader = Program.ExecSqlDataReader(query);
            if (reader != null && reader.Read())
            {
                makhoa = reader["MAKHOA"].ToString();
            }
            reader.Close();
            return makhoa;
        }

        private void fillComboboxMH()
        {
            DataTable dtMonHoc = Program.ExecSqlDataTable("SELECT MAMH, TENMH FROM MONHOC");
            cmbMH.Properties.DataSource = dtMonHoc;
            cmbMH.Properties.DisplayMember = "TENMH";
            cmbMH.Properties.ValueMember = "MAMH";
            /*cmbMH.EditValue = */
            foreach (DataRow row in dtMonHoc.Rows)
            {
                Debug.WriteLine("MAMH: " + row["MAMH"] + ", TENMH: " + row["TENMH"]);
            }
        }

        private void fillComboboxGV()
        {
            cmbGV.Properties.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT MAGV, HOTEN = HO + ' ' + TEN FROM GIANGVIEN");
            cmbGV.Properties.ValueMember = "MAGV";
            cmbGV.Properties.DisplayMember = "HOTEN";
        }

        private void setTenMH()
        {
            DataTable dt = Program.ExecSqlDataTable("SELECT MAMH, TENMH FROM MONHOC");
            lkMH.DataSource = dt;
            lkMH.ValueMember = "MAMH";
            lkMH.DisplayMember = "TENMH";
        }

        private void setTenGV()
        {
            DataTable dt = Program.ExecSqlDataTable("SELECT MAGV, HOTEN = HO + ' ' + TEN FROM GIANGVIEN");
            lkGV.DataSource = dt;
            lkGV.ValueMember = "MAGV";
            lkGV.DisplayMember = "HOTEN";
        }

        private bool checkDataLopTinChi(int maLTC)
        {
            if (cmbHK.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("Học kỳ không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbNK.Text == "" )
            {
                MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (cmbMH.SelectedText == "[EditValue is null]")
            {
                MessageBox.Show("Môn học không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (cmbGV.SelectedText == "[EditValue is null]")
            {
                MessageBox.Show("Giảng viên không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (tfNhom.ToString().Trim() == "")
            {
                MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (tfSVMIN.ToString().Trim() == "")
            {
                MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }


            string query = "DECLARE @value INT\n" +
                           "EXEC @value = sp_CHECKLOPTINCHI " +
                           maLTC + ", " +
                           "'" + cmbMH.Text + "', " +
                           "'" + cmbNK.Text + "', " +
                           cmbHK.SelectedItem.ToString() + ", " +
                           tfNhom.Text + "\n" +
                           "SELECT @value";
            System.Diagnostics.Debug.WriteLine(query);
            int result = Program.checkPrimaryKey(query);
            if (result == -1)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (result == 1)
            {
                MessageBox.Show("Lỗi trùng mã lớp tín chỉ!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (result == 2)
            {
                MessageBox.Show("Lỗi trùng MAMH, NIENKHOA, HOCKY, NHOM!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void btGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkDataLopTinChi(maLTC))
            {
                try
                {
                    bdsLTC.EndEdit();
                    bdsLTC.ResetCurrentItem();

                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp tín chỉ!\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            btThem.Enabled = btChinhSua.Enabled = btXoa.Enabled = btReload.Enabled = btThoat.Enabled = true;
            btGhi.Enabled = btPhucHoi.Enabled = false;
            pnThongTin.Enabled = false; gridControlLTC.Enabled = true;
        }

        private void btChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            btThem.Enabled = btChinhSua.Enabled = btXoa.Enabled = btReload.Enabled = btThoat.Enabled = false;
            btGhi.Enabled = btPhucHoi.Enabled = true;
            pnThongTin.Enabled = true; gridControlLTC.Enabled = false;
        }

        private void btXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ vì đã có sinh viên đăng ký!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tin chỉ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLTC = int.Parse((((DataRowView)bdsLTC[vitri])["MALTC"]).ToString());
                    bdsLTC.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MALTC", maLTC);
                    return;
                }
            }
        }
    }
}