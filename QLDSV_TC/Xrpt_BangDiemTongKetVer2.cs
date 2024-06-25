using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_BangDiemTongKetVer2 : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKetVer2(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.lblHoTen.Text = "Người lập: " + Program.mHoten;
        }

    }
}
