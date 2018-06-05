namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormTrangThai
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
            this.listBoxControl_TrangThai = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_TrangThai = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_TrangThai = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_TrangThai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TrangThai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_TrangThai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(244, 264);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_TrangThai
            // 
            this.listBoxControl_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_TrangThai.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_TrangThai.Name = "listBoxControl_TrangThai";
            this.listBoxControl_TrangThai.Size = new System.Drawing.Size(240, 260);
            this.listBoxControl_TrangThai.TabIndex = 0;
            this.listBoxControl_TrangThai.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_TrangThai_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioGroup_TrangThai);
            this.panelControl2.Controls.Add(this.simpleButton_TrangThai);
            this.panelControl2.Controls.Add(this.textEdit_TrangThai);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(244, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(470, 264);
            this.panelControl2.TabIndex = 1;
            // 
            // radioGroup_TrangThai
            // 
            this.radioGroup_TrangThai.EditValue = "Add";
            this.radioGroup_TrangThai.Location = new System.Drawing.Point(288, 134);
            this.radioGroup_TrangThai.Name = "radioGroup_TrangThai";
            this.radioGroup_TrangThai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_TrangThai.Size = new System.Drawing.Size(139, 85);
            this.radioGroup_TrangThai.TabIndex = 3;
            this.radioGroup_TrangThai.SelectedIndexChanged += new System.EventHandler(this.radioGroup_TrangThai_SelectedIndexChanged);
            // 
            // simpleButton_TrangThai
            // 
            this.simpleButton_TrangThai.Location = new System.Drawing.Point(133, 168);
            this.simpleButton_TrangThai.Name = "simpleButton_TrangThai";
            this.simpleButton_TrangThai.Size = new System.Drawing.Size(125, 51);
            this.simpleButton_TrangThai.TabIndex = 2;
            this.simpleButton_TrangThai.Text = "Cập nhật";
            this.simpleButton_TrangThai.Click += new System.EventHandler(this.simpleButton_TrangThai_Click);
            // 
            // textEdit_TrangThai
            // 
            this.textEdit_TrangThai.Location = new System.Drawing.Point(101, 43);
            this.textEdit_TrangThai.Name = "textEdit_TrangThai";
            this.textEdit_TrangThai.Size = new System.Drawing.Size(326, 20);
            this.textEdit_TrangThai.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên trạng thái :";
            // 
            // FormTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 264);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTrangThai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangThai";
            this.Load += new System.EventHandler(this.FormTrangThai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TrangThai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_TrangThai;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup_TrangThai;
        private DevExpress.XtraEditors.SimpleButton simpleButton_TrangThai;
        private DevExpress.XtraEditors.TextEdit textEdit_TrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}