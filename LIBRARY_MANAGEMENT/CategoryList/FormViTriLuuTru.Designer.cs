namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormViTriLuuTru
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
            this.listBoxControl_VTLT = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl_VTLT = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_VTLT = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup_VTLT = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_VTLT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_VTLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_VTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_VTLT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_VTLT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(270, 355);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton_VTLT);
            this.panelControl2.Controls.Add(this.radioGroup_VTLT);
            this.panelControl2.Controls.Add(this.textEdit_VTLT);
            this.panelControl2.Controls.Add(this.labelControl_VTLT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(270, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(442, 355);
            this.panelControl2.TabIndex = 1;
            // 
            // listBoxControl_VTLT
            // 
            this.listBoxControl_VTLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_VTLT.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_VTLT.Name = "listBoxControl_VTLT";
            this.listBoxControl_VTLT.Size = new System.Drawing.Size(266, 351);
            this.listBoxControl_VTLT.TabIndex = 0;
            this.listBoxControl_VTLT.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_VTLT_SelectedIndexChanged);
            // 
            // labelControl_VTLT
            // 
            this.labelControl_VTLT.Location = new System.Drawing.Point(22, 110);
            this.labelControl_VTLT.Name = "labelControl_VTLT";
            this.labelControl_VTLT.Size = new System.Drawing.Size(71, 13);
            this.labelControl_VTLT.TabIndex = 0;
            this.labelControl_VTLT.Text = "Vị Trí Lưu Trữ :";
            // 
            // textEdit_VTLT
            // 
            this.textEdit_VTLT.Location = new System.Drawing.Point(113, 103);
            this.textEdit_VTLT.Name = "textEdit_VTLT";
            this.textEdit_VTLT.Size = new System.Drawing.Size(294, 20);
            this.textEdit_VTLT.TabIndex = 1;
            // 
            // radioGroup_VTLT
            // 
            this.radioGroup_VTLT.EditValue = "Update";
            this.radioGroup_VTLT.Location = new System.Drawing.Point(244, 233);
            this.radioGroup_VTLT.Name = "radioGroup_VTLT";
            this.radioGroup_VTLT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_VTLT.Size = new System.Drawing.Size(163, 96);
            this.radioGroup_VTLT.TabIndex = 2;
            // 
            // simpleButton_VTLT
            // 
            this.simpleButton_VTLT.Location = new System.Drawing.Point(314, 166);
            this.simpleButton_VTLT.Name = "simpleButton_VTLT";
            this.simpleButton_VTLT.Size = new System.Drawing.Size(93, 48);
            this.simpleButton_VTLT.TabIndex = 3;
            this.simpleButton_VTLT.Text = "Cập nhật";
            this.simpleButton_VTLT.Click += new System.EventHandler(this.simpleButton_VTLT_Click);
            // 
            // FormViTriLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 355);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormViTriLuuTru";
            this.Text = "FormViTriLuuTru";
            this.Load += new System.EventHandler(this.FormViTriLuuTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_VTLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_VTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_VTLT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_VTLT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_VTLT;
        private DevExpress.XtraEditors.RadioGroup radioGroup_VTLT;
        private DevExpress.XtraEditors.TextEdit textEdit_VTLT;
        private DevExpress.XtraEditors.LabelControl labelControl_VTLT;
    }
}