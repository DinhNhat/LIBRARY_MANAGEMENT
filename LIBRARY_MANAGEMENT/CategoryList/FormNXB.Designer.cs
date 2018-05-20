namespace LIBRARY_MANAGEMENT.CategoryList
{
    partial class FormNXB
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
            this.listBoxControl_NXB = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup_NXB = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton_NXB = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_NXB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_NXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_NXB);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(269, 385);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_NXB
            // 
            this.listBoxControl_NXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_NXB.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_NXB.Name = "listBoxControl_NXB";
            this.listBoxControl_NXB.Size = new System.Drawing.Size(265, 381);
            this.listBoxControl_NXB.TabIndex = 0;
            this.listBoxControl_NXB.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_NXB_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioGroup_NXB);
            this.panelControl2.Controls.Add(this.simpleButton_NXB);
            this.panelControl2.Controls.Add(this.textEdit_NXB);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(269, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 385);
            this.panelControl2.TabIndex = 1;
            // 
            // radioGroup_NXB
            // 
            this.radioGroup_NXB.EditValue = "Update";
            this.radioGroup_NXB.Location = new System.Drawing.Point(265, 253);
            this.radioGroup_NXB.Name = "radioGroup_NXB";
            this.radioGroup_NXB.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa")});
            this.radioGroup_NXB.Size = new System.Drawing.Size(153, 121);
            this.radioGroup_NXB.TabIndex = 3;
            // 
            // simpleButton_NXB
            // 
            this.simpleButton_NXB.Location = new System.Drawing.Point(306, 167);
            this.simpleButton_NXB.Name = "simpleButton_NXB";
            this.simpleButton_NXB.Size = new System.Drawing.Size(112, 44);
            this.simpleButton_NXB.TabIndex = 2;
            this.simpleButton_NXB.Text = "Cập nhật";
            this.simpleButton_NXB.Click += new System.EventHandler(this.simpleButton_NXB_Click);
            // 
            // textEdit_NXB
            // 
            this.textEdit_NXB.Location = new System.Drawing.Point(120, 105);
            this.textEdit_NXB.Name = "textEdit_NXB";
            this.textEdit_NXB.Size = new System.Drawing.Size(298, 20);
            this.textEdit_NXB.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 108);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhà xuất bản :";
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 385);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormNXB";
            this.Text = "FormNXB";
            this.Load += new System.EventHandler(this.FormNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_NXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NXB.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_NXB;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup_NXB;
        private DevExpress.XtraEditors.SimpleButton simpleButton_NXB;
        private DevExpress.XtraEditors.TextEdit textEdit_NXB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}