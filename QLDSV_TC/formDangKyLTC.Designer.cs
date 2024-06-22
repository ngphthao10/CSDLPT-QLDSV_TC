namespace QLDSV_TC
{
    partial class formDangKyLTC
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
            this.btLoad = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbKhoa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbMSSV = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaLop = new DevExpress.XtraEditors.LabelControl();
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
            this.lbHP = new System.Windows.Forms.Label();
            this.lbSOTC = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.bdsDSLTC_DK = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DSLTC_SVDKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_DSLTC_SVDKTableAdapter();
            this.gridControlDSLTC_DK = new DevExpress.XtraGrid.GridControl();
            this.gridViewDSLTC_DK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC_DK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSLTC_DK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSLTC_DK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btLoad);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.cmbHK);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cmbNK);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lbKhoa);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lbMSSV);
            this.panelControl1.Controls.Add(this.lbHoTen);
            this.panelControl1.Controls.Add(this.lbMaLop);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(544, 893);
            this.panelControl1.TabIndex = 8;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.Black;
            this.btLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLoad.ForeColor = System.Drawing.Color.White;
            this.btLoad.Location = new System.Drawing.Point(144, 430);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(257, 45);
            this.btLoad.TabIndex = 21;
            this.btLoad.Text = "Xem danh sách lớp tín chỉ";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(373, 369);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 23);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Học kỳ";
            // 
            // cmbHK
            // 
            this.cmbHK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHK.Location = new System.Drawing.Point(435, 365);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(66, 31);
            this.cmbHK.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 369);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 23);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Niên khóa";
            // 
            // cmbNK
            // 
            this.cmbNK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(143, 365);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(150, 31);
            this.cmbNK.TabIndex = 17;
            this.cmbNK.SelectedIndexChanged += new System.EventHandler(this.cmbNK_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 283);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(456, 23);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Vui lòng chọn niên khóa - học kỳ để xem danh sách lớp tín chỉ";
            // 
            // lbKhoa
            // 
            this.lbKhoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhoa.Appearance.Options.UseFont = true;
            this.lbKhoa.Location = new System.Drawing.Point(124, 216);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(109, 23);
            this.lbKhoa.TabIndex = 15;
            this.lbKhoa.Text = "labelControl8";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 112);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Họ tên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(45, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 23);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Mã lớp:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 23);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Khoa:";
            // 
            // lbMSSV
            // 
            this.lbMSSV.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMSSV.Appearance.Options.UseFont = true;
            this.lbMSSV.Location = new System.Drawing.Point(124, 60);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(109, 23);
            this.lbMSSV.TabIndex = 11;
            this.lbMSSV.Text = "labelControl4";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.Appearance.Options.UseFont = true;
            this.lbHoTen.Location = new System.Drawing.Point(124, 112);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(109, 23);
            this.lbHoTen.TabIndex = 10;
            this.lbHoTen.Text = "labelControl3";
            // 
            // lbMaLop
            // 
            this.lbMaLop.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLop.Appearance.Options.UseFont = true;
            this.lbMaLop.Location = new System.Drawing.Point(124, 164);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(109, 23);
            this.lbMaLop.TabIndex = 9;
            this.lbMaLop.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 23);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "MSSV:";
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
            this.gridControlDSLTC.Location = new System.Drawing.Point(544, 0);
            this.gridControlDSLTC.MainView = this.gridViewDSLTC;
            this.gridControlDSLTC.Name = "gridControlDSLTC";
            this.gridControlDSLTC.Size = new System.Drawing.Size(1074, 452);
            this.gridControlDSLTC.TabIndex = 10;
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
            this.gridViewDSLTC.OptionsSelection.MultiSelect = true;
            this.gridViewDSLTC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 1;
            this.colMALTC.Width = 94;
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
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            this.colMAMH.Width = 94;
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
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 3;
            this.colTENMH.Width = 94;
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
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 94;
            // 
            // colGIANGVIEN
            // 
            this.colGIANGVIEN.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN.AppearanceCell.Options.UseFont = true;
            this.colGIANGVIEN.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGIANGVIEN.AppearanceHeader.Options.UseFont = true;
            this.colGIANGVIEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colGIANGVIEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGIANGVIEN.Caption = "GIẢNG VIÊN";
            this.colGIANGVIEN.FieldName = "GIANGVIEN";
            this.colGIANGVIEN.MinWidth = 25;
            this.colGIANGVIEN.Name = "colGIANGVIEN";
            this.colGIANGVIEN.Visible = true;
            this.colGIANGVIEN.VisibleIndex = 5;
            this.colGIANGVIEN.Width = 94;
            // 
            // colSOSVDK
            // 
            this.colSOSVDK.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.colSOSVDK.Visible = true;
            this.colSOSVDK.VisibleIndex = 6;
            this.colSOSVDK.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbHP);
            this.panelControl2.Controls.Add(this.lbSOTC);
            this.panelControl2.Controls.Add(this.btLuu);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(544, 452);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1074, 100);
            this.panelControl2.TabIndex = 11;
            // 
            // lbHP
            // 
            this.lbHP.AutoSize = true;
            this.lbHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHP.Location = new System.Drawing.Point(517, 39);
            this.lbHP.Name = "lbHP";
            this.lbHP.Size = new System.Drawing.Size(55, 23);
            this.lbHP.TabIndex = 24;
            this.lbHP.Text = "label2";
            // 
            // lbSOTC
            // 
            this.lbSOTC.AutoSize = true;
            this.lbSOTC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSOTC.Location = new System.Drawing.Point(188, 39);
            this.lbSOTC.Name = "lbSOTC";
            this.lbSOTC.Size = new System.Drawing.Size(55, 23);
            this.lbSOTC.TabIndex = 23;
            this.lbSOTC.Text = "label1";
            // 
            // btLuu
            // 
            this.btLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLuu.BackColor = System.Drawing.Color.Black;
            this.btLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.ForeColor = System.Drawing.Color.White;
            this.btLuu.Location = new System.Drawing.Point(893, 28);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(150, 45);
            this.btLuu.TabIndex = 22;
            this.btLuu.Text = "Lưu đăng ký";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(308, 39);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(174, 23);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Tổng học phí ước tính:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(117, 23);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Tổng số tín chỉ:";
            // 
            // bdsDSLTC_DK
            // 
            this.bdsDSLTC_DK.DataMember = "SP_DSLTC_SVDK";
            this.bdsDSLTC_DK.DataSource = this.DS;
            // 
            // SP_DSLTC_SVDKTableAdapter
            // 
            this.SP_DSLTC_SVDKTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlDSLTC_DK
            // 
            this.gridControlDSLTC_DK.DataSource = this.bdsDSLTC_DK;
            this.gridControlDSLTC_DK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDSLTC_DK.Location = new System.Drawing.Point(544, 552);
            this.gridControlDSLTC_DK.MainView = this.gridViewDSLTC_DK;
            this.gridControlDSLTC_DK.Name = "gridControlDSLTC_DK";
            this.gridControlDSLTC_DK.Size = new System.Drawing.Size(1074, 341);
            this.gridControlDSLTC_DK.TabIndex = 12;
            this.gridControlDSLTC_DK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDSLTC_DK});
            // 
            // gridViewDSLTC_DK
            // 
            this.gridViewDSLTC_DK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC1,
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colGIANGVIEN1,
            this.colSOSVDK1});
            this.gridViewDSLTC_DK.GridControl = this.gridControlDSLTC_DK;
            this.gridViewDSLTC_DK.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", null, "")});
            this.gridViewDSLTC_DK.Name = "gridViewDSLTC_DK";
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
            this.colMALTC1.Width = 94;
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
            this.colMAMH1.Width = 94;
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
            this.colTENMH1.Width = 94;
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
            this.colNHOM1.Width = 94;
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
            this.colGIANGVIEN1.Width = 94;
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
            this.colSOSVDK1.Width = 94;
            // 
            // formDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 893);
            this.Controls.Add(this.gridControlDSLTC_DK);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControlDSLTC);
            this.Controls.Add(this.panelControl1);
            this.Name = "formDangKyLTC";
            this.Text = "formDangKyLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDangKyLTC_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC_DK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDSLTC_DK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSLTC_DK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbMSSV;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private DevExpress.XtraEditors.LabelControl lbMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbNK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmbHK;
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
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource bdsDSLTC_DK;
        private DSTableAdapters.SP_DSLTC_SVDKTableAdapter SP_DSLTC_SVDKTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlDSLTC_DK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDSLTC_DK;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDK1;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label lbHP;
        private System.Windows.Forms.Label lbSOTC;
    }
}