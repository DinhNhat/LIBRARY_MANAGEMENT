namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormQuanLyNguoiSuDung
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView_QuanLyNguoiSD = new System.Windows.Forms.DataGridView();
            this.colMaNguoiSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.toggleSwitch_Admin = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_TrangThaiHoatDong = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_TenNguoiSD = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_MaNguoiSD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_QuanLyNguoiSD = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_QuanLyUser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyNguoiSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_TrangThaiHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenNguoiSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaNguoiSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_QuanLyNguoiSD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView_QuanLyNguoiSD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(489, 460);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_QuanLyNguoiSD
            // 
            this.dataGridView_QuanLyNguoiSD.AllowUserToAddRows = false;
            this.dataGridView_QuanLyNguoiSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_QuanLyNguoiSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLyNguoiSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNguoiSD,
            this.colTenNguoiSD,
            this.colPassword,
            this.colAdmin,
            this.colTrangThai});
            this.dataGridView_QuanLyNguoiSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_QuanLyNguoiSD.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_QuanLyNguoiSD.Name = "dataGridView_QuanLyNguoiSD";
            this.dataGridView_QuanLyNguoiSD.Size = new System.Drawing.Size(485, 456);
            this.dataGridView_QuanLyNguoiSD.TabIndex = 0;
            this.dataGridView_QuanLyNguoiSD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QuanLyNguoiSD_RowEnter);
            // 
            // colMaNguoiSD
            // 
            this.colMaNguoiSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNguoiSD.DataPropertyName = "maNguoiSD";
            this.colMaNguoiSD.HeaderText = "Mã người sử dụng";
            this.colMaNguoiSD.Name = "colMaNguoiSD";
            this.colMaNguoiSD.Width = 87;
            // 
            // colTenNguoiSD
            // 
            this.colTenNguoiSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTenNguoiSD.DataPropertyName = "tenNguoiSD";
            this.colTenNguoiSD.HeaderText = "Tên người sử dụng";
            this.colTenNguoiSD.Name = "colTenNguoiSD";
            this.colTenNguoiSD.Width = 90;
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPassword.DataPropertyName = "password";
            this.colPassword.HeaderText = "Mật khẩu";
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 70;
            // 
            // colAdmin
            // 
            this.colAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdmin.DataPropertyName = "admin";
            this.colAdmin.HeaderText = "Người quản trị hệ thống";
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.Width = 95;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTrangThai.DataPropertyName = "enable";
            this.colTrangThai.HeaderText = "Trạng thái hoạt động";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.toggleSwitch_Admin);
            this.panelControl2.Controls.Add(this.toggleSwitch_TrangThaiHoatDong);
            this.panelControl2.Controls.Add(this.textEdit_MatKhau);
            this.panelControl2.Controls.Add(this.textEdit_TenNguoiSD);
            this.panelControl2.Controls.Add(this.textEdit_MaNguoiSD);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(489, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(683, 255);
            this.panelControl2.TabIndex = 1;
            // 
            // toggleSwitch_Admin
            // 
            this.toggleSwitch_Admin.Location = new System.Drawing.Point(264, 199);
            this.toggleSwitch_Admin.Name = "toggleSwitch_Admin";
            this.toggleSwitch_Admin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch_Admin.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.toggleSwitch_Admin.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_Admin.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch_Admin.Properties.OffText = "     Sai";
            this.toggleSwitch_Admin.Properties.OnText = "     Đúng";
            this.toggleSwitch_Admin.Size = new System.Drawing.Size(221, 26);
            this.toggleSwitch_Admin.TabIndex = 12;
            // 
            // toggleSwitch_TrangThaiHoatDong
            // 
            this.toggleSwitch_TrangThaiHoatDong.Location = new System.Drawing.Point(264, 151);
            this.toggleSwitch_TrangThaiHoatDong.Name = "toggleSwitch_TrangThaiHoatDong";
            this.toggleSwitch_TrangThaiHoatDong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch_TrangThaiHoatDong.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.toggleSwitch_TrangThaiHoatDong.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_TrangThaiHoatDong.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch_TrangThaiHoatDong.Properties.OffText = "     Vô hiệu hóa";
            this.toggleSwitch_TrangThaiHoatDong.Properties.OnText = "     Hoạt động";
            this.toggleSwitch_TrangThaiHoatDong.Size = new System.Drawing.Size(221, 26);
            this.toggleSwitch_TrangThaiHoatDong.TabIndex = 2;
            // 
            // textEdit_MatKhau
            // 
            this.textEdit_MatKhau.Location = new System.Drawing.Point(264, 103);
            this.textEdit_MatKhau.Name = "textEdit_MatKhau";
            this.textEdit_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MatKhau.Size = new System.Drawing.Size(305, 22);
            this.textEdit_MatKhau.TabIndex = 7;
            // 
            // textEdit_TenNguoiSD
            // 
            this.textEdit_TenNguoiSD.Location = new System.Drawing.Point(264, 63);
            this.textEdit_TenNguoiSD.Name = "textEdit_TenNguoiSD";
            this.textEdit_TenNguoiSD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_TenNguoiSD.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenNguoiSD.Size = new System.Drawing.Size(305, 22);
            this.textEdit_TenNguoiSD.TabIndex = 6;
            // 
            // textEdit_MaNguoiSD
            // 
            this.textEdit_MaNguoiSD.Location = new System.Drawing.Point(264, 18);
            this.textEdit_MaNguoiSD.Name = "textEdit_MaNguoiSD";
            this.textEdit_MaNguoiSD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_MaNguoiSD.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MaNguoiSD.Size = new System.Drawing.Size(305, 22);
            this.textEdit_MaNguoiSD.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(63, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(144, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Người quản trị hệ thống :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(63, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Trạng thái hoạt động :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(63, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(63, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên người sử dụng :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(63, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã người sử dụng :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.radioGroup_QuanLyNguoiSD);
            this.panelControl3.Controls.Add(this.simpleButton_QuanLyUser);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(489, 255);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(683, 205);
            this.panelControl3.TabIndex = 2;
            // 
            // radioGroup_QuanLyNguoiSD
            // 
            this.radioGroup_QuanLyNguoiSD.EditValue = "Add";
            this.radioGroup_QuanLyNguoiSD.Location = new System.Drawing.Point(382, 48);
            this.radioGroup_QuanLyNguoiSD.Name = "radioGroup_QuanLyNguoiSD";
            this.radioGroup_QuanLyNguoiSD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_QuanLyNguoiSD.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_QuanLyNguoiSD.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm người sử dụng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa thông tin người sử dụng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa người sử dụng")});
            this.radioGroup_QuanLyNguoiSD.Size = new System.Drawing.Size(236, 116);
            this.radioGroup_QuanLyNguoiSD.TabIndex = 1;
            this.radioGroup_QuanLyNguoiSD.SelectedIndexChanged += new System.EventHandler(this.radioGroup_QuanLyNguoiSD_SelectedIndexChanged);
            // 
            // simpleButton_QuanLyUser
            // 
            this.simpleButton_QuanLyUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_QuanLyUser.Appearance.Options.UseFont = true;
            this.simpleButton_QuanLyUser.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            this.simpleButton_QuanLyUser.Location = new System.Drawing.Point(80, 96);
            this.simpleButton_QuanLyUser.Name = "simpleButton_QuanLyUser";
            this.simpleButton_QuanLyUser.Size = new System.Drawing.Size(252, 68);
            this.simpleButton_QuanLyUser.TabIndex = 0;
            this.simpleButton_QuanLyUser.Text = "Thêm người sử dụng";
            this.simpleButton_QuanLyUser.Click += new System.EventHandler(this.simpleButton_QuanLyUser_Click);
            // 
            // FormQuanLyNguoiSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 460);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormQuanLyNguoiSuDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyNguoiSuDung";
            this.Load += new System.EventHandler(this.FormQuanLyNguoiSuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyNguoiSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_TrangThaiHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenNguoiSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaNguoiSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_QuanLyNguoiSD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView_QuanLyNguoiSD;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_MatKhau;
        private DevExpress.XtraEditors.TextEdit textEdit_TenNguoiSD;
        private DevExpress.XtraEditors.TextEdit textEdit_MaNguoiSD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.RadioGroup radioGroup_QuanLyNguoiSD;
        private DevExpress.XtraEditors.SimpleButton simpleButton_QuanLyUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Admin;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_TrangThaiHoatDong;
    }
}