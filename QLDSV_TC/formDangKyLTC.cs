using DevExpress.XtraEditors;
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
    public partial class formDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        private String makhoa = "";
        private String maSV = "";
        private int chiphi = 500000;
        public formDangKyLTC(String maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        public void fillThongTin(String maSV)
        {
            SqlDataReader reader = Program.ExecSqlDataReader("EXEC SP_GETINFO_SV " + "'" + maSV + "'");
            if (reader != null && reader.Read())
            {
                this.lbHoTen.Text = reader["HO"].ToString().Trim() + " " + reader["TEN"].ToString().Trim();
                this.lbMSSV.Text = reader["MASV"].ToString().Trim();
                this.lbMaLop.Text = reader["MALOP"].ToString().Trim();
                makhoa = reader["MAKHOA"].ToString().Trim();
                Debug.WriteLine(makhoa);
            }
            reader.Close();
            fillComboboxNK();
            lbKhoa.Text = getTenKhoa();
        }

        private void formDangKyLTC_Load(object sender, EventArgs e)
        {
            fillThongTin(maSV);
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

            lbHP.Text = String.Format("{0:n0}", getHocPhi()) + " VNĐ";
            lbSOTC.Text = getTongTC().ToString();
        }

        private void loadCheckBox()
        {
            foreach (DataRowView drv in bdsDSLTC)
            {
                int maltc = Convert.ToInt32(drv["MALTC"]);

                int foundIndex = bdsDSLTC_DK.Find("MALTC", maltc);
                if (foundIndex != -1)
                    gridViewDSLTC.SelectRow(bdsDSLTC.IndexOf(drv));
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string nk_hk = getNK_HK_HienTai();
            if ((cmbHK.Text + "_" + cmbNK.SelectedValue.ToString()).Equals(nk_hk) == false)
            {
                loadCheckBox();
                MessageBox.Show("Lớp tín chỉ đã quá hạn đăng ký/ hủy đăng ký", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int rowIndex = gridViewDSLTC.RowCount - 1; rowIndex >= 0; rowIndex--)
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
                    if (gridViewDSLTC.IsRowSelected(rowIndex) && bdsDSLTC_DK.Find("MALTC", maltc) == -1)
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
                    else if (gridViewDSLTC.IsRowSelected(rowIndex) == false && bdsDSLTC_DK.Find("MALTC", maltc) != -1)
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
            lbSOTC.Text = getTongTC().ToString();
            lbHP.Text = String.Format("{0:n0}", getHocPhi()) + " VNĐ"; 
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

        private int getHocPhi()
        {
            int hocphi;
            string query = "SELECT HOCPHI FROM LINK2.QLDSV_TC.DBO.HOCPHI " +
                "WHERE MASV = '" + maSV + "' AND NIENKHOA = '" + cmbNK.SelectedValue.ToString() + "' " +
                "AND HOCKY = " + cmbHK.Text;
            System.Diagnostics.Debug.Print(query);
            SqlDataReader reader = Program.ExecSqlDataReader(query);
            if (reader != null && reader.Read())
            {
                hocphi = reader.GetInt32(0);
            }
            else hocphi = 0;
            reader.Close();
            return hocphi;
        }

        private int getTongTC()
        {
            int tongtc;
            SqlDataReader reader = Program.ExecSqlDataReader("SELECT TONGTC = SUM(SOTIET_LT + SOTIET_TH)/15 FROM MONHOC WHERE MAMH IN " +
                "(SELECT MAMH FROM LOPTINCHI WHERE NIENKHOA = '" + cmbNK.SelectedValue.ToString() + "' AND HOCKY = " + cmbHK.Text + " AND MALTC IN " +
                "(SELECT MALTC FROM DANGKY WHERE MASV = '" + maSV + "'))");
            
            if (reader != null && reader.Read())
            {
                try
                {
                    tongtc = reader.GetInt32(0);
                } catch(Exception ex) { reader.Close(); return 0; }
            }
            else tongtc = 0;
            reader.Close();
            return tongtc;
        }
    }
}