namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormKhoSach
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
            this.listBoxControl_KhoSach = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_KhoSach = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_KhoSach = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_KhoSach = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_KhoSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_KhoSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KhoSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_KhoSach);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(249, 300);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_KhoSach
            // 
            this.listBoxControl_KhoSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_KhoSach.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_KhoSach.Name = "listBoxControl_KhoSach";
            this.listBoxControl_KhoSach.Size = new System.Drawing.Size(245, 296);
            this.listBoxControl_KhoSach.TabIndex = 1;
            this.listBoxControl_KhoSach.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_KhoSach_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioGroup_KhoSach);
            this.panelControl2.Controls.Add(this.simpleButton_KhoSach);
            this.panelControl2.Controls.Add(this.textEdit_KhoSach);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(249, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(442, 300);
            this.panelControl2.TabIndex = 1;
            // 
            // radioGroup_KhoSach
            // 
            this.radioGroup_KhoSach.EditValue = "Add";
            this.radioGroup_KhoSach.Location = new System.Drawing.Point(218, 155);
            this.radioGroup_KhoSach.Name = "radioGroup_KhoSach";
            this.radioGroup_KhoSach.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_KhoSach.Size = new System.Drawing.Size(172, 96);
            this.radioGroup_KhoSach.TabIndex = 3;
            this.radioGroup_KhoSach.SelectedIndexChanged += new System.EventHandler(this.radioGroup_KhoSach_SelectedIndexChanged);
            // 
            // simpleButton_KhoSach
            // 
            this.simpleButton_KhoSach.Location = new System.Drawing.Point(263, 99);
            this.simpleButton_KhoSach.Name = "simpleButton_KhoSach";
            this.simpleButton_KhoSach.Size = new System.Drawing.Size(127, 40);
            this.simpleButton_KhoSach.TabIndex = 2;
            this.simpleButton_KhoSach.Text = "Cập nhật";
            this.simpleButton_KhoSach.Click += new System.EventHandler(this.simpleButton_KhoSach_Click);
            // 
            // textEdit_KhoSach
            // 
            this.textEdit_KhoSach.Location = new System.Drawing.Point(89, 50);
            this.textEdit_KhoSach.Name = "textEdit_KhoSach";
            this.textEdit_KhoSach.Size = new System.Drawing.Size(301, 20);
            this.textEdit_KhoSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kho sách :";
            // 
            // FormKhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 300);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormKhoSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhoSach";
            this.Load += new System.EventHandler(this.FormKhoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_KhoSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_KhoSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KhoSach.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_KhoSach;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup_KhoSach;
        private DevExpress.XtraEditors.SimpleButton simpleButton_KhoSach;
        private DevExpress.XtraEditors.TextEdit textEdit_KhoSach;
        private System.Windows.Forms.Label label1;
    }
}