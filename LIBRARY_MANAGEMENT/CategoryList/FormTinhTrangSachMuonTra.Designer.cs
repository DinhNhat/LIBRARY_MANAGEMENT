namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormTinhTrangSachMuonTra
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
            this.listBoxControl_TTSMT = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TTSMT = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup_TTSMT = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_TTSMT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TTSMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TTSMT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TTSMT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_TTSMT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(266, 389);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton_TTSMT);
            this.panelControl2.Controls.Add(this.radioGroup_TTSMT);
            this.panelControl2.Controls.Add(this.textEdit_TTSMT);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(266, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(466, 389);
            this.panelControl2.TabIndex = 1;
            // 
            // listBoxControl_TTSMT
            // 
            this.listBoxControl_TTSMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_TTSMT.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_TTSMT.Name = "listBoxControl_TTSMT";
            this.listBoxControl_TTSMT.Size = new System.Drawing.Size(262, 385);
            this.listBoxControl_TTSMT.TabIndex = 0;
            this.listBoxControl_TTSMT.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_TTSMT_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // textEdit_TTSMT
            // 
            this.textEdit_TTSMT.Location = new System.Drawing.Point(124, 97);
            this.textEdit_TTSMT.Name = "textEdit_TTSMT";
            this.textEdit_TTSMT.Size = new System.Drawing.Size(315, 20);
            this.textEdit_TTSMT.TabIndex = 1;
            // 
            // radioGroup_TTSMT
            // 
            this.radioGroup_TTSMT.EditValue = "Update";
            this.radioGroup_TTSMT.Location = new System.Drawing.Point(241, 233);
            this.radioGroup_TTSMT.Name = "radioGroup_TTSMT";
            this.radioGroup_TTSMT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_TTSMT.Size = new System.Drawing.Size(198, 109);
            this.radioGroup_TTSMT.TabIndex = 2;
            // 
            // simpleButton_TTSMT
            // 
            this.simpleButton_TTSMT.Location = new System.Drawing.Point(339, 163);
            this.simpleButton_TTSMT.Name = "simpleButton_TTSMT";
            this.simpleButton_TTSMT.Size = new System.Drawing.Size(100, 45);
            this.simpleButton_TTSMT.TabIndex = 3;
            this.simpleButton_TTSMT.Text = "Cập nhật";
            this.simpleButton_TTSMT.Click += new System.EventHandler(this.simpleButton_TTSMT_Click);
            // 
            // FormTinhTrangSachMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 389);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTinhTrangSachMuonTra";
            this.Text = "FormTinhTrangSachMuonTra";
            this.Load += new System.EventHandler(this.FormTinhTrangSachMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TTSMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TTSMT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TTSMT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_TTSMT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_TTSMT;
        private DevExpress.XtraEditors.RadioGroup radioGroup_TTSMT;
        private DevExpress.XtraEditors.TextEdit textEdit_TTSMT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}