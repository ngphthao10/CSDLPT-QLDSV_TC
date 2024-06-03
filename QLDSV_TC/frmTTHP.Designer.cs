namespace QLDSV_TC
{
    partial class frmTTHP
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
            System.Windows.Forms.Label nGAYDONGLabel;
            System.Windows.Forms.Label sOTIENDONGLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnGhiHP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNopHP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnTaiHP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcCTHP = new DevExpress.XtraGrid.GridControl();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.QLDSV_TCDataSetSV3 = new QLDSV_TC.QLDSV_TCDataSetSV3();
            this.gridViewCTHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCTHP = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.bdsHP = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETHOCPHI_MASVTableAdapter = new QLDSV_TC.QLDSV_TCDataSetSV3TableAdapters.SP_GETHOCPHI_MASVTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetSV3TableAdapters.TableAdapterManager();
            this.SINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetSV3TableAdapters.SINHVIENTableAdapter();
            this.gcHP = new DevExpress.XtraGrid.GridControl();
            this.gridViewHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SP_GETCTHOCPHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetSV3TableAdapters.SP_GETCTHOCPHITableAdapter();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            nGAYDONGLabel = new System.Windows.Forms.Label();
            sOTIENDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSetSV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHP)).BeginInit();
            this.panelCTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYDONGLabel
            // 
            nGAYDONGLabel.AutoSize = true;
            nGAYDONGLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYDONGLabel.Location = new System.Drawing.Point(53, 17);
            nGAYDONGLabel.Name = "nGAYDONGLabel";
            nGAYDONGLabel.Size = new System.Drawing.Size(86, 20);
            nGAYDONGLabel.TabIndex = 0;
            nGAYDONGLabel.Text = "Ngày đóng:";
            // 
            // sOTIENDONGLabel
            // 
            sOTIENDONGLabel.AutoSize = true;
            sOTIENDONGLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENDONGLabel.Location = new System.Drawing.Point(53, 66);
            sOTIENDONGLabel.Name = "sOTIENDONGLabel";
            sOTIENDONGLabel.Size = new System.Drawing.Size(97, 20);
            sOTIENDONGLabel.TabIndex = 2;
            sOTIENDONGLabel.Text = "Số tiền đóng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnGhiHP);
            this.panelControl1.Controls.Add(this.btnNopHP);
            this.panelControl1.Controls.Add(this.btnTaiHP);
            this.panelControl1.Controls.Add(this.txtMaLop);
            this.panelControl1.Controls.Add(this.lblMaLop);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.lblHoTen);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1827, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnThoat.Size = new System.Drawing.Size(71, 57);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiHP
            // 
            this.btnGhiHP.BorderRadius = 10;
            this.btnGhiHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGhiHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGhiHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGhiHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGhiHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGhiHP.ForeColor = System.Drawing.Color.White;
            this.btnGhiHP.Location = new System.Drawing.Point(1679, 25);
            this.btnGhiHP.Name = "btnGhiHP";
            this.btnGhiHP.Size = new System.Drawing.Size(126, 54);
            this.btnGhiHP.TabIndex = 12;
            this.btnGhiHP.Text = "Ghi học phí";
            this.btnGhiHP.Click += new System.EventHandler(this.btnGhiHP_Click);
            // 
            // btnNopHP
            // 
            this.btnNopHP.BorderRadius = 10;
            this.btnNopHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNopHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNopHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNopHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNopHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNopHP.ForeColor = System.Drawing.Color.White;
            this.btnNopHP.Location = new System.Drawing.Point(1529, 25);
            this.btnNopHP.Name = "btnNopHP";
            this.btnNopHP.Size = new System.Drawing.Size(126, 54);
            this.btnNopHP.TabIndex = 11;
            this.btnNopHP.Text = "Nộp học phí";
            this.btnNopHP.Click += new System.EventHandler(this.btnNopHP_Click);
            // 
            // btnTaiHP
            // 
            this.btnTaiHP.BorderRadius = 10;
            this.btnTaiHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaiHP.ForeColor = System.Drawing.Color.White;
            this.btnTaiHP.Location = new System.Drawing.Point(1283, 25);
            this.btnTaiHP.Name = "btnTaiHP";
            this.btnTaiHP.Size = new System.Drawing.Size(221, 54);
            this.btnTaiHP.TabIndex = 10;
            this.btnTaiHP.Text = "Thông tin đóng học phí";
            this.btnTaiHP.Click += new System.EventHandler(this.btnTaiHP_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(731, 37);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(154, 27);
            this.txtMaLop.TabIndex = 9;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(650, 40);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(59, 20);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(465, 37);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(154, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(368, 40);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(76, 20);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(183, 37);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(154, 27);
            this.txtMaSV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã sinh viên:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcCTHP);
            this.panelControl2.Controls.Add(this.panelCTHP);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1457, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(467, 574);
            this.panelControl2.TabIndex = 2;
            // 
            // gcCTHP
            // 
            this.gcCTHP.DataSource = this.bdsCTHP;
            this.gcCTHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTHP.Location = new System.Drawing.Point(2, 108);
            this.gcCTHP.MainView = this.gridViewCTHP;
            this.gcCTHP.Name = "gcCTHP";
            this.gcCTHP.Size = new System.Drawing.Size(463, 464);
            this.gcCTHP.TabIndex = 1;
            this.gcCTHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTHP});
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "SP_GETCTHOCPHI";
            this.bdsCTHP.DataSource = this.QLDSV_TCDataSetSV3;
            // 
            // QLDSV_TCDataSetSV3
            // 
            this.QLDSV_TCDataSetSV3.DataSetName = "QLDSV_TCDataSetSV3";
            this.QLDSV_TCDataSetSV3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCTHP
            // 
            this.gridViewCTHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridViewCTHP.GridControl = this.gcCTHP;
            this.gridViewCTHP.Name = "gridViewCTHP";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYDONG.AppearanceCell.Options.UseFont = true;
            this.colNGAYDONG.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYDONG.AppearanceHeader.Options.UseFont = true;
            this.colNGAYDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDONG.Caption = "NGÀY ĐÓNG";
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 25;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.OptionsColumn.ReadOnly = true;
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 94;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDONG.AppearanceCell.Options.UseFont = true;
            this.colSOTIENDONG.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDONG.AppearanceHeader.Options.UseFont = true;
            this.colSOTIENDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIENDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIENDONG.Caption = "SỐ TIỀN ĐÓNG";
            this.colSOTIENDONG.DisplayFormat.FormatString = "n0";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 25;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.OptionsColumn.ReadOnly = true;
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 94;
            // 
            // panelCTHP
            // 
            this.panelCTHP.Controls.Add(sOTIENDONGLabel);
            this.panelCTHP.Controls.Add(this.txtSoTien);
            this.panelCTHP.Controls.Add(nGAYDONGLabel);
            this.panelCTHP.Controls.Add(this.dateNgay);
            this.panelCTHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCTHP.Location = new System.Drawing.Point(2, 2);
            this.panelCTHP.Name = "panelCTHP";
            this.panelCTHP.Size = new System.Drawing.Size(463, 106);
            this.panelCTHP.TabIndex = 0;
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTHP, "SOTIENDONG", true));
            this.txtSoTien.Location = new System.Drawing.Point(181, 63);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Properties.EditFormat.FormatString = "n0";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(125, 26);
            this.txtSoTien.TabIndex = 3;
            // 
            // dateNgay
            // 
            this.dateNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTHP, "NGAYDONG", true));
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(181, 14);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Properties.Appearance.Options.UseFont = true;
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Size = new System.Drawing.Size(125, 26);
            this.dateNgay.TabIndex = 1;
            // 
            // bdsHP
            // 
            this.bdsHP.DataMember = "SP_GETHOCPHI_MASV";
            this.bdsHP.DataSource = this.QLDSV_TCDataSetSV3;
            // 
            // SP_GETHOCPHI_MASVTableAdapter
            // 
            this.SP_GETHOCPHI_MASVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetSV3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcHP
            // 
            this.gcHP.DataSource = this.bdsHP;
            this.gcHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHP.Location = new System.Drawing.Point(0, 100);
            this.gcHP.MainView = this.gridViewHP;
            this.gcHP.Name = "gcHP";
            this.gcHP.Size = new System.Drawing.Size(1457, 574);
            this.gcHP.TabIndex = 5;
            this.gcHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHP});
            // 
            // gridViewHP
            // 
            this.gridViewHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colDADONG,
            this.colCanDong});
            this.gridViewHP.GridControl = this.gcHP;
            this.gridViewHP.Name = "gridViewHP";
            this.gridViewHP.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewHP_RowClick);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceCell.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.Caption = "NIÊN KHÓA";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.ReadOnly = true;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 285;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceCell.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.Caption = "HỌC KỲ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.ReadOnly = true;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 285;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceCell.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceHeader.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCPHI.Caption = "HỌC PHÍ";
            this.colHOCPHI.DisplayFormat.FormatString = "n0";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.ReadOnly = true;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 287;
            // 
            // colDADONG
            // 
            this.colDADONG.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDADONG.AppearanceCell.Options.UseFont = true;
            this.colDADONG.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDADONG.AppearanceHeader.Options.UseFont = true;
            this.colDADONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colDADONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDADONG.Caption = "SỐ TIỀN ĐÃ ĐÓNG";
            this.colDADONG.DisplayFormat.FormatString = "n0";
            this.colDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDADONG.FieldName = "DADONG";
            this.colDADONG.MinWidth = 25;
            this.colDADONG.Name = "colDADONG";
            this.colDADONG.OptionsColumn.ReadOnly = true;
            this.colDADONG.Visible = true;
            this.colDADONG.VisibleIndex = 3;
            this.colDADONG.Width = 284;
            // 
            // colCanDong
            // 
            this.colCanDong.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCanDong.AppearanceCell.Options.UseFont = true;
            this.colCanDong.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCanDong.AppearanceHeader.Options.UseFont = true;
            this.colCanDong.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDong.Caption = "SỐ TIỀN CẦN ĐÓNG";
            this.colCanDong.DisplayFormat.FormatString = "n0";
            this.colCanDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCanDong.FieldName = "colCanDong";
            this.colCanDong.MinWidth = 25;
            this.colCanDong.Name = "colCanDong";
            this.colCanDong.OptionsColumn.ReadOnly = true;
            this.colCanDong.UnboundDataType = typeof(int);
            this.colCanDong.UnboundExpression = "[HOCPHI] - [DADONG]";
            this.colCanDong.Visible = true;
            this.colCanDong.VisibleIndex = 4;
            this.colCanDong.Width = 286;
            // 
            // SP_GETCTHOCPHITableAdapter
            // 
            this.SP_GETCTHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.QLDSV_TCDataSetSV3;
            // 
            // frmTTHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 674);
            this.Controls.Add(this.gcHP);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTTHP";
            this.Text = "frmTTHP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTTHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSetSV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCTHP)).EndInit();
            this.panelCTHP.ResumeLayout(false);
            this.panelCTHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTaiHP;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private QLDSV_TCDataSetSV3 QLDSV_TCDataSetSV3;
        private System.Windows.Forms.BindingSource bdsHP;
        private QLDSV_TCDataSetSV3TableAdapters.SP_GETHOCPHI_MASVTableAdapter SP_GETHOCPHI_MASVTableAdapter;
        private QLDSV_TCDataSetSV3TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHP;
        private DevExpress.XtraEditors.PanelControl panelCTHP;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private QLDSV_TCDataSetSV3TableAdapters.SP_GETCTHOCPHITableAdapter SP_GETCTHOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTHP;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDong;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private QLDSV_TCDataSetSV3TableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNopHP;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnGhiHP;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnThoat;
    }
}