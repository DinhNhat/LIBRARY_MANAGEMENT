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
            this.listBoxControl_VTLT = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton_VTLT = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_VTLT = new DevExpress.XtraEditors.RadioGroup();
            this.textEdit_VTLT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_VTLT = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_VTLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_VTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_VTLT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl_VTLT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(294, 274);
            this.panelControl1.TabIndex = 0;
            // 
            // listBoxControl_VTLT
            // 
            this.listBoxControl_VTLT.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxControl_VTLT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxControl_VTLT.Appearance.Options.UseBackColor = true;
            this.listBoxControl_VTLT.Appearance.Options.UseFont = true;
            this.listBoxControl_VTLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl_VTLT.Location = new System.Drawing.Point(2, 2);
            this.listBoxControl_VTLT.Name = "listBoxControl_VTLT";
            this.listBoxControl_VTLT.Size = new System.Drawing.Size(290, 270);
            this.listBoxControl_VTLT.TabIndex = 0;
            this.listBoxControl_VTLT.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_VTLT_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton_VTLT);
            this.panelControl2.Controls.Add(this.radioGroup_VTLT);
            this.panelControl2.Controls.Add(this.textEdit_VTLT);
            this.panelControl2.Controls.Add(this.labelControl_VTLT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(294, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(472, 274);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton_VTLT
            // 
            this.simpleButton_VTLT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_VTLT.Appearance.Options.UseFont = true;
            this.simpleButton_VTLT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            this.simpleButton_VTLT.Location = new System.Drawing.Point(36, 165);
            this.simpleButton_VTLT.Name = "simpleButton_VTLT";
            this.simpleButton_VTLT.Size = new System.Drawing.Size(165, 58);
            this.simpleButton_VTLT.TabIndex = 2;
            this.simpleButton_VTLT.Text = "Thêm vị trí lưu trữ";
            this.simpleButton_VTLT.Click += new System.EventHandler(this.simpleButton_VTLT_Click);
            // 
            // radioGroup_VTLT
            // 
            this.radioGroup_VTLT.EditValue = "Add";
            this.radioGroup_VTLT.Location = new System.Drawing.Point(236, 122);
            this.radioGroup_VTLT.Name = "radioGroup_VTLT";
            this.radioGroup_VTLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_VTLT.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_VTLT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Add", "Thêm vị trí lưu trữ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Update", "Sửa tên vị trí lưu trữ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Delete", "Xóa vị trí lưu trữ")});
            this.radioGroup_VTLT.Size = new System.Drawing.Size(195, 101);
            this.radioGroup_VTLT.TabIndex = 2;
            this.radioGroup_VTLT.SelectedIndexChanged += new System.EventHandler(this.radioGroup_VTLT_SelectedIndexChanged);
            // 
            // textEdit_VTLT
            // 
            this.textEdit_VTLT.Location = new System.Drawing.Point(162, 33);
            this.textEdit_VTLT.Name = "textEdit_VTLT";
            this.textEdit_VTLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_VTLT.Properties.Appearance.Options.UseFont = true;
            this.textEdit_VTLT.Size = new System.Drawing.Size(269, 22);
            this.textEdit_VTLT.TabIndex = 1;
            // 
            // labelControl_VTLT
            // 
            this.labelControl_VTLT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_VTLT.Location = new System.Drawing.Point(36, 38);
            this.labelControl_VTLT.Name = "labelControl_VTLT";
            this.labelControl_VTLT.Size = new System.Drawing.Size(90, 16);
            this.labelControl_VTLT.TabIndex = 0;
            this.labelControl_VTLT.Text = "Vị Trí Lưu Trữ :";
            // 
            // FormViTriLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 274);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormViTriLuuTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vị trí lưu trữ";
            this.Load += new System.EventHandler(this.FormViTriLuuTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_VTLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_VTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_VTLT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_VTLT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_VTLT;
        private DevExpress.XtraEditors.TextEdit textEdit_VTLT;
        private DevExpress.XtraEditors.LabelControl labelControl_VTLT;
        private DevExpress.XtraEditors.RadioGroup radioGroup_VTLT;
    }
}