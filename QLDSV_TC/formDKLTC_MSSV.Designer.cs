namespace QLDSV_TC
{
    partial class formDKLTC_MSSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.tfMSSV = new DevExpress.XtraEditors.TextEdit();
            this.btXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tfMSSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(171, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vui lòng nhập mã số sinh viên";
            // 
            // tfMSSV
            // 
            this.tfMSSV.Location = new System.Drawing.Point(195, 79);
            this.tfMSSV.Name = "tfMSSV";
            this.tfMSSV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tfMSSV.Properties.Appearance.Options.UseFont = true;
            this.tfMSSV.Size = new System.Drawing.Size(179, 30);
            this.tfMSSV.TabIndex = 0;
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXem.Location = new System.Drawing.Point(175, 130);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(227, 44);
            this.btXem.TabIndex = 3;
            this.btXem.Text = "Xem thông tin lớp tín chỉ";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // formDKLTC_MSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 209);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfMSSV);
            this.Name = "formDKLTC_MSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form nhập mã sinh viên";
            this.Load += new System.EventHandler(this.formDKLTC_MSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tfMSSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXem;
        public DevExpress.XtraEditors.TextEdit tfMSSV;
    }
}