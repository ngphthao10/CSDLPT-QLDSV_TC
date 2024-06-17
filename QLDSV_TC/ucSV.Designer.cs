namespace QLDSV_TC
{
    partial class ucSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSV));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcSV = new DevExpress.XtraGrid.GridControl();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.gridViewSV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelSV = new DevExpress.XtraEditors.PanelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.ckbNghi = new System.Windows.Forms.CheckBox();
            this.dateNS = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.ckbPhai = new System.Windows.Forms.CheckBox();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.panelBtn = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnReload = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnGhi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnPhucHoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnThem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).BeginInit();
            this.panelSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBtn)).BeginInit();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(74, 64);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(94, 20);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(74, 106);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(76, 20);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(74, 152);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(32, 20);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "Nữ:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(74, 194);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(58, 20);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(74, 236);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(77, 20);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(74, 278);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(59, 20);
            mALOPLabel.TabIndex = 12;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dANGHIHOCLabel.Location = new System.Drawing.Point(74, 320);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(92, 20);
            dANGHIHOCLabel.TabIndex = 14;
            dANGHIHOCLabel.Text = "Đã nghỉ học:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcSV);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2074, 585);
            this.panelControl1.TabIndex = 1;
            // 
            // gcSV
            // 
            this.gcSV.DataSource = this.bdsSV;
            this.gcSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcSV.Location = new System.Drawing.Point(2, 2);
            this.gcSV.MainView = this.gridViewSV;
            this.gcSV.Name = "gcSV";
            this.gcSV.Size = new System.Drawing.Size(1509, 581);
            this.gcSV.TabIndex = 0;
            this.gcSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSV});
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.QLDSV_TCDataSet;
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewSV
            // 
            this.gridViewSV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridViewSV.GridControl = this.gcSV;
            this.gridViewSV.Name = "gridViewSV";
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceCell.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceHeader.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.Caption = "MÃ SINH VIÊN";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 114;
            // 
            // colHO
            // 
            this.colHO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceCell.Options.UseFont = true;
            this.colHO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 127;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceCell.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 93;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPHAI.AppearanceCell.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPHAI.AppearanceHeader.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.Caption = "NỮ";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.ReadOnly = true;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 88;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceCell.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 120;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceCell.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceHeader.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.Caption = "NGÀY SINH";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 120;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDANGHIHOC.AppearanceCell.Options.UseFont = true;
            this.colDANGHIHOC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDANGHIHOC.AppearanceHeader.Options.UseFont = true;
            this.colDANGHIHOC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDANGHIHOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDANGHIHOC.Caption = "ĐÃ NGHỈ HỌC";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.OptionsColumn.ReadOnly = true;
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 6;
            this.colDANGHIHOC.Width = 120;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPASSWORD.AppearanceCell.Options.UseFont = true;
            this.colPASSWORD.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPASSWORD.AppearanceHeader.Options.UseFont = true;
            this.colPASSWORD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 25;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.OptionsColumn.ReadOnly = true;
            this.colPASSWORD.Width = 126;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelSV);
            this.panelControl2.Controls.Add(this.panelBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1511, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(561, 581);
            this.panelControl2.TabIndex = 1;
            // 
            // panelSV
            // 
            this.panelSV.Controls.Add(this.txtMaLop);
            this.panelSV.Controls.Add(dANGHIHOCLabel);
            this.panelSV.Controls.Add(this.ckbNghi);
            this.panelSV.Controls.Add(mALOPLabel);
            this.panelSV.Controls.Add(nGAYSINHLabel);
            this.panelSV.Controls.Add(this.dateNS);
            this.panelSV.Controls.Add(dIACHILabel);
            this.panelSV.Controls.Add(this.txtDiaChi);
            this.panelSV.Controls.Add(pHAILabel);
            this.panelSV.Controls.Add(this.ckbPhai);
            this.panelSV.Controls.Add(this.txtTen);
            this.panelSV.Controls.Add(hOLabel);
            this.panelSV.Controls.Add(this.txtHo);
            this.panelSV.Controls.Add(mASVLabel);
            this.panelSV.Controls.Add(this.txtMaSV);
            this.panelSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSV.Location = new System.Drawing.Point(2, 2);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(557, 416);
            this.panelSV.TabIndex = 0;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txtMaLop.EditValue = "";
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(237, 271);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(244, 26);
            this.txtMaLop.TabIndex = 18;
            // 
            // ckbNghi
            // 
            this.ckbNghi.Checked = true;
            this.ckbNghi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNghi.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "DANGHIHOC", true));
            this.ckbNghi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNghi.Location = new System.Drawing.Point(237, 317);
            this.ckbNghi.Name = "ckbNghi";
            this.ckbNghi.Size = new System.Drawing.Size(28, 24);
            this.ckbNghi.TabIndex = 15;
            this.ckbNghi.UseVisualStyleBackColor = true;
            // 
            // dateNS
            // 
            this.dateNS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNS.EditValue = null;
            this.dateNS.Location = new System.Drawing.Point(237, 233);
            this.dateNS.Name = "dateNS";
            this.dateNS.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNS.Properties.Appearance.Options.UseFont = true;
            this.dateNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNS.Size = new System.Drawing.Size(244, 26);
            this.dateNS.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(237, 191);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(244, 26);
            this.txtDiaChi.TabIndex = 9;
            // 
            // ckbPhai
            // 
            this.ckbPhai.Checked = true;
            this.ckbPhai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPhai.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "PHAI", true));
            this.ckbPhai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPhai.Location = new System.Drawing.Point(237, 147);
            this.ckbPhai.Name = "ckbPhai";
            this.ckbPhai.Size = new System.Drawing.Size(28, 24);
            this.ckbPhai.TabIndex = 7;
            this.ckbPhai.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(406, 101);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(75, 26);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(237, 101);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(163, 26);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(237, 59);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(244, 26);
            this.txtMaSV.TabIndex = 1;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnXoa);
            this.panelBtn.Controls.Add(this.btnReload);
            this.panelBtn.Controls.Add(this.btnGhi);
            this.panelBtn.Controls.Add(this.btnPhucHoi);
            this.panelBtn.Controls.Add(this.btnSua);
            this.panelBtn.Controls.Add(this.btnThem);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(2, 418);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(557, 161);
            this.panelBtn.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DarkGray;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnXoa.Location = new System.Drawing.Point(384, 40);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 43);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 5;
            this.btnReload.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.DarkGray;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReload.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnReload.Location = new System.Drawing.Point(359, 95);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(122, 43);
            this.btnReload.TabIndex = 52;
            this.btnReload.TabStop = false;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.Transparent;
            this.btnGhi.BorderRadius = 5;
            this.btnGhi.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnGhi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGhi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGhi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGhi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGhi.FillColor = System.Drawing.Color.DarkGray;
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.Black;
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGhi.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnGhi.Location = new System.Drawing.Point(78, 95);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(94, 43);
            this.btnGhi.TabIndex = 51;
            this.btnGhi.TabStop = false;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.BackColor = System.Drawing.Color.Transparent;
            this.btnPhucHoi.BorderRadius = 5;
            this.btnPhucHoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnPhucHoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhucHoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhucHoi.FillColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.ForeColor = System.Drawing.Color.Black;
            this.btnPhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Image")));
            this.btnPhucHoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhucHoi.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnPhucHoi.Location = new System.Drawing.Point(202, 95);
            this.btnPhucHoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(129, 43);
            this.btnPhucHoi.TabIndex = 50;
            this.btnPhucHoi.TabStop = false;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 5;
            this.btnSua.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.DarkGray;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSua.Location = new System.Drawing.Point(211, 40);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 43);
            this.btnSua.TabIndex = 49;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Hiệu chỉnh";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DarkGray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnThem.Location = new System.Drawing.Point(80, 40);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 43);
            this.btnThem.TabIndex = 48;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_DANGKY_SINHVIEN";
            this.bdsDK.DataSource = this.bdsSV;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // ucSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSV";
            this.Size = new System.Drawing.Size(2074, 585);
            this.Load += new System.EventHandler(this.ucSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).EndInit();
            this.panelSV.ResumeLayout(false);
            this.panelSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBtn)).EndInit();
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLDSV_TCDataSet QLDSV_TCDataSet;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSV;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private DevExpress.XtraEditors.PanelControl panelSV;
        private System.Windows.Forms.CheckBox ckbNghi;
        private DevExpress.XtraEditors.DateEdit dateNS;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.CheckBox ckbPhai;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.PanelControl panelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnReload;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnGhi;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPhucHoi;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSua;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.BindingSource bdsDK;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
    }
}
