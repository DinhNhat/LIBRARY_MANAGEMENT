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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Error = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenUser = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Password = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(48, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên người sử dụng :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(48, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu :";
            // 
            // labelControl_Error
            // 
            this.labelControl_Error.Appearance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Error.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_Error.Location = new System.Drawing.Point(183, 194);
            this.labelControl_Error.Name = "labelControl_Error";
            this.labelControl_Error.Size = new System.Drawing.Size(0, 20);
            this.labelControl_Error.TabIndex = 2;
            // 
            // textEdit_TenUser
            // 
            this.textEdit_TenUser.Location = new System.Drawing.Point(183, 32);
            this.textEdit_TenUser.Name = "textEdit_TenUser";
            this.textEdit_TenUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_TenUser.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenUser.Size = new System.Drawing.Size(264, 22);
            this.textEdit_TenUser.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Contains;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = "@";
            this.dxValidationProvider1.SetValidationRule(this.textEdit_TenUser, conditionValidationRule2);
            // 
            // textEdit_Password
            // 
            this.textEdit_Password.Location = new System.Drawing.Point(183, 80);
            this.textEdit_Password.Name = "textEdit_Password";
            this.textEdit_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_Password.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Password.Size = new System.Drawing.Size(264, 22);
            this.textEdit_Password.TabIndex = 4;
            // 
            // simpleButton_DangNhap
            // 
            this.simpleButton_DangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_DangNhap.Appearance.Options.UseFont = true;
            this.simpleButton_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_DangNhap.Image")));
            this.simpleButton_DangNhap.Location = new System.Drawing.Point(183, 124);
            this.simpleButton_DangNhap.Name = "simpleButton_DangNhap";
            this.simpleButton_DangNhap.Size = new System.Drawing.Size(121, 42);
            this.simpleButton_DangNhap.TabIndex = 5;
            this.simpleButton_DangNhap.Text = "Đăng nhập";
            this.simpleButton_DangNhap.Click += new System.EventHandler(this.simpleButton_DangNhap_Click);
            // 
            // simpleButton_Thoat
            // 
            this.simpleButton_Thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_Thoat.Appearance.Options.UseFont = true;
            this.simpleButton_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Thoat.Image")));
            this.simpleButton_Thoat.Location = new System.Drawing.Point(326, 124);
            this.simpleButton_Thoat.Name = "simpleButton_Thoat";
            this.simpleButton_Thoat.Size = new System.Drawing.Size(121, 42);
            this.simpleButton_Thoat.TabIndex = 6;
            this.simpleButton_Thoat.Text = "Thoát";
            this.simpleButton_Thoat.Click += new System.EventHandler(this.simpleButton_Thoat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 247);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
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
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}