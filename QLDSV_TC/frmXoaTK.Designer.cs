namespace QLDSV_TC
{
    partial class frmXoaTK
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
            this.lkTen = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoaTK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkTen
            // 
            this.lkTen.Location = new System.Drawing.Point(274, 75);
            this.lkTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkTen.Name = "lkTen";
            this.lkTen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTen.Properties.Appearance.Options.UseFont = true;
            this.lkTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTen.Size = new System.Drawing.Size(360, 30);
            this.lkTen.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(89, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thông tin tài khoản";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaTK.BorderRadius = 10;
            this.btnXoaTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaTK.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK.Location = new System.Drawing.Point(662, 67);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(150, 45);
            this.btnXoaTK.TabIndex = 2;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // frmXoaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 178);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lkTen);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmXoaTK";
            this.Text = "Xóa tài khoản";
            this.Load += new System.EventHandler(this.frmXoaTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lkTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoaTK;
    }
}