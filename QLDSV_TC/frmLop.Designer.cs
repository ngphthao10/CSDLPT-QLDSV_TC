namespace QLDSV_TC
{
    partial class frmLop
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
            System.Windows.Forms.Label lblMaKhoa;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnTaiSV = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKhoa = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtKhoa = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.DS = new QLDSV_TC.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSV_TC.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.gcSV = new DevExpress.XtraGrid.GridControl();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.gridViewSV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSV = new DevExpress.XtraEditors.PanelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.ckbNghiHoc = new System.Windows.Forms.CheckBox();
            this.txtMaLop1 = new DevExpress.XtraEditors.TextEdit();
            this.dateNS = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.ckbPhai = new System.Windows.Forms.CheckBox();
            this.btnXoaSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnReloadSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnGhiSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnPhucHoiSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnHieuChinhSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnThemSV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.groupBoxLop = new DevExpress.XtraEditors.PanelControl();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager2 = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.SINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            lblMaKhoa = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).BeginInit();
            this.panelSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxLop)).BeginInit();
            this.groupBoxLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMaKhoa.Location = new System.Drawing.Point(47, 207);
            lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(80, 23);
            lblMaKhoa.TabIndex = 6;
            lblMaKhoa.Text = "Mã khoa:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(47, 57);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 23);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(47, 108);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(69, 23);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kHOAHOCLabel.Location = new System.Drawing.Point(47, 159);
            kHOAHOCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(86, 23);
            kHOAHOCLabel.TabIndex = 7;
            kHOAHOCLabel.Text = "Khóa học:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pASSWORDLabel.Location = new System.Drawing.Point(33, 682);
            pASSWORDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(84, 23);
            pASSWORDLabel.TabIndex = 53;
            pASSWORDLabel.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(33, 582);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 23);
            label1.TabIndex = 51;
            label1.Text = "Mã lớp:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(33, 382);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(88, 23);
            hOLabel.TabIndex = 43;
            hOLabel.Text = "Họ và tên:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(33, 332);
            mASVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(110, 23);
            mASVLabel.TabIndex = 42;
            mASVLabel.Text = "Mã sinh viên:";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dANGHIHOCLabel.Location = new System.Drawing.Point(33, 633);
            dANGHIHOCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(107, 23);
            dANGHIHOCLabel.TabIndex = 35;
            dANGHIHOCLabel.Text = "Đã nghỉ học:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(33, 532);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(90, 23);
            nGAYSINHLabel.TabIndex = 34;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(33, 482);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(66, 23);
            dIACHILabel.TabIndex = 33;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(33, 432);
            pHAILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(51, 23);
            pHAILabel.TabIndex = 32;
            pHAILabel.Text = "Nam:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.barButtonItem3,
            this.barLargeButtonItem1,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(280, 163);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.btnThem, "Thêm", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "USERNAME:";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "HỌ VÀ TÊN:";
            this.barStaticItem2.Id = 10;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "NHÓM:";
            this.barStaticItem3.Id = 11;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1940, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1035);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1940, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1005);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1940, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1005);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 8;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.btnTaiSV);
            this.siticonePanel1.Controls.Add(this.cmbKhoa);
            this.siticonePanel1.Controls.Add(this.txtKhoa);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 30);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel1.Size = new System.Drawing.Size(1940, 60);
            this.siticonePanel1.TabIndex = 4;
            // 
            // btnTaiSV
            // 
            this.btnTaiSV.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiSV.Appearance.Options.UseFont = true;
            this.btnTaiSV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaiSV.Location = new System.Drawing.Point(1790, 12);
            this.btnTaiSV.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiSV.Name = "btnTaiSV";
            this.btnTaiSV.Size = new System.Drawing.Size(150, 48);
            this.btnTaiSV.TabIndex = 2;
            this.btnTaiSV.Text = "Tải sinh viên";
            this.btnTaiSV.Click += new System.EventHandler(this.btnTaiSV_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cmbKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbKhoa.ItemHeight = 30;
            this.cmbKhoa.Location = new System.Drawing.Point(77, 16);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(312, 36);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // txtKhoa
            // 
            this.txtKhoa.AutoSize = false;
            this.txtKhoa.BackColor = System.Drawing.Color.Transparent;
            this.txtKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(0, 12);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(69, 48);
            this.txtKhoa.TabIndex = 0;
            this.txtKhoa.Text = "Khoa";
            this.txtKhoa.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.gcSV);
            this.controlPanel.Controls.Add(this.gcLop);
            this.controlPanel.Controls.Add(this.panelSV);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 90);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1940, 945);
            this.controlPanel.TabIndex = 11;
            // 
            // gcSV
            // 
            this.gcSV.DataSource = this.bdsSV;
            this.gcSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSV.Location = new System.Drawing.Point(0, 295);
            this.gcSV.MainView = this.gridViewSV;
            this.gcSV.MenuManager = this.barManager1;
            this.gcSV.Name = "gcSV";
            this.gcSV.Size = new System.Drawing.Size(1471, 650);
            this.gcSV.TabIndex = 10;
            this.gcSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSV});
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colMALOP1,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridViewSV.GridControl = this.gcSV;
            this.gridViewSV.Name = "gridViewSV";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            this.colMALOP1.Width = 94;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 94;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 25;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            this.colPASSWORD.Width = 94;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcLop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcLop.Location = new System.Drawing.Point(0, 0);
            this.gcLop.MainView = this.gridViewLop;
            this.gcLop.Margin = new System.Windows.Forms.Padding(4);
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.gcLop.Size = new System.Drawing.Size(1471, 295);
            this.gcLop.TabIndex = 10;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            // 
            // gridViewLop
            // 
            this.gridViewLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridViewLop.DetailHeight = 431;
            this.gridViewLop.GridControl = this.gcLop;
            this.gridViewLop.Name = "gridViewLop";
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceHeader.Options.UseFont = true;
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 23;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 87;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceCell.Options.UseFont = true;
            this.colTENLOP.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceHeader.Options.UseFont = true;
            this.colTENLOP.Caption = "TÊN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 23;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 87;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colKHOAHOC.AppearanceCell.Options.UseFont = true;
            this.colKHOAHOC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colKHOAHOC.AppearanceHeader.Options.UseFont = true;
            this.colKHOAHOC.Caption = "KHÓA HỌC";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 23;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 87;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceCell.Options.UseFont = true;
            this.colMAKHOA.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceHeader.Options.UseFont = true;
            this.colMAKHOA.Caption = "MÃ KHOA";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 23;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 87;
            // 
            // panelSV
            // 
            this.panelSV.Controls.Add(this.txtPass);
            this.panelSV.Controls.Add(this.ckbNghiHoc);
            this.panelSV.Controls.Add(this.txtMaLop1);
            this.panelSV.Controls.Add(this.dateNS);
            this.panelSV.Controls.Add(this.txtDiaChi);
            this.panelSV.Controls.Add(this.txtTen);
            this.panelSV.Controls.Add(this.txtHo);
            this.panelSV.Controls.Add(this.txtMaSV);
            this.panelSV.Controls.Add(this.ckbPhai);
            this.panelSV.Controls.Add(pASSWORDLabel);
            this.panelSV.Controls.Add(label1);
            this.panelSV.Controls.Add(hOLabel);
            this.panelSV.Controls.Add(mASVLabel);
            this.panelSV.Controls.Add(this.btnXoaSV);
            this.panelSV.Controls.Add(this.btnReloadSV);
            this.panelSV.Controls.Add(this.btnGhiSV);
            this.panelSV.Controls.Add(this.btnPhucHoiSV);
            this.panelSV.Controls.Add(this.btnHieuChinhSV);
            this.panelSV.Controls.Add(this.btnThemSV);
            this.panelSV.Controls.Add(dANGHIHOCLabel);
            this.panelSV.Controls.Add(nGAYSINHLabel);
            this.panelSV.Controls.Add(dIACHILabel);
            this.panelSV.Controls.Add(pHAILabel);
            this.panelSV.Controls.Add(this.groupBoxLop);
            this.panelSV.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSV.Location = new System.Drawing.Point(1471, 0);
            this.panelSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(469, 945);
            this.panelSV.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PASSWORD", true));
            this.txtPass.Location = new System.Drawing.Point(167, 683);
            this.txtPass.MenuManager = this.barManager1;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(248, 22);
            this.txtPass.TabIndex = 71;
            // 
            // ckbNghiHoc
            // 
            this.ckbNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "DANGHIHOC", true));
            this.ckbNghiHoc.Location = new System.Drawing.Point(167, 631);
            this.ckbNghiHoc.Name = "ckbNghiHoc";
            this.ckbNghiHoc.Size = new System.Drawing.Size(26, 24);
            this.ckbNghiHoc.TabIndex = 70;
            this.ckbNghiHoc.UseVisualStyleBackColor = true;
            // 
            // txtMaLop1
            // 
            this.txtMaLop1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txtMaLop1.Enabled = false;
            this.txtMaLop1.Location = new System.Drawing.Point(167, 581);
            this.txtMaLop1.MenuManager = this.barManager1;
            this.txtMaLop1.Name = "txtMaLop1";
            this.txtMaLop1.Size = new System.Drawing.Size(249, 22);
            this.txtMaLop1.TabIndex = 69;
            // 
            // dateNS
            // 
            this.dateNS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNS.EditValue = null;
            this.dateNS.Location = new System.Drawing.Point(167, 531);
            this.dateNS.MenuManager = this.barManager1;
            this.dateNS.Name = "dateNS";
            this.dateNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNS.Size = new System.Drawing.Size(248, 22);
            this.dateNS.TabIndex = 68;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(167, 481);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(249, 22);
            this.txtDiaChi.TabIndex = 67;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(347, 379);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(68, 22);
            this.txtTen.TabIndex = 66;
            this.txtTen.EditValueChanged += new System.EventHandler(this.txtTen_EditValueChanged);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(167, 379);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(163, 22);
            this.txtHo.TabIndex = 65;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(167, 329);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(248, 22);
            this.txtMaSV.TabIndex = 64;
            // 
            // ckbPhai
            // 
            this.ckbPhai.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "PHAI", true));
            this.ckbPhai.Location = new System.Drawing.Point(167, 429);
            this.ckbPhai.Name = "ckbPhai";
            this.ckbPhai.Size = new System.Drawing.Size(18, 24);
            this.ckbPhai.TabIndex = 63;
            this.ckbPhai.UseVisualStyleBackColor = true;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaSV.BorderRadius = 5;
            this.btnXoaSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnXoaSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnXoaSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnXoaSV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.Image")));
            this.btnXoaSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaSV.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnXoaSV.Location = new System.Drawing.Point(332, 757);
            this.btnXoaSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(83, 46);
            this.btnXoaSV.TabIndex = 41;
            this.btnXoaSV.TabStop = false;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnReloadSV
            // 
            this.btnReloadSV.BackColor = System.Drawing.Color.Transparent;
            this.btnReloadSV.BorderRadius = 5;
            this.btnReloadSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnReloadSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReloadSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReloadSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnReloadSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnReloadSV.ForeColor = System.Drawing.Color.Black;
            this.btnReloadSV.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadSV.Image")));
            this.btnReloadSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReloadSV.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnReloadSV.Location = new System.Drawing.Point(309, 827);
            this.btnReloadSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReloadSV.Name = "btnReloadSV";
            this.btnReloadSV.Size = new System.Drawing.Size(107, 46);
            this.btnReloadSV.TabIndex = 40;
            this.btnReloadSV.TabStop = false;
            this.btnReloadSV.Text = "Reload";
            this.btnReloadSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReloadSV.Click += new System.EventHandler(this.btnReloadSV_Click);
            // 
            // btnGhiSV
            // 
            this.btnGhiSV.BackColor = System.Drawing.Color.Transparent;
            this.btnGhiSV.BorderRadius = 5;
            this.btnGhiSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnGhiSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGhiSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGhiSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGhiSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGhiSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnGhiSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnGhiSV.ForeColor = System.Drawing.Color.Black;
            this.btnGhiSV.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiSV.Image")));
            this.btnGhiSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGhiSV.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnGhiSV.Location = new System.Drawing.Point(38, 827);
            this.btnGhiSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGhiSV.Name = "btnGhiSV";
            this.btnGhiSV.Size = new System.Drawing.Size(83, 46);
            this.btnGhiSV.TabIndex = 39;
            this.btnGhiSV.TabStop = false;
            this.btnGhiSV.Text = "Ghi";
            this.btnGhiSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGhiSV.Click += new System.EventHandler(this.btnGhiSV_Click);
            // 
            // btnPhucHoiSV
            // 
            this.btnPhucHoiSV.BackColor = System.Drawing.Color.Transparent;
            this.btnPhucHoiSV.BorderRadius = 5;
            this.btnPhucHoiSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnPhucHoiSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoiSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoiSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhucHoiSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhucHoiSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnPhucHoiSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPhucHoiSV.ForeColor = System.Drawing.Color.Black;
            this.btnPhucHoiSV.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiSV.Image")));
            this.btnPhucHoiSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhucHoiSV.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnPhucHoiSV.Location = new System.Drawing.Point(158, 827);
            this.btnPhucHoiSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPhucHoiSV.Name = "btnPhucHoiSV";
            this.btnPhucHoiSV.Size = new System.Drawing.Size(125, 46);
            this.btnPhucHoiSV.TabIndex = 38;
            this.btnPhucHoiSV.TabStop = false;
            this.btnPhucHoiSV.Text = "Phục hồi";
            this.btnPhucHoiSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPhucHoiSV.Click += new System.EventHandler(this.btnPhucHoiSV_Click);
            // 
            // btnHieuChinhSV
            // 
            this.btnHieuChinhSV.BackColor = System.Drawing.Color.Transparent;
            this.btnHieuChinhSV.BorderRadius = 5;
            this.btnHieuChinhSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnHieuChinhSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHieuChinhSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHieuChinhSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHieuChinhSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHieuChinhSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnHieuChinhSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnHieuChinhSV.ForeColor = System.Drawing.Color.Black;
            this.btnHieuChinhSV.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinhSV.Image")));
            this.btnHieuChinhSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHieuChinhSV.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnHieuChinhSV.Location = new System.Drawing.Point(167, 757);
            this.btnHieuChinhSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHieuChinhSV.Name = "btnHieuChinhSV";
            this.btnHieuChinhSV.Size = new System.Drawing.Size(139, 46);
            this.btnHieuChinhSV.TabIndex = 37;
            this.btnHieuChinhSV.TabStop = false;
            this.btnHieuChinhSV.Text = "Hiệu chỉnh";
            this.btnHieuChinhSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHieuChinhSV.Click += new System.EventHandler(this.btnHieuChinhSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemSV.BorderRadius = 5;
            this.btnThemSV.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnThemSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSV.FillColor = System.Drawing.Color.DarkGray;
            this.btnThemSV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnThemSV.ForeColor = System.Drawing.Color.Black;
            this.btnThemSV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSV.Image")));
            this.btnThemSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemSV.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnThemSV.Location = new System.Drawing.Point(37, 757);
            this.btnThemSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(96, 46);
            this.btnThemSV.TabIndex = 36;
            this.btnThemSV.TabStop = false;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // groupBoxLop
            // 
            this.groupBoxLop.Controls.Add(this.txtTenLop);
            this.groupBoxLop.Controls.Add(this.txtMaLop);
            this.groupBoxLop.Controls.Add(this.txtMaKhoa);
            this.groupBoxLop.Controls.Add(kHOAHOCLabel);
            this.groupBoxLop.Controls.Add(tENLOPLabel);
            this.groupBoxLop.Controls.Add(mALOPLabel);
            this.groupBoxLop.Controls.Add(lblMaKhoa);
            this.groupBoxLop.Controls.Add(this.txtKhoaHoc);
            this.groupBoxLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxLop.Location = new System.Drawing.Point(2, 2);
            this.groupBoxLop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxLop.Name = "groupBoxLop";
            this.groupBoxLop.Size = new System.Drawing.Size(465, 294);
            this.groupBoxLop.TabIndex = 9;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(139, 103);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(246, 30);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(139, 53);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(246, 30);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKHOA", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(139, 203);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(246, 30);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "KHOAHOC", true));
            this.txtKhoaHoc.Location = new System.Drawing.Point(139, 156);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtKhoaHoc.MenuManager = this.barManager1;
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoaHoc.Properties.Appearance.Options.UseFont = true;
            this.txtKhoaHoc.Size = new System.Drawing.Size(246, 30);
            this.txtKhoaHoc.TabIndex = 8;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager2.DANGKYTableAdapter = null;
            this.tableAdapterManager2.GIANGVIENTableAdapter = null;
            this.tableAdapterManager2.HOCPHITableAdapter = null;
            this.tableAdapterManager2.KHOATableAdapter = null;
            this.tableAdapterManager2.LOPTableAdapter = null;
            this.tableAdapterManager2.LOPTINCHITableAdapter = null;
            this.tableAdapterManager2.MONHOCTableAdapter = null;
            this.tableAdapterManager2.SINHVIENTableAdapter = null;
            this.tableAdapterManager2.SP_DSSV_MALOPTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "DANGKY";
            this.bdsDangKy.DataSource = this.qLDSV_TCDataSet;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsSinhVien.DataSource = this.bdsSV;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1940, 1062);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSV)).EndInit();
            this.panelSV.ResumeLayout(false);
            this.panelSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxLop)).EndInit();
            this.groupBoxLop.ResumeLayout(false);
            this.groupBoxLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbKhoa;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel txtKhoa;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraEditors.PanelControl panelSV;
        private DevExpress.XtraEditors.PanelControl groupBoxLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private DevExpress.XtraEditors.SimpleButton btnTaiSV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoaSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnReloadSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnGhiSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPhucHoiSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHieuChinhSV;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnThemSV;
        private System.Windows.Forms.BindingSource bdsSV;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private System.Windows.Forms.CheckBox ckbPhai;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.CheckBox ckbNghiHoc;
        private DevExpress.XtraEditors.TextEdit txtMaLop1;
        private DevExpress.XtraEditors.DateEdit dateNS;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
    }
}