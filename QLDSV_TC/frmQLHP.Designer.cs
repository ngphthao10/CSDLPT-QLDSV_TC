namespace QLDSV_TC
{
    partial class frmQLHP
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
            this.btnTaiHP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsHP = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETHOCPHI_MASVTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_GETHOCPHI_MASVTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETCTHOCPHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_GETCTHOCPHITableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcHP = new DevExpress.XtraGrid.GridControl();
            this.gridViewHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcCTHP = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTHP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            nGAYDONGLabel = new System.Windows.Forms.Label();
            sOTIENDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYDONGLabel
            // 
            nGAYDONGLabel.AutoSize = true;
            nGAYDONGLabel.Location = new System.Drawing.Point(64, 31);
            nGAYDONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYDONGLabel.Name = "nGAYDONGLabel";
            nGAYDONGLabel.Size = new System.Drawing.Size(76, 16);
            nGAYDONGLabel.TabIndex = 0;
            nGAYDONGLabel.Text = "NGAYDONG:";
            // 
            // sOTIENDONGLabel
            // 
            sOTIENDONGLabel.AutoSize = true;
            sOTIENDONGLabel.Location = new System.Drawing.Point(64, 89);
            sOTIENDONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOTIENDONGLabel.Name = "sOTIENDONGLabel";
            sOTIENDONGLabel.Size = new System.Drawing.Size(89, 16);
            sOTIENDONGLabel.TabIndex = 2;
            sOTIENDONGLabel.Text = "SOTIENDONG:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTaiHP);
            this.panelControl1.Controls.Add(this.txtMaLop);
            this.panelControl1.Controls.Add(this.lblMaLop);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.lblHoTen);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 118);
            this.panelControl1.TabIndex = 0;
            // 
            // btnTaiHP
            // 
            this.btnTaiHP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiHP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaiHP.ForeColor = System.Drawing.Color.White;
            this.btnTaiHP.Location = new System.Drawing.Point(1350, 16);
            this.btnTaiHP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTaiHP.Name = "btnTaiHP";
            this.btnTaiHP.Size = new System.Drawing.Size(281, 70);
            this.btnTaiHP.TabIndex = 6;
            this.btnTaiHP.Text = "Thông tin học phí";
            this.btnTaiHP.Click += new System.EventHandler(this.btnTaiHP_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(956, 40);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(154, 23);
            this.txtMaLop.TabIndex = 5;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(840, 50);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 16);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(632, 40);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(154, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(520, 45);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(66, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(265, 40);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(154, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã sinh viên:";
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHP
            // 
            this.bdsHP.DataMember = "SP_GETHOCPHI_MASV";
            this.bdsHP.DataSource = this.QLDSV_TCDataSet;
            // 
            // SP_GETHOCPHI_MASVTableAdapter
            // 
            this.SP_GETHOCPHI_MASVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_DSSV_MALOPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "SP_GETCTHOCPHI";
            this.bdsCTHP.DataSource = this.QLDSV_TCDataSet;
            // 
            // SP_GETCTHOCPHITableAdapter
            // 
            this.SP_GETCTHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcHP);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 118);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1924, 664);
            this.panelControl2.TabIndex = 1;
            // 
            // gcHP
            // 
            this.gcHP.DataSource = this.bdsHP;
            this.gcHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcHP.Location = new System.Drawing.Point(2, 2);
            this.gcHP.MainView = this.gridViewHP;
            this.gcHP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcHP.Name = "gcHP";
            this.gcHP.Size = new System.Drawing.Size(1448, 660);
            this.gcHP.TabIndex = 1;
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
            this.gridViewHP.DetailHeight = 437;
            this.gridViewHP.GridControl = this.gcHP;
            this.gridViewHP.Name = "gridViewHP";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 31;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 117;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 31;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 117;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 31;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 117;
            // 
            // colDADONG
            // 
            this.colDADONG.FieldName = "DADONG";
            this.colDADONG.MinWidth = 31;
            this.colDADONG.Name = "colDADONG";
            this.colDADONG.Visible = true;
            this.colDADONG.VisibleIndex = 3;
            this.colDADONG.Width = 117;
            // 
            // colCanDong
            // 
            this.colCanDong.FieldName = "Số tiền cần đóng";
            this.colCanDong.MinWidth = 31;
            this.colCanDong.Name = "colCanDong";
            this.colCanDong.Visible = true;
            this.colCanDong.VisibleIndex = 4;
            this.colCanDong.Width = 117;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcCTHP);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(1450, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(472, 660);
            this.panelControl3.TabIndex = 2;
            // 
            // gcCTHP
            // 
            this.gcCTHP.DataSource = this.bdsCTHP;
            this.gcCTHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTHP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcCTHP.Location = new System.Drawing.Point(2, 153);
            this.gcCTHP.MainView = this.gridViewCTHP;
            this.gcCTHP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gcCTHP.Name = "gcCTHP";
            this.gcCTHP.Size = new System.Drawing.Size(468, 505);
            this.gcCTHP.TabIndex = 1;
            this.gcCTHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTHP});
            // 
            // gridViewCTHP
            // 
            this.gridViewCTHP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridViewCTHP.DetailHeight = 437;
            this.gridViewCTHP.GridControl = this.gcCTHP;
            this.gridViewCTHP.Name = "gridViewCTHP";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 31;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 117;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 31;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 117;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(sOTIENDONGLabel);
            this.panelControl4.Controls.Add(this.txtSoTien);
            this.panelControl4.Controls.Add(nGAYDONGLabel);
            this.panelControl4.Controls.Add(this.dateNgay);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(468, 151);
            this.panelControl4.TabIndex = 2;
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTHP, "SOTIENDONG", true));
            this.txtSoTien.Location = new System.Drawing.Point(182, 85);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(206, 22);
            this.txtSoTien.TabIndex = 3;
            // 
            // dateNgay
            // 
            this.dateNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTHP, "NGAYDONG", true));
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(182, 28);
            this.dateNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Size = new System.Drawing.Size(206, 22);
            this.dateNgay.TabIndex = 1;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.QLDSV_TCDataSet;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmQLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 782);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLHP";
            this.Text = "frmQLHP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTaiHP;
        private QLDSV_TCDataSet QLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsHP;
        private QLDSV_TCDataSetTableAdapters.SP_GETHOCPHI_MASVTableAdapter SP_GETHOCPHI_MASVTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private QLDSV_TCDataSetTableAdapters.SP_GETCTHOCPHITableAdapter SP_GETCTHOCPHITableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcCTHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTHP;
        private DevExpress.XtraGrid.GridControl gcHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHP;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDong;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private System.Windows.Forms.BindingSource bdsSV;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
    }
}