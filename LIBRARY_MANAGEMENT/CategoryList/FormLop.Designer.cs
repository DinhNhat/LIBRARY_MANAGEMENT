namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormLop
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
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_Lop = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_Lop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit_TenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEdit_TenNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_Lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNamHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView_Lop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 304);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.AllowUserToAddRows = false;
            this.dataGridView_Lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenLop,
            this.colNamHoc});
            this.dataGridView_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lop.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.Size = new System.Drawing.Size(439, 300);
            this.dataGridView_Lop.TabIndex = 0;
            this.dataGridView_Lop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_RowEnter);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(443, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(414, 304);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.radioGroup_Lop);
            this.panelControl5.Controls.Add(this.simpleButton_Lop);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 139);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(410, 163);
            this.panelControl5.TabIndex = 2;
            // 
            // radioGroup_Lop
            // 
            this.radioGroup_Lop.EditValue = "Add";
            this.radioGroup_Lop.Location = new System.Drawing.Point(214, 34);
            this.radioGroup_Lop.Name = "radioGroup_Lop";
            this.radioGroup_Lop.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_Lop.Size = new System.Drawing.Size(126, 79);
            this.radioGroup_Lop.TabIndex = 1;
            this.radioGroup_Lop.SelectedIndexChanged += new System.EventHandler(this.radioGroup_Lop_SelectedIndexChanged);
            // 
            // simpleButton_Lop
            // 
            this.simpleButton_Lop.Location = new System.Drawing.Point(95, 61);
            this.simpleButton_Lop.Name = "simpleButton_Lop";
            this.simpleButton_Lop.Size = new System.Drawing.Size(99, 52);
            this.simpleButton_Lop.TabIndex = 0;
            this.simpleButton_Lop.Text = "Cập nhật";
            this.simpleButton_Lop.Click += new System.EventHandler(this.simpleButton_Lop_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.textEdit_TenLop);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 68);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(410, 71);
            this.panelControl4.TabIndex = 1;
            // 
            // textEdit_TenLop
            // 
            this.textEdit_TenLop.Location = new System.Drawing.Point(95, 21);
            this.textEdit_TenLop.Name = "textEdit_TenLop";
            this.textEdit_TenLop.Size = new System.Drawing.Size(245, 20);
            this.textEdit_TenLop.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên lớp :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lookUpEdit_TenNamHoc);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(410, 66);
            this.panelControl3.TabIndex = 0;
            // 
            // lookUpEdit_TenNamHoc
            // 
            this.lookUpEdit_TenNamHoc.Location = new System.Drawing.Point(95, 29);
            this.lookUpEdit_TenNamHoc.Name = "lookUpEdit_TenNamHoc";
            this.lookUpEdit_TenNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenNamHoc", "Tên năm học")});
            this.lookUpEdit_TenNamHoc.Properties.DisplayMember = "tenNamHoc";
            this.lookUpEdit_TenNamHoc.Properties.ValueMember = "maNamHoc";
            this.lookUpEdit_TenNamHoc.Size = new System.Drawing.Size(209, 20);
            this.lookUpEdit_TenNamHoc.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên năm học :";
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTenLop.DataPropertyName = "tenLop";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Width = 67;
            // 
            // colNamHoc
            // 
            this.colNamHoc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colNamHoc.HeaderText = "Năm học";
            this.colNamHoc.Name = "colNamHoc";
            this.colNamHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 304);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_Lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNamHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.RadioGroup radioGroup_Lop;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Lop;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_TenLop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNamHoc;
    }
}