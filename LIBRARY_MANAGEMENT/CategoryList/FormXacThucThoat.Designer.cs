namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormXacThucThoat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXacThucThoat));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_CoThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_KhongThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(28, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(345, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bạn có chắc chắn muốn thoát chương trình";
            // 
            // simpleButton_CoThoat
            // 
            this.simpleButton_CoThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_CoThoat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton_CoThoat.Appearance.Options.UseFont = true;
            this.simpleButton_CoThoat.Appearance.Options.UseForeColor = true;
            this.simpleButton_CoThoat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_CoThoat.Image")));
            this.simpleButton_CoThoat.Location = new System.Drawing.Point(57, 88);
            this.simpleButton_CoThoat.Name = "simpleButton_CoThoat";
            this.simpleButton_CoThoat.Size = new System.Drawing.Size(121, 45);
            this.simpleButton_CoThoat.TabIndex = 1;
            this.simpleButton_CoThoat.Text = "Có";
            this.simpleButton_CoThoat.Click += new System.EventHandler(this.simpleButton_CoThoat_Click);
            // 
            // simpleButton_KhongThoat
            // 
            this.simpleButton_KhongThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_KhongThoat.Appearance.Options.UseFont = true;
            this.simpleButton_KhongThoat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_KhongThoat.Image")));
            this.simpleButton_KhongThoat.Location = new System.Drawing.Point(219, 88);
            this.simpleButton_KhongThoat.Name = "simpleButton_KhongThoat";
            this.simpleButton_KhongThoat.Size = new System.Drawing.Size(121, 45);
            this.simpleButton_KhongThoat.TabIndex = 2;
            this.simpleButton_KhongThoat.Text = "Không";
            this.simpleButton_KhongThoat.Click += new System.EventHandler(this.simpleButton_KhongThoat_Click);
            // 
            // FormXacThucThoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 187);
            this.Controls.Add(this.simpleButton_KhongThoat);
            this.Controls.Add(this.simpleButton_CoThoat);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormXacThucThoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXacThucThoat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_CoThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton_KhongThoat;
    }
}