namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_OldPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_NewPasswordAgain = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_DoiMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_CheckOldPassword = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_UpdatePassword = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NewPasswordAgain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(39, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập mật khẩu cũ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(39, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập mật khẩu mới :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(39, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(137, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhập lại mật khẩu mới :";
            // 
            // textEdit_OldPassword
            // 
            this.textEdit_OldPassword.Location = new System.Drawing.Point(204, 40);
            this.textEdit_OldPassword.Name = "textEdit_OldPassword";
            this.textEdit_OldPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_OldPassword.Properties.Appearance.Options.UseFont = true;
            this.textEdit_OldPassword.Size = new System.Drawing.Size(300, 24);
            this.textEdit_OldPassword.TabIndex = 1;
            this.textEdit_OldPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit_OldPassword_KeyUp);
            // 
            // textEdit_NewPassword
            // 
            this.textEdit_NewPassword.Location = new System.Drawing.Point(204, 113);
            this.textEdit_NewPassword.Name = "textEdit_NewPassword";
            this.textEdit_NewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_NewPassword.Properties.Appearance.Options.UseFont = true;
            this.textEdit_NewPassword.Size = new System.Drawing.Size(300, 24);
            this.textEdit_NewPassword.TabIndex = 2;
            // 
            // textEdit_NewPasswordAgain
            // 
            this.textEdit_NewPasswordAgain.Location = new System.Drawing.Point(204, 179);
            this.textEdit_NewPasswordAgain.Name = "textEdit_NewPasswordAgain";
            this.textEdit_NewPasswordAgain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_NewPasswordAgain.Properties.Appearance.Options.UseFont = true;
            this.textEdit_NewPasswordAgain.Size = new System.Drawing.Size(300, 24);
            this.textEdit_NewPasswordAgain.TabIndex = 3;
            // 
            // labelControl_DoiMatKhau
            // 
            this.labelControl_DoiMatKhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_DoiMatKhau.Location = new System.Drawing.Point(204, 307);
            this.labelControl_DoiMatKhau.Name = "labelControl_DoiMatKhau";
            this.labelControl_DoiMatKhau.Size = new System.Drawing.Size(57, 19);
            this.labelControl_DoiMatKhau.TabIndex = 6;
            // 
            // labelControl_CheckOldPassword
            // 
            this.labelControl_CheckOldPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_CheckOldPassword.Location = new System.Drawing.Point(204, 81);
            this.labelControl_CheckOldPassword.Name = "labelControl_CheckOldPassword";
            this.labelControl_CheckOldPassword.Size = new System.Drawing.Size(0, 16);
            this.labelControl_CheckOldPassword.TabIndex = 7;
            // 
            // simpleButton_Exit
            // 
            this.simpleButton_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_Exit.Appearance.Options.UseFont = true;
            this.simpleButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Exit.Image")));
            this.simpleButton_Exit.Location = new System.Drawing.Point(394, 235);
            this.simpleButton_Exit.Name = "simpleButton_Exit";
            this.simpleButton_Exit.Size = new System.Drawing.Size(110, 50);
            this.simpleButton_Exit.TabIndex = 5;
            this.simpleButton_Exit.Text = "Thoát";
            this.simpleButton_Exit.Click += new System.EventHandler(this.simpleButton_Exit_Click);
            // 
            // simpleButton_UpdatePassword
            // 
            this.simpleButton_UpdatePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_UpdatePassword.Appearance.Options.UseFont = true;
            this.simpleButton_UpdatePassword.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_UpdatePassword.Image")));
            this.simpleButton_UpdatePassword.Location = new System.Drawing.Point(204, 235);
            this.simpleButton_UpdatePassword.Name = "simpleButton_UpdatePassword";
            this.simpleButton_UpdatePassword.Size = new System.Drawing.Size(110, 50);
            this.simpleButton_UpdatePassword.TabIndex = 4;
            this.simpleButton_UpdatePassword.Text = "Cập nhật";
            this.simpleButton_UpdatePassword.Click += new System.EventHandler(this.simpleButton_UpdatePassword_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.labelControl_CheckOldPassword);
            this.Controls.Add(this.labelControl_DoiMatKhau);
            this.Controls.Add(this.simpleButton_Exit);
            this.Controls.Add(this.simpleButton_UpdatePassword);
            this.Controls.Add(this.textEdit_NewPasswordAgain);
            this.Controls.Add(this.textEdit_NewPassword);
            this.Controls.Add(this.textEdit_OldPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NewPasswordAgain.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_OldPassword;
        private DevExpress.XtraEditors.TextEdit textEdit_NewPassword;
        private DevExpress.XtraEditors.TextEdit textEdit_NewPasswordAgain;
        private DevExpress.XtraEditors.SimpleButton simpleButton_UpdatePassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Exit;
        private DevExpress.XtraEditors.LabelControl labelControl_DoiMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl_CheckOldPassword;
    }
}