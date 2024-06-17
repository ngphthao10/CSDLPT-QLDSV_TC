namespace QLDSV_TC
{
    partial class formDKLTC
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btLoad = new System.Windows.Forms.Button();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lbMSSV = new DevExpress.XtraEditors.LabelControl();
            this.lbLop = new DevExpress.XtraEditors.LabelControl();
            this.lbKhoa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DS = new QLDSV_TC.DS();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DSLTC_DKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_DSLTC_DKTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.gridControlDSLTC = new DevExpress.XtraGrid.GridControl();
            this.gridViewDSLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btLuu = new System.Windows.Forms.Button();
            this.lbHP = new DevExpress.XtraEditors.LabelControl();
            this.lbTongTC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bdsDSLTC_SVDK = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DSLTC_SVDKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_DSLTC_SVDKTableAdapter();
            this.gridControlDK = new DevExpress.XtraGrid.GridControl();
            this.gridViewDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC_SVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDK)).BeginInit();
            this.SuspendLayout();
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(39, 444);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(61, 23);
            hOCKYLabel.TabIndex = 24;
            hOCKYLabel.Text = "Học kỳ";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(39, 386);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(88, 23);
            nIENKHOALabel.TabIndex = 22;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btLoad);
            this.panelControl1.Controls.Add(this.cmbHK);
            this.panelControl1.Controls.Add(this.cmbNK);
            this.panelControl1.Controls.Add(hOCKYLabel);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.lbMSSV);
            this.panelControl1.Controls.Add(this.lbLop);
            this.panelControl1.Controls.Add(this.lbKhoa);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lbHoTen);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(359, 850);
            this.panelControl1.TabIndex = 13;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.Black;
            this.btLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.Color.White;
            this.btLoad.Location = new System.Drawing.Point(63, 508);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(233, 48);
            this.btLoad.TabIndex = 27;
            this.btLoad.Text = "Tải danh sách lớp tín chỉ";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // cmbHK
            // 
            this.cmbHK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHK.Location = new System.Drawing.Point(154, 440);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(69, 31);
            this.cmbHK.TabIndex = 26;
            // 
            // cmbNK
            // 
            this.cmbNK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(154, 382);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(161, 31);
            this.cmbNK.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(39, 292);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(184, 46);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Chọn niên khóa - học kỳ \r\nđể xem lớp tín chỉ";
            // 
            // lbMSSV
            // 
            this.lbMSSV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Appearance.Options.UseFont = true;
            this.lbMSSV.Location = new System.Drawing.Point(140, 85);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(59, 23);
            this.lbMSSV.TabIndex = 20;
            this.lbMSSV.Text = "lbMSSV";
            // 
            // lbLop
            // 
            this.lbLop.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Appearance.Options.UseFont = true;
            this.lbLop.Location = new System.Drawing.Point(140, 136);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(42, 23);
            this.lbLop.TabIndex = 19;
            this.lbLop.Text = "lbLop";
            // 
            // lbKhoa
            // 
            this.lbKhoa.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.Appearance.Options.UseFont = true;
            this.lbKhoa.Location = new System.Drawing.Point(140, 187);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(53, 23);
            this.lbKhoa.TabIndex = 18;
            this.lbKhoa.Text = "lbKhoa";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(39, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 23);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "MSSV:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(39, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 23);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Lớp:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(39, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 23);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Khoa:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Appearance.Options.UseFont = true;
            this.lbHoTen.Location = new System.Drawing.Point(140, 34);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(65, 23);
            this.lbHoTen.TabIndex = 14;
            this.lbHoTen.Text = "lbHoTen";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 23);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Họ tên:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_DSLTC_DK";
            this.bdsDSLTC.DataSource = this.DS;
            // 
            // SP_DSLTC_DKTableAdapter
            // 
            this.SP_DSLTC_DKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControlDSLTC
            // 
            this.gridControlDSLTC.DataSource = this.bdsDSLTC;
            this.gridControlDSLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDSLTC.Location = new System.Drawing.Point(359, 0);
            this.gridControlDSLTC.MainView = this.gridViewDSLTC;
            this.gridControlDSLTC.Name = "gridControlDSLTC";
            this.gridControlDSLTC.Size = new System.Drawing.Size(1005, 447);
            this.gridControlDSLTC.TabIndex = 15;
            this.gridControlDSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDSLTC});
            // 
            // gridViewDSLTC
            // 
            this.gridViewDSLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colGIANGVIEN,
            this.colSOSVDK});
            this.gridViewDSLTC.GridControl = this.gridControlDSLTC;
            this.gridViewDSLTC.Name = "gridViewDSLTC";
            this.gridViewDSLTC.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDSLTC.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewDSLTC.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewDSLTC.OptionsSelection.MultiSelect = true;
            this.gridViewDSLTC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDSLTC.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDSLTC.OptionsView.RowAutoHeight = true;
            this.gridViewDSLTC.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTENMH, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALTC.AppearanceCell.Options.UseFont = true;
            this.colMALTC.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMALTC.AppearanceHeader.Options.UseFont = true;
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.Caption = "MÃ LTC";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 1;
            this.colMALTC.Width = 118;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            this.colMAMH.Width = 118;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.AppearanceCell.Options.UseTextOptions = true;
            this.colTENMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 3;
            this.colTENMH.Width = 228;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNHOM.AppearanceCell.Options.UseFont = true;
            this.colNHOM.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.Caption = "NHÓM";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 80;
            // 
            // colGIANGVIEN
            // 
            this.colGIANGVIEN.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN.AppearanceCell.Options.UseFont = true;
            this.colGIANGVIEN.AppearanceCell.Options.UseTextOptions = true;
            this.colGIANGVIEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colGIANGVIEN.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN.AppearanceHeader.Options.UseFont = true;
            this.colGIANGVIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colGIANGVIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGIANGVIEN.Caption = "GIẢNG VIÊN";
            this.colGIANGVIEN.FieldName = "GIANGVIEN";
            this.colGIANGVIEN.MinWidth = 25;
            this.colGIANGVIEN.Name = "colGIANGVIEN";
            this.colGIANGVIEN.OptionsColumn.ReadOnly = true;
            this.colGIANGVIEN.Visible = true;
            this.colGIANGVIEN.VisibleIndex = 5;
            this.colGIANGVIEN.Width = 203;
            // 
            // colSOSVDK
            // 
            this.colSOSVDK.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOSVDK.AppearanceCell.Options.UseFont = true;
            this.colSOSVDK.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVDK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDK.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSOSVDK.AppearanceHeader.Options.UseFont = true;
            this.colSOSVDK.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVDK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDK.Caption = "SỐ SVDK";
            this.colSOSVDK.FieldName = "SOSVDK";
            this.colSOSVDK.MinWidth = 25;
            this.colSOSVDK.Name = "colSOSVDK";
            this.colSOSVDK.OptionsColumn.ReadOnly = true;
            this.colSOSVDK.Visible = true;
            this.colSOSVDK.VisibleIndex = 6;
            this.colSOSVDK.Width = 83;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btLuu);
            this.panelControl2.Controls.Add(this.lbHP);
            this.panelControl2.Controls.Add(this.lbTongTC);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(359, 447);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1005, 76);
            this.panelControl2.TabIndex = 18;
            // 
            // btLuu
            // 
            this.btLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLuu.BackColor = System.Drawing.Color.Black;
            this.btLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.ForeColor = System.Drawing.Color.White;
            this.btLuu.Location = new System.Drawing.Point(847, 17);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(146, 48);
            this.btLuu.TabIndex = 4;
            this.btLuu.Text = "Lưu đăng ký";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // lbHP
            // 
            this.lbHP.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHP.Appearance.Options.UseFont = true;
            this.lbHP.Location = new System.Drawing.Point(486, 28);
            this.lbHP.Name = "lbHP";
            this.lbHP.Size = new System.Drawing.Size(59, 23);
            this.lbHP.TabIndex = 3;
            this.lbHP.Text = "học phí";
            // 
            // lbTongTC
            // 
            this.lbTongTC.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTC.Appearance.Options.UseFont = true;
            this.lbTongTC.Location = new System.Drawing.Point(163, 28);
            this.lbTongTC.Name = "lbTongTC";
            this.lbTongTC.Size = new System.Drawing.Size(72, 23);
            this.lbTongTC.TabIndex = 2;
            this.lbTongTC.Text = "số tín chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(269, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(202, 23);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Số tiền học phí ước tính: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tổng số tín chỉ: ";
            // 
            // bdsDSLTC_SVDK
            // 
            this.bdsDSLTC_SVDK.DataMember = "SP_DSLTC_SVDK";
            this.bdsDSLTC_SVDK.DataSource = this.DS;
            // 
            // SP_DSLTC_SVDKTableAdapter
            // 
            this.SP_DSLTC_SVDKTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlDK
            // 
            this.gridControlDK.DataSource = this.bdsDSLTC_SVDK;
            this.gridControlDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDK.Location = new System.Drawing.Point(359, 523);
            this.gridControlDK.MainView = this.gridViewDK;
            this.gridControlDK.Name = "gridControlDK";
            this.gridControlDK.Size = new System.Drawing.Size(1005, 327);
            this.gridControlDK.TabIndex = 19;
            this.gridControlDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDK});
            // 
            // gridViewDK
            // 
            this.gridViewDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC1,
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colGIANGVIEN1,
            this.colSOSVDK1});
            this.gridViewDK.GridControl = this.gridControlDK;
            this.gridViewDK.Name = "gridViewDK";
            // 
            // colMALTC1
            // 
            this.colMALTC1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMALTC1.AppearanceCell.Options.UseFont = true;
            this.colMALTC1.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMALTC1.AppearanceHeader.Options.UseFont = true;
            this.colMALTC1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC1.Caption = "MÃ LTC";
            this.colMALTC1.FieldName = "MALTC";
            this.colMALTC1.MinWidth = 25;
            this.colMALTC1.Name = "colMALTC1";
            this.colMALTC1.Visible = true;
            this.colMALTC1.VisibleIndex = 0;
            this.colMALTC1.Width = 115;
            // 
            // colMAMH1
            // 
            this.colMAMH1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMAMH1.AppearanceCell.Options.UseFont = true;
            this.colMAMH1.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMAMH1.AppearanceHeader.Options.UseFont = true;
            this.colMAMH1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH1.Caption = "MÃ MÔN HỌC";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 1;
            this.colMAMH1.Width = 119;
            // 
            // colTENMH1
            // 
            this.colTENMH1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH1.AppearanceCell.Options.UseFont = true;
            this.colTENMH1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTENMH1.AppearanceHeader.Options.UseFont = true;
            this.colTENMH1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH1.Caption = "TÊN MÔN HỌC";
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 25;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 2;
            this.colTENMH1.Width = 268;
            // 
            // colNHOM1
            // 
            this.colNHOM1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNHOM1.AppearanceCell.Options.UseFont = true;
            this.colNHOM1.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNHOM1.AppearanceHeader.Options.UseFont = true;
            this.colNHOM1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM1.Caption = "NHÓM";
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 25;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 3;
            this.colNHOM1.Width = 77;
            // 
            // colGIANGVIEN1
            // 
            this.colGIANGVIEN1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN1.AppearanceCell.Options.UseFont = true;
            this.colGIANGVIEN1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN1.AppearanceHeader.Options.UseFont = true;
            this.colGIANGVIEN1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGIANGVIEN1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGIANGVIEN1.Caption = "GIẢNG VIÊN";
            this.colGIANGVIEN1.FieldName = "GIANGVIEN";
            this.colGIANGVIEN1.MinWidth = 25;
            this.colGIANGVIEN1.Name = "colGIANGVIEN1";
            this.colGIANGVIEN1.Visible = true;
            this.colGIANGVIEN1.VisibleIndex = 4;
            this.colGIANGVIEN1.Width = 286;
            // 
            // colSOSVDK1
            // 
            this.colSOSVDK1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSOSVDK1.AppearanceCell.Options.UseFont = true;
            this.colSOSVDK1.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSVDK1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDK1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSOSVDK1.AppearanceHeader.Options.UseFont = true;
            this.colSOSVDK1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSVDK1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSVDK1.Caption = "SỐ SVDK";
            this.colSOSVDK1.FieldName = "SOSVDK";
            this.colSOSVDK1.MinWidth = 25;
            this.colSOSVDK1.Name = "colSOSVDK1";
            this.colSOSVDK1.Visible = true;
            this.colSOSVDK1.VisibleIndex = 5;
            this.colSOSVDK1.Width = 110;
            // 
            // formDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 850);
            this.Controls.Add(this.gridControlDK);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControlDSLTC);
            this.Controls.Add(this.panelControl1);
            this.Name = "formDKLTC";
            this.Text = "formDKLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC_SVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbHK;
        private System.Windows.Forms.ComboBox cmbNK;
        public DevExpress.XtraEditors.LabelControl lbMSSV;
        public DevExpress.XtraEditors.LabelControl lbLop;
        public DevExpress.XtraEditors.LabelControl lbKhoa;
        public DevExpress.XtraEditors.LabelControl lbHoTen;
        private System.Windows.Forms.Button btLoad;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DSTableAdapters.SP_DSLTC_DKTableAdapter SP_DSLTC_DKTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlDSLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDSLTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbHP;
        private DevExpress.XtraEditors.LabelControl lbTongTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.BindingSource bdsDSLTC_SVDK;
        private DSTableAdapters.SP_DSLTC_SVDKTableAdapter SP_DSLTC_SVDKTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDK1;
    }
}