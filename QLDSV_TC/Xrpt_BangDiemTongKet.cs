using DevExpress.DataAccess.Sql;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.CrossTab;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace QLDSV_TC
{
    public partial class Xrpt_BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKet(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
            CreateReport(Program.connstr, "sp_BangDiemTongKetTheoLop", malop);
        }

        public DataTable GetData(string connectionString, string storedProcedure, string malop)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MALOP", malop);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public List<string> GetDynamicColumns(DataTable dataTable)
        {
            List<string> columns = new List<string>();
            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.ColumnName != "MASV" && column.ColumnName != "HOTEN")
                {
                    columns.Add(column.ColumnName);

                }
            }
            return columns;
        }

        public void ConfigureCrossTab(DataTable dataTable, List<string> dynamicColumns)
        {
            
            //// Add column fields dynamically
            foreach (string columnName in dynamicColumns)
            {
                CrossTabDataField dataField = new CrossTabDataField { FieldName = columnName, SummaryType = SummaryType.Max };
                crossTab.DataFields.Add(dataField);
                Debug.WriteLine(columnName + " ");
            }

            crossTab.PrintOptions.PrintTotalsForSingleValues = false;
            crossTab.GenerateLayout();

            foreach (var c in crossTab.ColumnDefinitions)
            {
                c.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            }
        }

        public XRCrossTabCell GetBottomRightCell()
        {
            if (crossTab.Cells.Count > 0)
            {
                // Ensure the layout is generated and access the bottom-right cell
                int rowCount = crossTab.RowDefinitions.Count;
                int columnCount = crossTab.ColumnDefinitions.Count;
                if (rowCount > 0 && columnCount > 0)
                {
                    return crossTab.Cells[rowCount - 1, columnCount - 1];
                }
            }
            return null;
        }


        public void CreateReport(string connectionString, string storedProcedure, string malop)
        {
            
            // Fetch data
            DataTable dataTable = GetData(connectionString, storedProcedure, malop);

            // Extract dynamic columns
            List<string> dynamicColumns = GetDynamicColumns(dataTable);
            Debug.WriteLine(dynamicColumns.Count);
            // Configure the existing XRCrossTab control
            ConfigureCrossTab(dataTable, dynamicColumns);
        }

    }
}
