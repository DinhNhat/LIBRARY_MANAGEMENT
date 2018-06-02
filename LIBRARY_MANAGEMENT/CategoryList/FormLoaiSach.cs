using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View;
using Presenter.Presenters;
using Presenter;

namespace LIBRARY_MANAGEMENT.CategoryList
{
    public partial class FormLoaiSach : DevExpress.XtraEditors.XtraForm, IViewEntity<LoaiSach>, IViewListEntity<ViTriLuuTru>
    {
        PreLoaiSach preLoaiSach = new PreLoaiSach();
        PreViTriLuuTru preVTLT = new PreViTriLuuTru();
        string maLoaiSach;
        int rowIndex;

        public FormLoaiSach()
        {
            InitializeComponent();
            preLoaiSach.View = this;
            preVTLT.ViewLs = this;
        }

        void IViewEntity<LoaiSach>.viewEntity(LoaiSach ls)
        {
            maLoaiSach = ls.maLoaiSach;
            textEdit_MaLoaiSach.Text = ls.maLoaiSach;
            textEdit_TenLoaiSach.Text = ls.tenLoaiSach;
            lookUpEdit_TenVTLT.EditValue = ls.maViTriLuuTru;
        }

        public LoaiSach AddNewEntity()
        {
            LoaiSach ls = new LoaiSach();
            //ls.maLoaiSach = preLoaiSach.LastKey + 1.ToString();
            ls.maLoaiSach = textEdit_MaLoaiSach.Text;
            ls.tenLoaiSach = textEdit_TenLoaiSach.Text;
            if(lookUpEdit_TenVTLT.EditValue != null)
                ls.maViTriLuuTru = (int?)lookUpEdit_TenVTLT.EditValue;
            return ls;
        }

        public LoaiSach DeleteEntity()
        {
            LoaiSach ls = new LoaiSach();
            //ls.maLoaiSach = textEdit_MaLoaiSach.Text;
            ls.maLoaiSach = maLoaiSach;
            return ls;
        }

        public LoaiSach UpdateEntity()
        {
            LoaiSach ls = new LoaiSach();
            ls.maLoaiSach = maLoaiSach;
            ls.maLoaiSach = textEdit_MaLoaiSach.Text;
            ls.tenLoaiSach = textEdit_TenLoaiSach.Text;
            if (lookUpEdit_TenVTLT.EditValue != null)
                ls.maViTriLuuTru = (int?)lookUpEdit_TenVTLT.EditValue;
            return ls;
        }

        private void FormLoaiSach_Load(object sender, EventArgs e)
        {
            preLoaiSach.ViewList();
            preVTLT.ViewList();
        }

        void IViewListEntity<LoaiSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_LoaiSach.DataSource = entities;
        }

        void IViewListEntity<ViTriLuuTru>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenVTLT.Properties.DataSource = entities;
            colVTLT.DataSource = entities;
            colVTLT.DataPropertyName = "maViTriLuuTru";
            colVTLT.ValueMember = "maViTriLuuTru";
            colVTLT.DisplayMember = "tenViTriLuuTru";
        }

        private void simpleButton_LoaiSach_Click(object sender, EventArgs e)
        {
            if (radioGroup_LoaiSach.EditValue.Equals("Add"))
                preLoaiSach.addNewEntity();
            else if (radioGroup_LoaiSach.EditValue.Equals("Delete"))
                preLoaiSach.deleteEntity();
            else if (radioGroup_LoaiSach.EditValue.Equals("Update"))
                preLoaiSach.updateEntity();
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            preLoaiSach.viewEntityAt(rowIndex);
        }

        // Event SelectedIndexChanged for RadioGroup
        private void radioGroup_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_LoaiSach.EditValue.Equals("Add"))
            {
                textEdit_MaLoaiSach.ReadOnly = false;
                textEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenVTLT.ReadOnly = false;
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Delete"))
            {
                textEdit_MaLoaiSach.ReadOnly = true;
                textEdit_TenLoaiSach.ReadOnly = true;
                lookUpEdit_TenVTLT.ReadOnly = true;
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Update"))
            {
                textEdit_MaLoaiSach.ReadOnly = true;
                textEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenVTLT.ReadOnly = false;
            }
        }
    }
}