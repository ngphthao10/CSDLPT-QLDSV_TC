namespace QLDSV_TC
{
    partial class Frpt_DSSV_DKLTC
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btPreview = new System.Windows.Forms.Button();
            this.DS = new QLDSV_TC.DS();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSV_TC.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.cmbNK = new System.Windows.Forms.ComboBox();
            this.lkMH = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbHK = new System.Windows.Forms.ComboBox();
            this.tfNhom = new DevExpress.XtraEditors.TextEdit();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nIENKHOALabel.Location = new System.Drawing.Point(52, 96);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(101, 23);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "NIÊN KHÓA";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            hOCKYLabel.Location = new System.Drawing.Point(490, 96);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(70, 23);
            hOCKYLabel.TabIndex = 3;
            hOCKYLabel.Text = "HỌC KỲ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAMHLabel.Location = new System.Drawing.Point(52, 154);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(92, 23);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "MÔN HỌC";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nHOMLabel.Location = new System.Drawing.Point(490, 154);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(63, 23);
            nHOMLabel.TabIndex = 7;
            nHOMLabel.Text = "NHÓM";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(230, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(333, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vui lòng nhập những thông tin sau";
            // 
            // btPreview
            // 
            this.btPreview.BackColor = System.Drawing.SystemColors.Desktop;
            this.btPreview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPreview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPreview.Location = new System.Drawing.Point(328, 212);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(137, 42);
            this.btPreview.TabIndex = 9;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = false;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.DS;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbNK
            // 
            this.cmbNK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "NIENKHOA", true));
            this.cmbNK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbNK.FormattingEnabled = true;
            this.cmbNK.Location = new System.Drawing.Point(185, 92);
            this.cmbNK.Name = "cmbNK";
            this.cmbNK.Size = new System.Drawing.Size(248, 31);
            this.cmbNK.TabIndex = 10;
            // 
            // lkMH
            // 
            this.lkMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAMH", true));
            this.lkMH.Location = new System.Drawing.Point(185, 150);
            this.lkMH.Name = "lkMH";
            this.lkMH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkMH.Properties.Appearance.Options.UseFont = true;
            this.lkMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMH.Size = new System.Drawing.Size(248, 30);
            this.lkMH.TabIndex = 11;
            // 
            // cmbHK
            // 
            this.cmbHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "HOCKY", true));
            this.cmbHK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHK.FormattingEnabled = true;
            this.cmbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHK.Location = new System.Drawing.Point(595, 92);
            this.cmbHK.Name = "cmbHK";
            this.cmbHK.Size = new System.Drawing.Size(121, 31);
            this.cmbHK.TabIndex = 12;
            // 
            // tfNhom
            // 
            this.tfNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.tfNhom.Location = new System.Drawing.Point(595, 150);
            this.tfNhom.Name = "tfNhom";
            this.tfNhom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tfNhom.Properties.Appearance.Options.UseFont = true;
            this.tfNhom.Size = new System.Drawing.Size(125, 30);
            this.tfNhom.TabIndex = 13;
            // 
            // Frpt_DSSV_DKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 286);
            this.Controls.Add(this.tfNhom);
            this.Controls.Add(this.cmbHK);
            this.Controls.Add(this.lkMH);
            this.Controls.Add(this.cmbNK);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "Frpt_DSSV_DKLTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frpt_DSSV_DKLTC";
            this.Load += new System.EventHandler(this.Frpt_DSSV_DKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btPreview;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DSTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNK;
        private DevExpress.XtraEditors.LookUpEdit lkMH;
        private System.Windows.Forms.ComboBox cmbHK;
        private DevExpress.XtraEditors.TextEdit tfNhom;
    }
}