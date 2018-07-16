namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView_ThongKeSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton_ThongKeSachKhongMuon = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_ThongKeSachMuon = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit_NgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_NgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_ThongKeSachDangMuon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKeSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.dataGridView_ThongKeSach);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1329, 529);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_ThongKeSach
            // 
            this.dataGridView_ThongKeSach.AllowUserToAddRows = false;
            this.dataGridView_ThongKeSach.AllowUserToResizeRows = false;
            this.dataGridView_ThongKeSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThongKeSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTenLoaiSach,
            this.colSoLuong,
            this.colSoLuongMat,
            this.colTongSoTienPhat,
            this.colSoLuotMuon,
            this.colNamXB,
            this.colTenTacGia});
            this.dataGridView_ThongKeSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ThongKeSach.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_ThongKeSach.Name = "dataGridView_ThongKeSach";
            this.dataGridView_ThongKeSach.RowHeadersVisible = false;
            this.dataGridView_ThongKeSach.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView_ThongKeSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_ThongKeSach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Salmon;
            this.dataGridView_ThongKeSach.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_ThongKeSach.RowTemplate.ReadOnly = true;
            this.dataGridView_ThongKeSach.Size = new System.Drawing.Size(1325, 525);
            this.dataGridView_ThongKeSach.TabIndex = 0;
            // 
            // colMaSach
            // 
            this.colMaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaSach.DataPropertyName = "maSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Width = 66;
            // 
            // colTenSach
            // 
            this.colTenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSach.DataPropertyName = "tenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            // 
            // colTenLoaiSach
            // 
            this.colTenLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiSach.DataPropertyName = "tenLoaiSach";
            this.colTenLoaiSach.HeaderText = "Tên loại sách";
            this.colTenLoaiSach.Name = "colTenLoaiSach";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuong.DataPropertyName = "soLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 69;
            // 
            // colSoLuongMat
            // 
            this.colSoLuongMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuongMat.DataPropertyName = "soLuongMat";
            this.colSoLuongMat.HeaderText = "Số lượng mất";
            this.colSoLuongMat.Name = "colSoLuongMat";
            this.colSoLuongMat.Width = 87;
            // 
            // colTongSoTienPhat
            // 
            this.colTongSoTienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTongSoTienPhat.DataPropertyName = "soTienPhat";
            this.colTongSoTienPhat.HeaderText = "Tổng số tiền phạt";
            this.colTongSoTienPhat.Name = "colTongSoTienPhat";
            this.colTongSoTienPhat.Width = 87;
            // 
            // colSoLuotMuon
            // 
            this.colSoLuotMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuotMuon.DataPropertyName = "soLuotMuon";
            this.colSoLuotMuon.HeaderText = "Số lượt mượn";
            this.colSoLuotMuon.Name = "colSoLuotMuon";
            this.colSoLuotMuon.Width = 88;
            // 
            // colNamXB
            // 
            this.colNamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNamXB.DataPropertyName = "namXB";
            this.colNamXB.HeaderText = "Năm xuất bản";
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Width = 75;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTacGia.DataPropertyName = "tenTacGia";
            this.colTenTacGia.HeaderText = "Tên tác giả";
            this.colTenTacGia.Name = "colTenTacGia";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton_ThongKeSachKhongMuon);
            this.panelControl2.Controls.Add(this.simpleButton_ThongKeSachMuon);
            this.panelControl2.Controls.Add(this.dateEdit_NgayKetThuc);
            this.panelControl2.Controls.Add(this.dateEdit_NgayBatDau);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.simpleButton_ThongKeSachDangMuon);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 529);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1329, 188);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton_ThongKeSachKhongMuon
            // 
            this.simpleButton_ThongKeSachKhongMuon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_ThongKeSachKhongMuon.Appearance.Options.UseFont = true;
            this.simpleButton_ThongKeSachKhongMuon.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ThongKeSachKhongMuon.Image")));
            this.simpleButton_ThongKeSachKhongMuon.Location = new System.Drawing.Point(783, 120);
            this.simpleButton_ThongKeSachKhongMuon.Name = "simpleButton_ThongKeSachKhongMuon";
            this.simpleButton_ThongKeSachKhongMuon.Size = new System.Drawing.Size(237, 43);
            this.simpleButton_ThongKeSachKhongMuon.TabIndex = 7;
            this.simpleButton_ThongKeSachKhongMuon.Text = "Thống kê sách không mượn";
            this.simpleButton_ThongKeSachKhongMuon.Click += new System.EventHandler(this.simpleButton_ThongKeSachKhongMuon_Click);
            // 
            // simpleButton_ThongKeSachMuon
            // 
            this.simpleButton_ThongKeSachMuon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_ThongKeSachMuon.Appearance.Options.UseFont = true;
            this.simpleButton_ThongKeSachMuon.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ThongKeSachMuon.Image")));
            this.simpleButton_ThongKeSachMuon.Location = new System.Drawing.Point(438, 120);
            this.simpleButton_ThongKeSachMuon.Name = "simpleButton_ThongKeSachMuon";
            this.simpleButton_ThongKeSachMuon.Size = new System.Drawing.Size(237, 43);
            this.simpleButton_ThongKeSachMuon.TabIndex = 6;
            this.simpleButton_ThongKeSachMuon.Text = "Thống kê sách mượn";
            this.simpleButton_ThongKeSachMuon.Click += new System.EventHandler(this.simpleButton_ThongKeSachMuon_Click);
            // 
            // dateEdit_NgayKetThuc
            // 
            this.dateEdit_NgayKetThuc.EditValue = null;
            this.dateEdit_NgayKetThuc.Location = new System.Drawing.Point(438, 73);
            this.dateEdit_NgayKetThuc.Name = "dateEdit_NgayKetThuc";
            this.dateEdit_NgayKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NgayKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayKetThuc.Size = new System.Drawing.Size(300, 22);
            this.dateEdit_NgayKetThuc.TabIndex = 5;
            // 
            // dateEdit_NgayBatDau
            // 
            this.dateEdit_NgayBatDau.EditValue = null;
            this.dateEdit_NgayBatDau.Location = new System.Drawing.Point(438, 24);
            this.dateEdit_NgayBatDau.Name = "dateEdit_NgayBatDau";
            this.dateEdit_NgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NgayBatDau.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayBatDau.Size = new System.Drawing.Size(300, 22);
            this.dateEdit_NgayBatDau.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(323, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày kết thúc :";
            // 
            // simpleButton_ThongKeSachDangMuon
            // 
            this.simpleButton_ThongKeSachDangMuon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_ThongKeSachDangMuon.Appearance.Options.UseFont = true;
            this.simpleButton_ThongKeSachDangMuon.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ThongKeSachDangMuon.Image")));
            this.simpleButton_ThongKeSachDangMuon.Location = new System.Drawing.Point(98, 120);
            this.simpleButton_ThongKeSachDangMuon.Name = "simpleButton_ThongKeSachDangMuon";
            this.simpleButton_ThongKeSachDangMuon.Size = new System.Drawing.Size(237, 43);
            this.simpleButton_ThongKeSachDangMuon.TabIndex = 2;
            this.simpleButton_ThongKeSachDangMuon.Text = "Thống kê sách đang mượn";
            this.simpleButton_ThongKeSachDangMuon.Click += new System.EventHandler(this.simpleButton_ThongKeSachDangMuon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(323, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày bắt đầu :";
            // 
            // FormThongKe
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 717);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKeSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayBatDau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dataGridView_ThongKeSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ThongKeSachDangMuon;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ThongKeSachKhongMuon;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ThongKeSachMuon;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayKetThuc;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoTienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTacGia;
    }
}