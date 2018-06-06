namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormDangNhap
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Error = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenUser = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Password = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên người sử dụng :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu :";
            // 
            // labelControl_Error
            // 
            this.labelControl_Error.Appearance.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl_Error.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_Error.Location = new System.Drawing.Point(203, 194);
            this.labelControl_Error.Name = "labelControl_Error";
            this.labelControl_Error.Size = new System.Drawing.Size(69, 13);
            this.labelControl_Error.TabIndex = 2;
            this.labelControl_Error.Text = "MessageEror";
            // 
            // textEdit_TenUser
            // 
            this.textEdit_TenUser.Location = new System.Drawing.Point(203, 32);
            this.textEdit_TenUser.Name = "textEdit_TenUser";
            this.textEdit_TenUser.Size = new System.Drawing.Size(251, 20);
            this.textEdit_TenUser.TabIndex = 3;
            // 
            // textEdit_Password
            // 
            this.textEdit_Password.Location = new System.Drawing.Point(203, 80);
            this.textEdit_Password.Name = "textEdit_Password";
            this.textEdit_Password.Size = new System.Drawing.Size(251, 20);
            this.textEdit_Password.TabIndex = 4;
            // 
            // simpleButton_DangNhap
            // 
            this.simpleButton_DangNhap.Location = new System.Drawing.Point(203, 126);
            this.simpleButton_DangNhap.Name = "simpleButton_DangNhap";
            this.simpleButton_DangNhap.Size = new System.Drawing.Size(107, 35);
            this.simpleButton_DangNhap.TabIndex = 5;
            this.simpleButton_DangNhap.Text = "Đăng nhập";
            this.simpleButton_DangNhap.Click += new System.EventHandler(this.simpleButton_DangNhap_Click);
            // 
            // simpleButton_Thoat
            // 
            this.simpleButton_Thoat.Location = new System.Drawing.Point(340, 126);
            this.simpleButton_Thoat.Name = "simpleButton_Thoat";
            this.simpleButton_Thoat.Size = new System.Drawing.Size(114, 35);
            this.simpleButton_Thoat.TabIndex = 6;
            this.simpleButton_Thoat.Text = "Thoát";
            this.simpleButton_Thoat.Click += new System.EventHandler(this.simpleButton_Thoat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 222);
            this.Controls.Add(this.simpleButton_Thoat);
            this.Controls.Add(this.simpleButton_DangNhap);
            this.Controls.Add(this.textEdit_Password);
            this.Controls.Add(this.textEdit_TenUser);
            this.Controls.Add(this.labelControl_Error);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl_Error;
        private DevExpress.XtraEditors.TextEdit textEdit_TenUser;
        private DevExpress.XtraEditors.TextEdit textEdit_Password;
        private DevExpress.XtraEditors.SimpleButton simpleButton_DangNhap;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Thoat;
    }
}