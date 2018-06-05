namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormTacGia
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
            this.listBoxControl_TacGia = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_TacGia = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_TacGia = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_TacGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TacGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_TacGia);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(253, 217);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_TacGia
            // 
            this.listBoxControl_TacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_TacGia.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_TacGia.Name = "listBoxControl_TacGia";
            this.listBoxControl_TacGia.Size = new System.Drawing.Size(249, 213);
            this.listBoxControl_TacGia.TabIndex = 0;
            this.listBoxControl_TacGia.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_TacGia_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioGroup_TacGia);
            this.panelControl2.Controls.Add(this.simpleButton_TacGia);
            this.panelControl2.Controls.Add(this.textEdit_TacGia);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(253, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(393, 217);
            this.panelControl2.TabIndex = 1;
            // 
            // radioGroup_TacGia
            // 
            this.radioGroup_TacGia.EditValue = "Add";
            this.radioGroup_TacGia.Location = new System.Drawing.Point(195, 95);
            this.radioGroup_TacGia.Name = "radioGroup_TacGia";
            this.radioGroup_TacGia.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_TacGia.Size = new System.Drawing.Size(139, 87);
            this.radioGroup_TacGia.TabIndex = 3;
            this.radioGroup_TacGia.SelectedIndexChanged += new System.EventHandler(this.radioGroup_TacGia_SelectedIndexChanged);
            // 
            // simpleButton_TacGia
            // 
            this.simpleButton_TacGia.Location = new System.Drawing.Point(51, 129);
            this.simpleButton_TacGia.Name = "simpleButton_TacGia";
            this.simpleButton_TacGia.Size = new System.Drawing.Size(125, 53);
            this.simpleButton_TacGia.TabIndex = 2;
            this.simpleButton_TacGia.Text = "Cập nhật";
            this.simpleButton_TacGia.Click += new System.EventHandler(this.simpleButton_TacGia_Click);
            // 
            // textEdit_TacGia
            // 
            this.textEdit_TacGia.Location = new System.Drawing.Point(64, 25);
            this.textEdit_TacGia.Name = "textEdit_TacGia";
            this.textEdit_TacGia.Size = new System.Drawing.Size(270, 20);
            this.textEdit_TacGia.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tác Giả :";
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 217);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTacGia";
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TacGia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_TacGia;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup_TacGia;
        private DevExpress.XtraEditors.SimpleButton simpleButton_TacGia;
        private DevExpress.XtraEditors.TextEdit textEdit_TacGia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}