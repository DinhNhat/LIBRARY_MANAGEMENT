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
            this.lookUpEdit_TenLop = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl_ChiTietPhieuSD = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup_GioiTinh = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit_MaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit_NamSinh = new DevExpress.XtraEditors.DateEdit();
            this.textEdit_SoDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_HoTen = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl_ThucHienPhieu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_PhieuSD = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_PhieuSD = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PhieuSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChiTietPhieuSD)).BeginInit();
            this.groupControl_ChiTietPhieuSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_GioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThucHienPhieu)).BeginInit();
            this.groupControl_ThucHienPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_PhieuSD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView_PhieuSD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(755, 550);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_PhieuSD
            // 
            this.dataGridView_PhieuSD.AllowUserToAddRows = false;
            this.dataGridView_PhieuSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView_PhieuSD.Size = new System.Drawing.Size(751, 546);
            this.dataGridView_PhieuSD.TabIndex = 0;
            this.dataGridView_PhieuSD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PhieuSD_RowEnter);
            // 
            // colMaPhieuSD
            // 
            this.colMaPhieuSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPhieuSD.DataPropertyName = "maPhieuSD";
            this.colMaPhieuSD.HeaderText = "Mã Phiếu Sử Dụng";
            this.colMaPhieuSD.Name = "colMaPhieuSD";
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "hoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colNgayThangNamSinh
            // 
            this.colNgayThangNamSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayThangNamSinh.DataPropertyName = "ngayThangNamSinh";
            this.colNgayThangNamSinh.HeaderText = "Ngày Tháng Năm Sinh";
            this.colNgayThangNamSinh.Name = "colNgayThangNamSinh";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "gioiTinh";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colSoDT
            // 
            this.colSoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoDT.DataPropertyName = "soDT";
            this.colSoDT.HeaderText = "Số Điện Thoại";
            this.colSoDT.Name = "colSoDT";
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLop.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colTenLop.HeaderText = "Tên Lớp";
            this.colTenLop.Name = "colTenLop";
            // 
            // lookUpEdit_TenLop
            // 
            this.lookUpEdit_TenLop.Location = new System.Drawing.Point(194, 319);
            this.lookUpEdit_TenLop.Name = "lookUpEdit_TenLop";
            this.lookUpEdit_TenLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_TenLop.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_TenLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenLop", "Tên lớp")});
            this.lookUpEdit_TenLop.Properties.DisplayMember = "tenLop";
            this.lookUpEdit_TenLop.Properties.ValueMember = "maLop";
            this.lookUpEdit_TenLop.Size = new System.Drawing.Size(197, 22);
            this.lookUpEdit_TenLop.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(49, 322);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Tên lớp :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl_ChiTietPhieuSD);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(755, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(485, 361);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl_ChiTietPhieuSD
            // 
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.radioGroup_GioiTinh);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.lookUpEdit_TenLop);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.textEdit_MaPhieu);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.dateEdit_NamSinh);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.textEdit_SoDT);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl5);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.textEdit_HoTen);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl6);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.textEdit_Email);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl7);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl4);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl1);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl3);
            this.groupControl_ChiTietPhieuSD.Controls.Add(this.labelControl2);
            this.groupControl_ChiTietPhieuSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_ChiTietPhieuSD.Location = new System.Drawing.Point(2, 2);
            this.groupControl_ChiTietPhieuSD.Name = "groupControl_ChiTietPhieuSD";
            this.groupControl_ChiTietPhieuSD.Size = new System.Drawing.Size(481, 357);
            this.groupControl_ChiTietPhieuSD.TabIndex = 0;
            this.groupControl_ChiTietPhieuSD.Text = "THÔNG TIN CHI TIẾT PHIÊU SỬ DỤNG SÁCH";
            // 
            // radioGroup_GioiTinh
            // 
            this.radioGroup_GioiTinh.EditValue = true;
            this.radioGroup_GioiTinh.Location = new System.Drawing.Point(194, 167);
            this.radioGroup_GioiTinh.Name = "radioGroup_GioiTinh";
            this.radioGroup_GioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_GioiTinh.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_GioiTinh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nữ")});
            this.radioGroup_GioiTinh.Size = new System.Drawing.Size(129, 35);
            this.radioGroup_GioiTinh.TabIndex = 13;
            // 
            // textEdit_MaPhieu
            // 
            this.textEdit_MaPhieu.Location = new System.Drawing.Point(194, 32);
            this.textEdit_MaPhieu.Name = "textEdit_MaPhieu";
            this.textEdit_MaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_MaPhieu.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MaPhieu.Size = new System.Drawing.Size(197, 22);
            this.textEdit_MaPhieu.TabIndex = 12;
            // 
            // dateEdit_NamSinh
            // 
            this.dateEdit_NamSinh.EditValue = null;
            this.dateEdit_NamSinh.Location = new System.Drawing.Point(194, 125);
            this.dateEdit_NamSinh.Name = "dateEdit_NamSinh";
            this.dateEdit_NamSinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NamSinh.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NamSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NamSinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NamSinh.Size = new System.Drawing.Size(197, 22);
            this.dateEdit_NamSinh.TabIndex = 10;
            // 
            // textEdit_SoDT
            // 
            this.textEdit_SoDT.Location = new System.Drawing.Point(194, 271);
            this.textEdit_SoDT.Name = "textEdit_SoDT";
            this.textEdit_SoDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_SoDT.Properties.Appearance.Options.UseFont = true;
            this.textEdit_SoDT.Size = new System.Drawing.Size(197, 22);
            this.textEdit_SoDT.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(49, 274);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Số điện thoại :";
            // 
            // textEdit_HoTen
            // 
            this.textEdit_HoTen.Location = new System.Drawing.Point(194, 76);
            this.textEdit_HoTen.Name = "textEdit_HoTen";
            this.textEdit_HoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_HoTen.Properties.Appearance.Options.UseFont = true;
            this.textEdit_HoTen.Size = new System.Drawing.Size(197, 22);
            this.textEdit_HoTen.TabIndex = 1;
            // 
            // textEdit_Email
            // 
            this.textEdit_Email.Location = new System.Drawing.Point(194, 221);
            this.textEdit_Email.Name = "textEdit_Email";
            this.textEdit_Email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_Email.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Email.Size = new System.Drawing.Size(197, 22);
            this.textEdit_Email.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(49, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 16);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Mã phiếu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(49, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Email :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(49, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(49, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Giới tính :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(49, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(129, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ngày tháng năm sinh :";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl_ThucHienPhieu);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(755, 361);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(485, 189);
            this.panelControl4.TabIndex = 3;
            // 
            // groupControl_ThucHienPhieu
            // 
            this.groupControl_ThucHienPhieu.Controls.Add(this.simpleButton_PhieuSD);
            this.groupControl_ThucHienPhieu.Controls.Add(this.radioGroup_PhieuSD);
            this.groupControl_ThucHienPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_ThucHienPhieu.Location = new System.Drawing.Point(2, 2);
            this.groupControl_ThucHienPhieu.Name = "groupControl_ThucHienPhieu";
            this.groupControl_ThucHienPhieu.Size = new System.Drawing.Size(481, 185);
            this.groupControl_ThucHienPhieu.TabIndex = 0;
            this.groupControl_ThucHienPhieu.Text = "LỰA CHỌN VIỆC THỰC HIỆN";
            // 
            // simpleButton_PhieuSD
            // 
            this.simpleButton_PhieuSD.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_PhieuSD.Appearance.Options.UseFont = true;
            this.simpleButton_PhieuSD.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            this.simpleButton_PhieuSD.Location = new System.Drawing.Point(38, 91);
            this.simpleButton_PhieuSD.Name = "simpleButton_PhieuSD";
            this.simpleButton_PhieuSD.Size = new System.Drawing.Size(182, 67);
            this.simpleButton_PhieuSD.TabIndex = 1;
            this.simpleButton_PhieuSD.Text = "Thêm phiếu sử dụng";
            this.simpleButton_PhieuSD.Click += new System.EventHandler(this.simpleButton_PhieuSD_Click);
            // 
            // radioGroup_PhieuSD
            // 
            this.radioGroup_PhieuSD.EditValue = "Add";
            this.radioGroup_PhieuSD.Location = new System.Drawing.Point(245, 50);
            this.radioGroup_PhieuSD.Name = "radioGroup_PhieuSD";
            this.radioGroup_PhieuSD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_PhieuSD.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_PhieuSD.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm phiếu sử dụng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa thông tin phiếu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa phiếu sử dụng")});
            this.radioGroup_PhieuSD.Size = new System.Drawing.Size(205, 108);
            this.radioGroup_PhieuSD.TabIndex = 0;
            this.radioGroup_PhieuSD.SelectedIndexChanged += new System.EventHandler(this.radioGroup_PhieuSD_SelectedIndexChanged);
            // 
            // FormPhieuSuDungSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 550);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormPhieuSuDungSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuSuDungSach";
            this.Load += new System.EventHandler(this.FormPhieuSuDungSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PhieuSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChiTietPhieuSD)).EndInit();
            this.groupControl_ChiTietPhieuSD.ResumeLayout(false);
            this.groupControl_ChiTietPhieuSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_GioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThucHienPhieu)).EndInit();
            this.groupControl_ThucHienPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_PhieuSD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView_PhieuSD;
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
        private DevExpress.XtraEditors.GroupControl groupControl_ChiTietPhieuSD;
        private DevExpress.XtraEditors.GroupControl groupControl_ThucHienPhieu;
    }
}