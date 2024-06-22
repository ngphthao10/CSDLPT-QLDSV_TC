namespace QLDSV_TC
{
    partial class Frpt_BangDiemMHLTC
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
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lOPTINCHI1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new QLDSV_TC.DS1();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_TC.DS1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.lOPTINCHI1TableAdapter = new QLDSV_TC.DS1TableAdapters.LOPTINCHI1TableAdapter();
            this.nhomTableAdapter = new QLDSV_TC.DS1TableAdapters.nhomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHI1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(252, 56);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(508, 31);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Niên khóa";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.lOPTINCHI1BindingSource;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(252, 114);
            this.cmbNienKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(334, 31);
            this.cmbNienKhoa.TabIndex = 7;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // lOPTINCHI1BindingSource
            // 
            this.lOPTINCHI1BindingSource.DataMember = "LOPTINCHI1";
            this.lOPTINCHI1BindingSource.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Học Kỳ";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(695, 114);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(65, 31);
            this.cmbHocKy.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhóm";
            // 
            // cmbNhom
            // 
            this.cmbNhom.DataSource = this.nhomBindingSource;
            this.cmbNhom.DisplayMember = "NHOM";
            this.cmbNhom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(695, 170);
            this.cmbNhom.Margin = new System.Windows.Forms.Padding(5);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(65, 31);
            this.cmbNhom.TabIndex = 13;
            this.cmbNhom.ValueMember = "NHOM";
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "nhom";
            this.nhomBindingSource.DataSource = this.dS1;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.Location = new System.Drawing.Point(283, 248);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(151, 52);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(505, 248);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 52);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS1;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(252, 170);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(334, 31);
            this.cmbMonHoc.TabIndex = 17;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // lOPTINCHI1TableAdapter
            // 
            this.lOPTINCHI1TableAdapter.ClearBeforeFill = true;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // Frpt_BangDiemMHLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 345);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frpt_BangDiemMHLTC";
            this.Text = "Frpt_BangDiemMHLTC";
            this.Load += new System.EventHandler(this.Frpt_BangDiemMHLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHI1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNhom;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DS1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.BindingSource lOPTINCHI1BindingSource;
        private DS1TableAdapters.LOPTINCHI1TableAdapter lOPTINCHI1TableAdapter;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private DS1TableAdapters.nhomTableAdapter nhomTableAdapter;
    }
}