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
            this.listBoxControl_TTSMT = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton_TTSMT = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_TTSMT = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit_TTSMT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TTSMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TTSMT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TTSMT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_TTSMT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(266, 268);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_TTSMT
            // 
            this.listBoxControl_TTSMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_TTSMT.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_TTSMT.Name = "listBoxControl_TTSMT";
            this.listBoxControl_TTSMT.Size = new System.Drawing.Size(262, 264);
            this.listBoxControl_TTSMT.TabIndex = 0;
            this.listBoxControl_TTSMT.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_TTSMT_SelectedIndexChanged);
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
            this.panelControl2.Size = new System.Drawing.Size(476, 268);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton_TTSMT
            // 
            this.simpleButton_TTSMT.Location = new System.Drawing.Point(300, 83);
            this.simpleButton_TTSMT.Name = "simpleButton_TTSMT";
            this.simpleButton_TTSMT.Size = new System.Drawing.Size(118, 45);
            this.simpleButton_TTSMT.TabIndex = 3;
            this.simpleButton_TTSMT.Text = "Cập nhật";
            this.simpleButton_TTSMT.Click += new System.EventHandler(this.simpleButton_TTSMT_Click);
            // 
            // radioGroup_TTSMT
            // 
            this.radioGroup_TTSMT.EditValue = "Add";
            this.radioGroup_TTSMT.Location = new System.Drawing.Point(242, 134);
            this.radioGroup_TTSMT.Name = "radioGroup_TTSMT";
            this.radioGroup_TTSMT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_TTSMT.Size = new System.Drawing.Size(176, 85);
            this.radioGroup_TTSMT.TabIndex = 2;
            this.radioGroup_TTSMT.SelectedIndexChanged += new System.EventHandler(this.radioGroup_TTSMT_SelectedIndexChanged);
            // 
            // textEdit_TTSMT
            // 
            this.textEdit_TTSMT.Location = new System.Drawing.Point(151, 38);
            this.textEdit_TTSMT.Name = "textEdit_TTSMT";
            this.textEdit_TTSMT.Size = new System.Drawing.Size(267, 20);
            this.textEdit_TTSMT.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tình trạng sách mượn trả :";
            // 
            // FormTinhTrangSachMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 268);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormTinhTrangSachMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTinhTrangSachMuonTra";
            this.Load += new System.EventHandler(this.FormTinhTrangSachMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_TTSMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_TTSMT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TTSMT.Properties)).EndInit();
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