namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormPhieuSuDungSach
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
            this.dataGridView_PhieuSD = new System.Windows.Forms.DataGridView();
            this.colMaPhieuSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThangNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEdit_TenLop = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_GioiTinh = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit_MaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_NamSinh = new DevExpress.XtraEditors.DateEdit();
            this.textEdit_SoDT = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_HoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton_PhieuSD = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_PhieuSD = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PhieuSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_GioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_PhieuSD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView_PhieuSD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(755, 569);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_PhieuSD
            // 
            this.dataGridView_PhieuSD.AllowUserToAddRows = false;
            this.dataGridView_PhieuSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuSD,
            this.colHoTen,
            this.colNgayThangNamSinh,
            this.colGioiTinh,
            this.colEmail,
            this.colSoDT,
            this.colTenLop});
            this.dataGridView_PhieuSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_PhieuSD.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_PhieuSD.Name = "dataGridView_PhieuSD";
            this.dataGridView_PhieuSD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_PhieuSD.Size = new System.Drawing.Size(751, 565);
            this.dataGridView_PhieuSD.TabIndex = 0;
            this.dataGridView_PhieuSD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PhieuSD_RowEnter);
            // 
            // colMaPhieuSD
            // 
            this.colMaPhieuSD.DataPropertyName = "maPhieuSD";
            this.colMaPhieuSD.HeaderText = "Mã Phiếu Sử Dụng";
            this.colMaPhieuSD.Name = "colMaPhieuSD";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "hoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 101;
            // 
            // colNgayThangNamSinh
            // 
            this.colNgayThangNamSinh.DataPropertyName = "ngayThangNamSinh";
            this.colNgayThangNamSinh.HeaderText = "Ngày Tháng Năm Sinh";
            this.colNgayThangNamSinh.Name = "colNgayThangNamSinh";
            this.colNgayThangNamSinh.Width = 101;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "gioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 102;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 101;
            // 
            // colSoDT
            // 
            this.colSoDT.DataPropertyName = "soDT";
            this.colSoDT.HeaderText = "Số Điện Thoại";
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Width = 101;
            // 
            // colTenLop
            // 
            this.colTenLop.HeaderText = "Tên Lớp";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Width = 101;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lookUpEdit_TenLop);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(755, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(431, 67);
            this.panelControl2.TabIndex = 1;
            // 
            // lookUpEdit_TenLop
            // 
            this.lookUpEdit_TenLop.Location = new System.Drawing.Point(143, 31);
            this.lookUpEdit_TenLop.Name = "lookUpEdit_TenLop";
            this.lookUpEdit_TenLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenLop", "Tên lớp")});
            this.lookUpEdit_TenLop.Properties.DisplayMember = "tenLop";
            this.lookUpEdit_TenLop.Properties.ValueMember = "maLop";
            this.lookUpEdit_TenLop.Size = new System.Drawing.Size(261, 20);
            this.lookUpEdit_TenLop.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Tên lớp :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.radioGroup_GioiTinh);
            this.panelControl3.Controls.Add(this.textEdit_MaPhieu);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.dateEdit_NamSinh);
            this.panelControl3.Controls.Add(this.textEdit_SoDT);
            this.panelControl3.Controls.Add(this.textEdit_Email);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.textEdit_HoTen);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(755, 67);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(431, 289);
            this.panelControl3.TabIndex = 2;
            // 
            // radioGroup_GioiTinh
            // 
            this.radioGroup_GioiTinh.EditValue = true;
            this.radioGroup_GioiTinh.Location = new System.Drawing.Point(143, 147);
            this.radioGroup_GioiTinh.Name = "radioGroup_GioiTinh";
            this.radioGroup_GioiTinh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nữ")});
            this.radioGroup_GioiTinh.Size = new System.Drawing.Size(129, 35);
            this.radioGroup_GioiTinh.TabIndex = 13;
            // 
            // textEdit_MaPhieu
            // 
            this.textEdit_MaPhieu.Location = new System.Drawing.Point(143, 20);
            this.textEdit_MaPhieu.Name = "textEdit_MaPhieu";
            this.textEdit_MaPhieu.Size = new System.Drawing.Size(129, 20);
            this.textEdit_MaPhieu.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Mã phiếu :";
            // 
            // dateEdit_NamSinh
            // 
            this.dateEdit_NamSinh.EditValue = null;
            this.dateEdit_NamSinh.Location = new System.Drawing.Point(143, 103);
            this.dateEdit_NamSinh.Name = "dateEdit_NamSinh";
            this.dateEdit_NamSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NamSinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NamSinh.Size = new System.Drawing.Size(149, 20);
            this.dateEdit_NamSinh.TabIndex = 10;
            // 
            // textEdit_SoDT
            // 
            this.textEdit_SoDT.Location = new System.Drawing.Point(143, 252);
            this.textEdit_SoDT.Name = "textEdit_SoDT";
            this.textEdit_SoDT.Size = new System.Drawing.Size(221, 20);
            this.textEdit_SoDT.TabIndex = 7;
            // 
            // textEdit_Email
            // 
            this.textEdit_Email.Location = new System.Drawing.Point(143, 208);
            this.textEdit_Email.Name = "textEdit_Email";
            this.textEdit_Email.Size = new System.Drawing.Size(221, 20);
            this.textEdit_Email.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 255);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Số điện thoại :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Email :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Giới tính :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ngày tháng năm sinh :";
            // 
            // textEdit_HoTen
            // 
            this.textEdit_HoTen.Location = new System.Drawing.Point(143, 58);
            this.textEdit_HoTen.Name = "textEdit_HoTen";
            this.textEdit_HoTen.Size = new System.Drawing.Size(265, 20);
            this.textEdit_HoTen.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên :";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.simpleButton_PhieuSD);
            this.panelControl4.Controls.Add(this.radioGroup_PhieuSD);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(755, 356);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(431, 213);
            this.panelControl4.TabIndex = 3;
            // 
            // simpleButton_PhieuSD
            // 
            this.simpleButton_PhieuSD.Location = new System.Drawing.Point(255, 20);
            this.simpleButton_PhieuSD.Name = "simpleButton_PhieuSD";
            this.simpleButton_PhieuSD.Size = new System.Drawing.Size(109, 37);
            this.simpleButton_PhieuSD.TabIndex = 1;
            this.simpleButton_PhieuSD.Text = "Cập nhật";
            this.simpleButton_PhieuSD.Click += new System.EventHandler(this.simpleButton_PhieuSD_Click);
            // 
            // radioGroup_PhieuSD
            // 
            this.radioGroup_PhieuSD.EditValue = "Add";
            this.radioGroup_PhieuSD.Location = new System.Drawing.Point(188, 63);
            this.radioGroup_PhieuSD.Name = "radioGroup_PhieuSD";
            this.radioGroup_PhieuSD.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_PhieuSD.Size = new System.Drawing.Size(176, 94);
            this.radioGroup_PhieuSD.TabIndex = 0;
            this.radioGroup_PhieuSD.SelectedIndexChanged += new System.EventHandler(this.radioGroup_PhieuSD_SelectedIndexChanged);
            // 
            // FormPhieuSuDungSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 569);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormPhieuSuDungSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuSuDungSach";
            this.Load += new System.EventHandler(this.FormPhieuSuDungSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PhieuSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_GioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_PhieuSD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView_PhieuSD;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenLop;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit_NamSinh;
        private DevExpress.XtraEditors.TextEdit textEdit_SoDT;
        private DevExpress.XtraEditors.TextEdit textEdit_Email;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_HoTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton_PhieuSD;
        private DevExpress.XtraEditors.RadioGroup radioGroup_PhieuSD;
        private DevExpress.XtraEditors.TextEdit textEdit_MaPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.RadioGroup radioGroup_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThangNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenLop;
    }
}