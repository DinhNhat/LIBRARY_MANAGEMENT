namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormNamHoc
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
            this.listBoxControl_NamHoc = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_NamHoc = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup_NamHoc = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_NamHoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_NamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NamHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_NamHoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(244, 374);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton_NamHoc);
            this.panelControl2.Controls.Add(this.radioGroup_NamHoc);
            this.panelControl2.Controls.Add(this.textEdit_NamHoc);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(244, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(462, 374);
            this.panelControl2.TabIndex = 1;
            // 
            // listBoxControl_NamHoc
            // 
            this.listBoxControl_NamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_NamHoc.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_NamHoc.Name = "listBoxControl_NamHoc";
            this.listBoxControl_NamHoc.Size = new System.Drawing.Size(240, 370);
            this.listBoxControl_NamHoc.TabIndex = 0;
            this.listBoxControl_NamHoc.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_NamHoc_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm học :";
            // 
            // textEdit_NamHoc
            // 
            this.textEdit_NamHoc.Location = new System.Drawing.Point(133, 92);
            this.textEdit_NamHoc.Name = "textEdit_NamHoc";
            this.textEdit_NamHoc.Size = new System.Drawing.Size(301, 20);
            this.textEdit_NamHoc.TabIndex = 1;
            // 
            // radioGroup_NamHoc
            // 
            this.radioGroup_NamHoc.EditValue = "Update";
            this.radioGroup_NamHoc.Location = new System.Drawing.Point(244, 239);
            this.radioGroup_NamHoc.Name = "radioGroup_NamHoc";
            this.radioGroup_NamHoc.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_NamHoc.Size = new System.Drawing.Size(190, 100);
            this.radioGroup_NamHoc.TabIndex = 2;
            // 
            // simpleButton_NamHoc
            // 
            this.simpleButton_NamHoc.Location = new System.Drawing.Point(320, 158);
            this.simpleButton_NamHoc.Name = "simpleButton_NamHoc";
            this.simpleButton_NamHoc.Size = new System.Drawing.Size(114, 47);
            this.simpleButton_NamHoc.TabIndex = 3;
            this.simpleButton_NamHoc.Text = "Cập nhật";
            this.simpleButton_NamHoc.Click += new System.EventHandler(this.simpleButton_NamHoc_Click);
            // 
            // FormNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 374);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormNamHoc";
            this.Text = "FormNamHoc";
            this.Load += new System.EventHandler(this.FormNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_NamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NamHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_NamHoc;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_NamHoc;
        private DevExpress.XtraEditors.RadioGroup radioGroup_NamHoc;
        private DevExpress.XtraEditors.TextEdit textEdit_NamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}