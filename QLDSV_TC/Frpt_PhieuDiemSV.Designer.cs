namespace QLDSV_TC
{
    partial class Frpt_PhieuDiemSV
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
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMASV = new System.Windows.Forms.ComboBox();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.DS1 = new QLDSV_TC.DS1();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SINHVIENTableAdapter = new QLDSV_TC.DS1TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHOTENSV = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(235, 60);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(331, 31);
            this.cmbKhoa.TabIndex = 3;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ và tên";
            // 
            // cmbMASV
            // 
            this.cmbMASV.DataSource = this.bdsSINHVIEN;
            this.cmbMASV.DisplayMember = "MASV";
            this.cmbMASV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMASV.FormattingEnabled = true;
            this.cmbMASV.Location = new System.Drawing.Point(235, 127);
            this.cmbMASV.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMASV.Name = "cmbMASV";
            this.cmbMASV.Size = new System.Drawing.Size(331, 31);
            this.cmbMASV.TabIndex = 5;
            this.cmbMASV.ValueMember = "HOTENSV";
            this.cmbMASV.SelectedIndexChanged += new System.EventHandler(this.cmbMASV_SelectedIndexChanged);
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "SINHVIEN";
            this.bdsSINHVIEN.DataSource = this.DS1;
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Appearance.Options.UseBackColor = true;
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.Appearance.Options.UseForeColor = true;
            this.btnPreview.Location = new System.Drawing.Point(191, 278);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(133, 41);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.Location = new System.Drawing.Point(403, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "MASV";
            // 
            // txtHOTENSV
            // 
            this.txtHOTENSV.Enabled = false;
            this.txtHOTENSV.Location = new System.Drawing.Point(235, 197);
            this.txtHOTENSV.Margin = new System.Windows.Forms.Padding(5);
            this.txtHOTENSV.Name = "txtHOTENSV";
            this.txtHOTENSV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTENSV.Properties.Appearance.Options.UseFont = true;
            this.txtHOTENSV.Size = new System.Drawing.Size(331, 30);
            this.txtHOTENSV.TabIndex = 9;
            // 
            // Frpt_PhieuDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 375);
            this.Controls.Add(this.txtHOTENSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbMASV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frpt_PhieuDiemSV";
            this.Text = "Frpt_PhieuDiemSV";
            this.Load += new System.EventHandler(this.Frpt_PhieuDiemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMASV;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DS1 DS1;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DS1TableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtHOTENSV;
    }
}