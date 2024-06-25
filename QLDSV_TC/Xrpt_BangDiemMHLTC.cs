using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509.Qualified;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_BangDiemMHLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMHLTC()
        {
            InitializeComponent();
        }

        public Xrpt_BangDiemMHLTC(string NienKhoa, int HocKy, string MonHoc, int Nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = NienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = HocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = MonHoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = Nhom;
            this.sqlDataSource1.Fill();
            lblHoTen.Text = "Người lập: " + Program.mHoten;
        }

    }
}
