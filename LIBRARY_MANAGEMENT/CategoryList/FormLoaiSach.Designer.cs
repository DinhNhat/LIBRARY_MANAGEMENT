﻿namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormLoaiSach
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
            this.dataGridView_LoaiSach = new System.Windows.Forms.DataGridView();
            this.colMaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVTLT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lookUpEdit_TenVTLT = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_MaLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_LoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl_ErrorheThong = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup_LoaiSach = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenVTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_LoaiSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView_LoaiSach);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(455, 369);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_LoaiSach
            // 
            this.dataGridView_LoaiSach.AllowUserToAddRows = false;
            this.dataGridView_LoaiSach.AllowUserToResizeRows = false;
            this.dataGridView_LoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiSach,
            this.colTenLoaiSach,
            this.colVTLT});
            this.dataGridView_LoaiSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LoaiSach.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_LoaiSach.Name = "dataGridView_LoaiSach";
            this.dataGridView_LoaiSach.RowHeadersVisible = false;
            this.dataGridView_LoaiSach.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView_LoaiSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_LoaiSach.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Salmon;
            this.dataGridView_LoaiSach.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_LoaiSach.RowTemplate.ReadOnly = true;
            this.dataGridView_LoaiSach.Size = new System.Drawing.Size(451, 365);
            this.dataGridView_LoaiSach.TabIndex = 0;
            this.dataGridView_LoaiSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // colMaLoaiSach
            // 
            this.colMaLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaLoaiSach.DataPropertyName = "maLoaiSach";
            this.colMaLoaiSach.HeaderText = "Mã loại sách";
            this.colMaLoaiSach.Name = "colMaLoaiSach";
            this.colMaLoaiSach.ReadOnly = true;
            this.colMaLoaiSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoaiSach.Width = 90;
            // 
            // colTenLoaiSach
            // 
            this.colTenLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiSach.DataPropertyName = "tenLoaiSach";
            this.colTenLoaiSach.HeaderText = "Tên loại sách";
            this.colTenLoaiSach.Name = "colTenLoaiSach";
            this.colTenLoaiSach.ReadOnly = true;
            // 
            // colVTLT
            // 
            this.colVTLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVTLT.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colVTLT.HeaderText = "Vị trí lưu trữ";
            this.colVTLT.Name = "colVTLT";
            this.colVTLT.ReadOnly = true;
            this.colVTLT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lookUpEdit_TenVTLT
            // 
            this.lookUpEdit_TenVTLT.Location = new System.Drawing.Point(170, 23);
            this.lookUpEdit_TenVTLT.Name = "lookUpEdit_TenVTLT";
            this.lookUpEdit_TenVTLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_TenVTLT.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_TenVTLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenVTLT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenViTriLuuTru", "Tên vị trí lưu trữ")});
            this.lookUpEdit_TenVTLT.Properties.DisplayMember = "tenViTriLuuTru";
            this.lookUpEdit_TenVTLT.Properties.NullText = "Chọn vị trí lưu trữ";
            this.lookUpEdit_TenVTLT.Properties.ValueMember = "maViTriLuuTru";
            this.lookUpEdit_TenVTLT.Size = new System.Drawing.Size(248, 22);
            this.lookUpEdit_TenVTLT.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(41, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên vị trí lưu trữ :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.lookUpEdit_TenVTLT);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.textEdit_TenLoaiSach);
            this.panelControl3.Controls.Add(this.textEdit_MaLoaiSach);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(455, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(472, 170);
            this.panelControl3.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(41, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên loại sách :";
            // 
            // textEdit_TenLoaiSach
            // 
            this.textEdit_TenLoaiSach.Location = new System.Drawing.Point(170, 123);
            this.textEdit_TenLoaiSach.Name = "textEdit_TenLoaiSach";
            this.textEdit_TenLoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_TenLoaiSach.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenLoaiSach.Size = new System.Drawing.Size(248, 22);
            this.textEdit_TenLoaiSach.TabIndex = 2;
            // 
            // textEdit_MaLoaiSach
            // 
            this.textEdit_MaLoaiSach.Location = new System.Drawing.Point(170, 76);
            this.textEdit_MaLoaiSach.Name = "textEdit_MaLoaiSach";
            this.textEdit_MaLoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_MaLoaiSach.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MaLoaiSach.Size = new System.Drawing.Size(194, 22);
            this.textEdit_MaLoaiSach.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(41, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã loại sách :";
            // 
            // simpleButton_LoaiSach
            // 
            this.simpleButton_LoaiSach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_LoaiSach.Appearance.Options.UseFont = true;
            this.simpleButton_LoaiSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            this.simpleButton_LoaiSach.Location = new System.Drawing.Point(41, 79);
            this.simpleButton_LoaiSach.Name = "simpleButton_LoaiSach";
            this.simpleButton_LoaiSach.Size = new System.Drawing.Size(147, 58);
            this.simpleButton_LoaiSach.TabIndex = 3;
            this.simpleButton_LoaiSach.Text = "Thêm loại sách";
            this.simpleButton_LoaiSach.Click += new System.EventHandler(this.simpleButton_LoaiSach_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl_ErrorheThong);
            this.panelControl4.Controls.Add(this.radioGroup_LoaiSach);
            this.panelControl4.Controls.Add(this.simpleButton_LoaiSach);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(455, 170);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(472, 199);
            this.panelControl4.TabIndex = 3;
            // 
            // labelControl_ErrorheThong
            // 
            this.labelControl_ErrorheThong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_ErrorheThong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_ErrorheThong.Location = new System.Drawing.Point(151, 158);
            this.labelControl_ErrorheThong.Name = "labelControl_ErrorheThong";
            this.labelControl_ErrorheThong.Size = new System.Drawing.Size(0, 16);
            this.labelControl_ErrorheThong.TabIndex = 3;
            // 
            // radioGroup_LoaiSach
            // 
            this.radioGroup_LoaiSach.EditValue = "Add";
            this.radioGroup_LoaiSach.Location = new System.Drawing.Point(236, 30);
            this.radioGroup_LoaiSach.Name = "radioGroup_LoaiSach";
            this.radioGroup_LoaiSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_LoaiSach.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_LoaiSach.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm loại sách"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa loại sách"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa loại sách")});
            this.radioGroup_LoaiSach.Size = new System.Drawing.Size(182, 107);
            this.radioGroup_LoaiSach.TabIndex = 0;
            this.radioGroup_LoaiSach.SelectedIndexChanged += new System.EventHandler(this.radioGroup_LoaiSach_SelectedIndexChanged);
            // 
            // FormLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 369);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sách";
            this.Load += new System.EventHandler(this.FormLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenVTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_LoaiSach.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView_LoaiSach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_TenLoaiSach;
        private DevExpress.XtraEditors.SimpleButton simpleButton_LoaiSach;
        private DevExpress.XtraEditors.TextEdit textEdit_MaLoaiSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.RadioGroup radioGroup_LoaiSach;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenVTLT;
        private DevExpress.XtraEditors.LabelControl labelControl_ErrorheThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVTLT;
    }
}