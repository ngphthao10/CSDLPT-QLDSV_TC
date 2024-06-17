using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
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
    public partial class formDKLTC : DevExpress.XtraEditors.XtraForm
    {
        private String makhoa = "";
        private String maSV = "";
        private DataTable dtGridViewDK;
        private int chiphi = 500000;
        public formDKLTC(String maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void formDKLTC_Load(object sender, EventArgs e)
        {
            fillThongTin(maSV);
            if (changeServer() == false) return;
            fillComboboxNK();
        }

        public void fillThongTin(String maSV)
        {
            SqlDataReader reader = Program.ExecSqlDataReader("EXEC SP_GETINFO_SV " + "'" + maSV + "'");
            if (reader != null && reader.Read())
            {
                this.lbHoTen.Text = reader["HO"].ToString().Trim() + " " + reader["TEN"].ToString().Trim();
                this.lbMSSV.Text = reader["MASV"].ToString().Trim();
                this.lbLop.Text = reader["MALOP"].ToString().Trim();
                makhoa = reader["MAKHOA"].ToString().Trim();
                Debug.WriteLine(makhoa);
            }
            reader.Close();
        }

        public bool changeServer()
        {
            if (makhoa == "CNTT")
            {
                Program.servername = "LAPTOP-CC48TIIO\\MSSQLSERVER01";
                Program.mKhoa = 0;
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            else if (makhoa == "VT")
            {
                Program.servername = "LAPTOP-CC48TIIO\\MSSQLSERVER02";
                Program.mKhoa = 1;
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else return false;

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            fillComboboxNK();
            lbKhoa.Text = getTenKhoa();
            return true;
        }

        private String getMaKhoa()
        {
            String maKhoa = "";
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT MAKHOA FROM KHOA");
            if (reader != null && reader.Read())
                maKhoa = reader.GetString(0);
            reader.Close();
            return maKhoa;
        }

        private String getTenKhoa()
        {
            String tenkhoa = "";
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT TENKHOA FROM KHOA");
            if (reader != null && reader.Read())
                tenkhoa = reader.GetString(0);
            reader.Close();
            return tenkhoa;
        }

        private void fillComboboxNK()
        {
            cmbNK.DataSource = (DataTable)Program.ExecSqlDataTable("SELECT DISTINCT NIENKHOA FROM LOPTINCHI");
            cmbNK.DisplayMember = "NIENKHOA";
            cmbNK.ValueMember = "NIENKHOA";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.SP_DSLTC_DKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_DSLTC_DKTableAdapter.Fill(this.DS.SP_DSLTC_DK, int.Parse(cmbHK.Text), cmbNK.SelectedValue.ToString());

            this.SP_DSLTC_SVDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_DSLTC_SVDKTableAdapter.Fill(this.DS.SP_DSLTC_SVDK, maSV, cmbNK.SelectedValue.ToString(), int.Parse(cmbHK.Text));

            makhoa = getMaKhoa();
            loadCheckBox();
        }
        private void loadCheckBox()
        {
            foreach (DataRowView drv in bdsDSLTC)
            {
                int maltc = Convert.ToInt32(drv["MALTC"]);

                int foundIndex = bdsDSLTC_SVDK.Find("MALTC", maltc);
                if (foundIndex != -1)
                    gridViewDSLTC.SelectRow(bdsDSLTC.IndexOf(drv));
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string nk_hk = getNK_HK_HienTai();
            if ((cmbHK.Text + "_" + cmbNK.SelectedValue.ToString()).Equals(nk_hk) == false)
            {
                MessageBox.Show("Lớp tín chỉ đã quá hạn đăng ký/ hủy đăng ký", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int rowIndex = gridViewDSLTC.RowCount - 1; rowIndex >= 0 ; rowIndex--)
            {
                string mamh = gridViewDSLTC.GetRowCellValue(rowIndex, colMAMH).ToString();
                if (bdsDSLTC[rowIndex] != null && gridViewDSLTC.IsRowSelected(rowIndex))
                {
                    int vitri = bdsDSLTC.Find("MAMH", mamh);
                    if (vitri != rowIndex && gridViewDSLTC.IsRowSelected(vitri))
                    {
                        MessageBox.Show("Không được đăng ký 2 lớp tín chỉ cùng môn học!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCheckBox();
                        return;
                    }
                }
            }

            for (int rowIndex = 0; rowIndex < gridViewDSLTC.RowCount; rowIndex++)
            {
                int maltc = Convert.ToInt32(gridViewDSLTC.GetRowCellValue(rowIndex, colMALTC));
                if (bdsDSLTC[rowIndex] != null)
                {

                    // trường hợp vừa mới bấm chọn
                    if (gridViewDSLTC.IsRowSelected(rowIndex) && bdsDSLTC_SVDK.Find("MALTC", maltc) == -1)
                    {
                        int result = Program.ExecSqlNonQuery("EXEC SP_DANGKYLTC "
                            + maltc + ", '" + maSV + "', " + cmbHK.Text + ", '" + cmbNK.SelectedValue.ToString() + "', '"
                            + gridViewDSLTC.GetRowCellValue(rowIndex, "MAMH").ToString() + "', " + chiphi);

                        // update data
                        this.SP_DSLTC_SVDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_DSLTC_SVDKTableAdapter.Fill(this.DS.SP_DSLTC_SVDK, maSV, cmbNK.SelectedValue.ToString(), int.Parse(cmbHK.Text));
                        if (result != 0) return;                
                    }

                    // trường hợp vừa mới bỏ chọn
                    else if (gridViewDSLTC.IsRowSelected(rowIndex) == false && bdsDSLTC_SVDK.Find("MALTC", maltc) != -1)
                    {
                        int result = Program.ExecSqlNonQuery("EXEC SP_HUYDANGKY_LTC "
                        + maltc + ", '" + maSV + "', " + cmbHK.Text + ", '" + cmbNK.SelectedValue.ToString() + "', '"
                        + gridViewDSLTC.GetRowCellValue(rowIndex, "MAMH").ToString() + "', " + chiphi);

                        // update data
                        this.SP_DSLTC_SVDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SP_DSLTC_SVDKTableAdapter.Fill(this.DS.SP_DSLTC_SVDK, maSV, cmbNK.SelectedValue.ToString(), int.Parse(cmbHK.Text));
                        if (result != 0) return;
                    }
                }
            }
            MessageBox.Show("Bạn đã đăng ký/ hủy đăng ký thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string getNK_HK_HienTai()
        {
            string result = "";
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT TOP 1 NK_HK = CAST(HOCKY AS VARCHAR) + '_' + NIENKHOA FROM LOPTINCHI ORDER BY MALTC DESC");
            if (reader != null && reader.Read())
            {
                result = reader.GetString(0);
            }
            reader.Close();
            return result;
        }
    }
}