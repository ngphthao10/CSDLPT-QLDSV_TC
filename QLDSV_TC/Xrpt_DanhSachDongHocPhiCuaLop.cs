using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class Xrpt_DanhSachDongHocPhiCuaLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachDongHocPhiCuaLop(string malop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
            this.sqlDataSource1.Fill();
            lblTienChu.BeforePrint += xrlblCurrencyToWords_BeforePrint;
        }

        private void xrlblCurrencyToWords_BeforePrint(object sender, CancelEventArgs e)
        {
            try
            {
                String currencyToWords = chuyenTienSangChu.ConvertToText(long.Parse(xrlblSotien.Text.Replace(".", "").Replace("đ","")));
                lblTienChu.Text = "(" + currencyToWords.Replace("  ", " ") + ")";
            }
            catch (Exception ex) {
                MessageBox.Show("Hiện chưa có danh sách học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
