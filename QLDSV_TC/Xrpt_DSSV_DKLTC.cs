using DevExpress.XtraEditors.Frames;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace QLDSV_TC
{
    public partial class Xrpt_DSSV_DKLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSSV_DKLTC(int maLTC)
        {
            InitializeComponent();
            this.sqlDS.Connection.ConnectionString = Program.connstr;
            this.sqlDS.Queries[0].Parameters[0].Value = maLTC;
            this.sqlDS.Fill();
        }
    }
}
