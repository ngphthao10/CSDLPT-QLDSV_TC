namespace QLDSV_TC
{
    partial class frmNhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGhiDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiLTC = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.HocKy = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsLTC1 = new System.Windows.Forms.BindingSource(this.components);
            this.DS1 = new QLDSV_TC.DS1();
            this.NienKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LayDSLTCTableAdapter = new QLDSV_TC.DS1TableAdapters.SP_LayDSLTCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.gc_DS1_DangKy = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_HOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_DIEMHETMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DSLTC = new DevExpress.XtraGrid.GridControl();
            this.LOPTINCHI1TableAdapter = new QLDSV_TC.DS1TableAdapters.LOPTINCHI1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DS1_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSLTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGhiDiem);
            this.panelControl1.Controls.Add(this.btnNhapDiem);
            this.panelControl1.Controls.Add(this.btnTaiLTC);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.HocKy);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.NienKhoa);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.Khoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1654, 85);
            this.panelControl1.TabIndex = 0;
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnGhiDiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhiDiem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGhiDiem.Appearance.Options.UseBackColor = true;
            this.btnGhiDiem.Appearance.Options.UseFont = true;
            this.btnGhiDiem.Appearance.Options.UseForeColor = true;
            this.btnGhiDiem.Location = new System.Drawing.Point(1392, 29);
            this.btnGhiDiem.Margin = new System.Windows.Forms.Padding(10);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(151, 31);
            this.btnGhiDiem.TabIndex = 10;
            this.btnGhiDiem.Text = "Ghi điểm";
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnNhapDiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapDiem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.Appearance.Options.UseBackColor = true;
            this.btnNhapDiem.Appearance.Options.UseFont = true;
            this.btnNhapDiem.Appearance.Options.UseForeColor = true;
            this.btnNhapDiem.Location = new System.Drawing.Point(1197, 29);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(10);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(139, 32);
            this.btnNhapDiem.TabIndex = 9;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnTaiLTC.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLTC.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTaiLTC.Appearance.Options.UseBackColor = true;
            this.btnTaiLTC.Appearance.Options.UseFont = true;
            this.btnTaiLTC.Appearance.Options.UseForeColor = true;
            this.btnTaiLTC.Location = new System.Drawing.Point(991, 30);
            this.btnTaiLTC.Margin = new System.Windows.Forms.Padding(10);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(149, 32);
            this.btnTaiLTC.TabIndex = 8;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(819, 33);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(10);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(118, 31);
            this.cmbHocKy.TabIndex = 5;
            // 
            // HocKy
            // 
            this.HocKy.AutoSize = true;
            this.HocKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HocKy.Location = new System.Drawing.Point(738, 37);
            this.HocKy.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HocKy.Name = "HocKy";
            this.HocKy.Size = new System.Drawing.Size(61, 23);
            this.HocKy.TabIndex = 4;
            this.HocKy.Text = "Học kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsLTC1;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(547, 33);
            this.cmbNienKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(143, 31);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsLTC1
            // 
            this.bdsLTC1.DataMember = "LOPTINCHI1";
            this.bdsLTC1.DataSource = this.DS1;
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NienKhoa
            // 
            this.NienKhoa.AutoSize = true;
            this.NienKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NienKhoa.Location = new System.Drawing.Point(444, 37);
            this.NienKhoa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.NienKhoa.Name = "NienKhoa";
            this.NienKhoa.Size = new System.Drawing.Size(88, 23);
            this.NienKhoa.TabIndex = 2;
            this.NienKhoa.Text = "Niên khóa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(113, 33);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(302, 31);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Khoa.Location = new System.Drawing.Point(58, 37);
            this.Khoa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(49, 23);
            this.Khoa.TabIndex = 0;
            this.Khoa.Text = "Khoa";
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_LayDSLTC";
            this.bdsDSLTC.DataSource = this.DS1;
            // 
            // SP_LayDSLTCTableAdapter
            // 
            this.SP_LayDSLTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gc_DS1_DangKy
            // 
            this.gc_DS1_DangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DS1_DangKy.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gc_DS1_DangKy.Location = new System.Drawing.Point(0, 467);
            this.gc_DS1_DangKy.MainView = this.gridView2;
            this.gc_DS1_DangKy.Margin = new System.Windows.Forms.Padding(10);
            this.gc_DS1_DangKy.Name = "gc_DS1_DangKy";
            this.gc_DS1_DangKy.Size = new System.Drawing.Size(1654, 237);
            this.gc_DS1_DangKy.TabIndex = 3;
            this.gc_DS1_DangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_MASV,
            this.gridColumn_HOTENSV,
            this.gridColumn_DIEM_CC,
            this.gridColumn_DIEM_GK,
            this.gridColumn_DIEM_CK,
            this.gridColumn_DIEMHETMON});
            this.gridView2.DetailHeight = 1014;
            this.gridView2.GridControl = this.gc_DS1_DangKy;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn_MASV
            // 
            this.gridColumn_MASV.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_MASV.AppearanceCell.Options.UseFont = true;
            this.gridColumn_MASV.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_MASV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_MASV.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_MASV.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_MASV.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_MASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_MASV.Caption = "MÃ SINH VIÊN";
            this.gridColumn_MASV.FieldName = "MASV";
            this.gridColumn_MASV.MinWidth = 77;
            this.gridColumn_MASV.Name = "gridColumn_MASV";
            this.gridColumn_MASV.OptionsColumn.AllowEdit = false;
            this.gridColumn_MASV.OptionsColumn.ReadOnly = true;
            this.gridColumn_MASV.Visible = true;
            this.gridColumn_MASV.VisibleIndex = 0;
            this.gridColumn_MASV.Width = 193;
            // 
            // gridColumn_HOTENSV
            // 
            this.gridColumn_HOTENSV.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_HOTENSV.AppearanceCell.Options.UseFont = true;
            this.gridColumn_HOTENSV.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_HOTENSV.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_HOTENSV.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_HOTENSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_HOTENSV.Caption = "HỌ TÊN";
            this.gridColumn_HOTENSV.FieldName = "HOTENSV";
            this.gridColumn_HOTENSV.MinWidth = 77;
            this.gridColumn_HOTENSV.Name = "gridColumn_HOTENSV";
            this.gridColumn_HOTENSV.OptionsColumn.AllowEdit = false;
            this.gridColumn_HOTENSV.OptionsColumn.ReadOnly = true;
            this.gridColumn_HOTENSV.Visible = true;
            this.gridColumn_HOTENSV.VisibleIndex = 1;
            this.gridColumn_HOTENSV.Width = 597;
            // 
            // gridColumn_DIEM_CC
            // 
            this.gridColumn_DIEM_CC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_CC.AppearanceCell.Options.UseFont = true;
            this.gridColumn_DIEM_CC.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_DIEM_CC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_CC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_CC.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_DIEM_CC.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_DIEM_CC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_CC.Caption = "ĐIỂM CHUYÊN CẦN";
            this.gridColumn_DIEM_CC.FieldName = "DIEM_CC";
            this.gridColumn_DIEM_CC.MinWidth = 77;
            this.gridColumn_DIEM_CC.Name = "gridColumn_DIEM_CC";
            this.gridColumn_DIEM_CC.Visible = true;
            this.gridColumn_DIEM_CC.VisibleIndex = 2;
            this.gridColumn_DIEM_CC.Width = 209;
            // 
            // gridColumn_DIEM_GK
            // 
            this.gridColumn_DIEM_GK.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_GK.AppearanceCell.Options.UseFont = true;
            this.gridColumn_DIEM_GK.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_DIEM_GK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_GK.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_GK.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_DIEM_GK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_DIEM_GK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_GK.Caption = "ĐIỂM GIỮA KỲ";
            this.gridColumn_DIEM_GK.DisplayFormat.FormatString = "n1";
            this.gridColumn_DIEM_GK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_DIEM_GK.FieldName = "DIEM_GK";
            this.gridColumn_DIEM_GK.MinWidth = 77;
            this.gridColumn_DIEM_GK.Name = "gridColumn_DIEM_GK";
            this.gridColumn_DIEM_GK.Visible = true;
            this.gridColumn_DIEM_GK.VisibleIndex = 3;
            this.gridColumn_DIEM_GK.Width = 204;
            // 
            // gridColumn_DIEM_CK
            // 
            this.gridColumn_DIEM_CK.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_CK.AppearanceCell.Options.UseFont = true;
            this.gridColumn_DIEM_CK.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_DIEM_CK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_CK.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEM_CK.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_DIEM_CK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_DIEM_CK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEM_CK.Caption = "ĐIỂM CUỐI KỲ";
            this.gridColumn_DIEM_CK.DisplayFormat.FormatString = "n1";
            this.gridColumn_DIEM_CK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_DIEM_CK.FieldName = "DIEM_CK";
            this.gridColumn_DIEM_CK.MinWidth = 77;
            this.gridColumn_DIEM_CK.Name = "gridColumn_DIEM_CK";
            this.gridColumn_DIEM_CK.Visible = true;
            this.gridColumn_DIEM_CK.VisibleIndex = 4;
            this.gridColumn_DIEM_CK.Width = 214;
            // 
            // gridColumn_DIEMHETMON
            // 
            this.gridColumn_DIEMHETMON.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEMHETMON.AppearanceCell.Options.UseFont = true;
            this.gridColumn_DIEMHETMON.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_DIEMHETMON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEMHETMON.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn_DIEMHETMON.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_DIEMHETMON.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_DIEMHETMON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_DIEMHETMON.Caption = "ĐIỂM HẾT MÔN";
            this.gridColumn_DIEMHETMON.DisplayFormat.FormatString = "n1";
            this.gridColumn_DIEMHETMON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_DIEMHETMON.FieldName = "DIEMHETMON";
            this.gridColumn_DIEMHETMON.MinWidth = 77;
            this.gridColumn_DIEMHETMON.Name = "gridColumn_DIEMHETMON";
            this.gridColumn_DIEMHETMON.OptionsColumn.AllowEdit = false;
            this.gridColumn_DIEMHETMON.OptionsColumn.ReadOnly = true;
            this.gridColumn_DIEMHETMON.UnboundDataType = typeof(double);
            this.gridColumn_DIEMHETMON.UnboundExpression = "[DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6";
            this.gridColumn_DIEMHETMON.Visible = true;
            this.gridColumn_DIEMHETMON.VisibleIndex = 5;
            this.gridColumn_DIEMHETMON.Width = 292;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN});
            this.gridView1.DetailHeight = 1014;
            this.gridView1.GridControl = this.gc_DSLTC;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMALTC.AppearanceCell.Options.UseFont = true;
            this.colMALTC.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMALTC.AppearanceHeader.Options.UseFont = true;
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.Caption = "MÃ LTC";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 77;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.AllowEdit = false;
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 288;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 77;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 574;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNHOM.AppearanceCell.Options.UseFont = true;
            this.colNHOM.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.Caption = "NHÓM";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 77;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 242;
            // 
            // colHOTEN
            // 
            this.colHOTEN.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHOTEN.AppearanceCell.Options.UseFont = true;
            this.colHOTEN.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHOTEN.AppearanceHeader.Options.UseFont = true;
            this.colHOTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTEN.Caption = "HỌ TÊN";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 77;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 520;
            // 
            // gc_DSLTC
            // 
            this.gc_DSLTC.DataSource = this.bdsDSLTC;
            this.gc_DSLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_DSLTC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gc_DSLTC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gc_DSLTC.Location = new System.Drawing.Point(0, 85);
            this.gc_DSLTC.MainView = this.gridView1;
            this.gc_DSLTC.Margin = new System.Windows.Forms.Padding(10);
            this.gc_DSLTC.Name = "gc_DSLTC";
            this.gc_DSLTC.Size = new System.Drawing.Size(1654, 382);
            this.gc_DSLTC.TabIndex = 2;
            this.gc_DSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // LOPTINCHI1TableAdapter
            // 
            this.LOPTINCHI1TableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapDiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 704);
            this.Controls.Add(this.gc_DS1_DangKy);
            this.Controls.Add(this.gc_DSLTC);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DS1_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSLTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS1 DS1;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DS1TableAdapters.SP_LayDSLTCTableAdapter SP_LayDSLTCTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_DS1_DangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_DIEMHETMON;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_MASV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_HOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_DIEM_CK;
        private DevExpress.XtraEditors.SimpleButton btnGhiDiem;
        private DevExpress.XtraEditors.SimpleButton btnNhapDiem;
        private DevExpress.XtraEditors.SimpleButton btnTaiLTC;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label HocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label NienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label Khoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.GridControl gc_DSLTC;
        private System.Windows.Forms.BindingSource bdsLTC1;
        private DS1TableAdapters.LOPTINCHI1TableAdapter LOPTINCHI1TableAdapter;
    }
}