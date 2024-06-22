using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.BarCode;
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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        string maltc;
        DataTable dt_DS1_DangKy = new DataTable();
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            this.LOPTINCHI1TableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS1.LOPTINCHI1' table. You can move, or remove it, as needed.
            this.LOPTINCHI1TableAdapter.Fill(this.DS1.LOPTINCHI1);
            if (Program.KetNoi() == 0)
                return;

            cmbHocKy.Items.Add(1);
            cmbHocKy.Items.Add(2);
            cmbHocKy.Items.Add(3);

            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;

            Program.bds_dspm.Filter = "TENPM not LIKE '%Thông tin đóng học phí%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhanManh;

            btnNhapDiem.Enabled = btnGhiDiem.Enabled = false;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else if (Program.mGroup == "Khoa")
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.SP_LayDSLTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_LayDSLTCTableAdapter.Fill(this.DS1.SP_LayDSLTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                
                this.gc_DS1_DangKy.DataSource = new DataTable();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

            btnNhapDiem.Enabled = true;

            if (bdsDSLTC.Count == 0)
            {
                btnNhapDiem.Enabled = btnGhiDiem.Enabled = false;
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            maltc = ((DataRowView)bdsDSLTC[bdsDSLTC.Position])["MALTC"].ToString();
            string strLenh = "EXEC SP_LayDSSV_DANGKY " + maltc;
            dt_DS1_DangKy = Program.ExecSqlDataTable(strLenh);
            gc_DS1_DangKy.DataSource = dt_DS1_DangKy;
            if(dt_DS1_DangKy == null || dt_DS1_DangKy.Rows.Count == 0)
                btnGhiDiem.Enabled = false;
            else btnGhiDiem.Enabled = true;

            gridView2.ValidatingEditor += gridView2_ValidatingEditor;

        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            // Lấy GridView hiện tại
            GridView view = sender as GridView;
            // Lấy cột hiện tại
            GridColumn column = view.FocusedColumn;

            if (column.FieldName == "DIEM_CC")
            {
                // Lấy giá trị nhập vào
                int newValue;
                bool isValid = int.TryParse(e.Value?.ToString(), out newValue);

                // Kiểm tra điều kiện lỗi
                if (!isValid || newValue < 0 || newValue > 10)
                {
                    e.ErrorText = "Giá trị không hợp lệ!";
                    e.Valid = false;
                }
            }
            if (column.FieldName == "DIEM_GK" || column.FieldName == "DIEM_CK")
            {
                // Lấy giá trị nhập vào
                float newValue;
                bool isValid = float.TryParse(e.Value?.ToString(), out newValue);

                // Kiểm tra điều kiện lỗi
                if (!isValid || newValue < 0 || newValue > 10)
                {
                    e.ErrorText = "Giá trị không hợp lệ!";
                    e.Valid = false;
                }
                else
                {
                    float roundedScore = RoundToNearestHalf(newValue);
                    e.Value = roundedScore;
                }
            }
            
        }

        private float RoundToNearestHalf(float value)
        {
            return (float)(Math.Round(value * 2, MidpointRounding.AwayFromZero) / 2.0);
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MALTC", typeof(int));
                dt.Columns.Add("MASV", typeof(string));
                dt.Columns.Add("DIEM_CC", typeof(float));
                dt.Columns.Add("DIEM_GK", typeof(float));
                dt.Columns.Add("DIEM_CK", typeof(float));

                int intmaltc = int.Parse(maltc);
                for (int i = 0; i < dt_DS1_DangKy.Rows.Count; i++)
                {
                    dt.Rows.Add(intmaltc, dt_DS1_DangKy.Rows[i]["MASV"], dt_DS1_DangKy.Rows[i]["DIEM_CC"],
                                dt_DS1_DangKy.Rows[i]["DIEM_GK"], dt_DS1_DangKy.Rows[i]["DIEM_CK"]);
                }
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand Sqlcmd = new SqlCommand("SP_UpdateDiem", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Ghi điểm thành công!", "Thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Ghi điểm thất bại!", "Lỗi");
            }
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
                MessageBox.Show("Lỗi kết nối về phân mảnh mới", "", MessageBoxButtons.OK);
        }

    }
}