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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MaLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_LoaiSach = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_LoaiSach = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenLoaiSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lookUpEdit_TenVTLT = new DevExpress.XtraEditors.LookUpEdit();
            this.colMaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVTLT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_LoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenVTLT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(339, 441);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lookUpEdit_TenVTLT);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(339, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(609, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.textEdit_TenLoaiSach);
            this.panelControl3.Controls.Add(this.simpleButton_LoaiSach);
            this.panelControl3.Controls.Add(this.textEdit_MaLoaiSach);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(339, 100);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(609, 182);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.radioGroup_LoaiSach);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(339, 282);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(609, 159);
            this.panelControl4.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã loại sách :";
            // 
            // textEdit_MaLoaiSach
            // 
            this.textEdit_MaLoaiSach.Location = new System.Drawing.Point(170, 20);
            this.textEdit_MaLoaiSach.Name = "textEdit_MaLoaiSach";
            this.textEdit_MaLoaiSach.Size = new System.Drawing.Size(410, 20);
            this.textEdit_MaLoaiSach.TabIndex = 1;
            // 
            // simpleButton_LoaiSach
            // 
            this.simpleButton_LoaiSach.Location = new System.Drawing.Point(453, 120);
            this.simpleButton_LoaiSach.Name = "simpleButton_LoaiSach";
            this.simpleButton_LoaiSach.Size = new System.Drawing.Size(127, 43);
            this.simpleButton_LoaiSach.TabIndex = 2;
            this.simpleButton_LoaiSach.Text = "Cập nhật";
            this.simpleButton_LoaiSach.Click += new System.EventHandler(this.simpleButton_LoaiSach_Click);
            // 
            // radioGroup_LoaiSach
            // 
            this.radioGroup_LoaiSach.EditValue = "Update";
            this.radioGroup_LoaiSach.Location = new System.Drawing.Point(347, 25);
            this.radioGroup_LoaiSach.Name = "radioGroup_LoaiSach";
            this.radioGroup_LoaiSach.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_LoaiSach.Size = new System.Drawing.Size(233, 96);
            this.radioGroup_LoaiSach.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(207, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên vị trí lưu trữ :";
            // 
            // textEdit_TenLoaiSach
            // 
            this.textEdit_TenLoaiSach.Location = new System.Drawing.Point(170, 62);
            this.textEdit_TenLoaiSach.Name = "textEdit_TenLoaiSach";
            this.textEdit_TenLoaiSach.Size = new System.Drawing.Size(410, 20);
            this.textEdit_TenLoaiSach.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên loại sách :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiSach,
            this.colTenLoaiSach,
            this.colVTLT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // lookUpEdit_TenVTLT
            // 
            this.lookUpEdit_TenVTLT.Location = new System.Drawing.Point(311, 25);
            this.lookUpEdit_TenVTLT.Name = "lookUpEdit_TenVTLT";
            this.lookUpEdit_TenVTLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenVTLT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenViTriLuuTru", "Tên Vị trí lưu trữ")});
            this.lookUpEdit_TenVTLT.Properties.DisplayMember = "tenViTriLuuTru";
            this.lookUpEdit_TenVTLT.Properties.ValueMember = "maViTriLuuTru";
            this.lookUpEdit_TenVTLT.Size = new System.Drawing.Size(269, 20);
            this.lookUpEdit_TenVTLT.TabIndex = 4;
            // 
            // colMaLoaiSach
            // 
            this.colMaLoaiSach.DataPropertyName = "maLoaiSach";
            this.colMaLoaiSach.HeaderText = "Mã loại sách";
            this.colMaLoaiSach.Name = "colMaLoaiSach";
            this.colMaLoaiSach.ReadOnly = true;
            // 
            // colTenLoaiSach
            // 
            this.colTenLoaiSach.DataPropertyName = "tenLoaiSach";
            this.colTenLoaiSach.HeaderText = "Tên loại sách";
            this.colTenLoaiSach.Name = "colTenLoaiSach";
            this.colTenLoaiSach.ReadOnly = true;
            // 
            // colVTLT
            // 
            this.colVTLT.HeaderText = "Vị trí lưu trữ";
            this.colVTLT.Name = "colVTLT";
            // 
            // FormLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 441);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormLoaiSach";
            this.Text = "FormLoaiSach";
            this.Load += new System.EventHandler(this.FormLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_LoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenVTLT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVTLT;
    }
}