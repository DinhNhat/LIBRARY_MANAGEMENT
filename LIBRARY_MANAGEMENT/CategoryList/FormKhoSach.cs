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
    public partial class 
        FormKhoSach : DevExpress.XtraEditors.XtraForm, IViewEntity<KhoSach>
    {
        PreKhoSach preKhoSach = new PreKhoSach();
        int maKhoSach;

        public FormKhoSach()
        {
            InitializeComponent();
            preKhoSach.View = this;
        }

        public KhoSach AddNewEntity()
        {
            KhoSach ks = new KhoSach();
            ks.maKhoSach = preKhoSach.LastKey + 1;
            ks.tenKhoSach = textEdit_KhoSach.Text;
            return ks;
        }

        public KhoSach DeleteEntity()
        {
            KhoSach ks = new KhoSach();
            ks.maKhoSach = maKhoSach;
            return ks;
        }

        public KhoSach UpdateEntity()
        {
            KhoSach ks = new KhoSach();
            ks.maKhoSach = maKhoSach;
            ks.tenKhoSach = textEdit_KhoSach.Text;
            return ks;
        }

        public void viewEntity(KhoSach ks)
        {
            textEdit_KhoSach.Text = ks.tenKhoSach;
            maKhoSach = ks.maKhoSach;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_KhoSach.DataSource = entities;
            listBoxControl_KhoSach.DisplayMember = "tenKhoSach";
        }

        private void FormKhoSach_Load(object sender, EventArgs e)
        {
            preKhoSach.ListEntity();
        }

        private void listBoxControl_KhoSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_KhoSach.SelectedIndex;
            preKhoSach.viewEntityAt(index);
        }

        private void simpleButton_KhoSach_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_KhoSach.SelectedIndex;
            if (radioGroup_KhoSach.EditValue.Equals("Add"))
            {
                int num = preKhoSach.addNewEntity();
                if (num > 0)
                    listBoxControl_KhoSach.SelectedIndex = listBoxControl_KhoSach.ItemCount - 1;
            }
            else if (radioGroup_KhoSach.EditValue.Equals("Delete"))
            {
                int num = preKhoSach.deleteEntity();
                if (num > 0)
                    listBoxControl_KhoSach.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preKhoSach.updateEntity();
                listBoxControl_KhoSach.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_KhoSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_KhoSach.EditValue.Equals("Add"))
                textEdit_KhoSach.ReadOnly = false;
            else if (radioGroup_KhoSach.EditValue.Equals("Delete"))
                textEdit_KhoSach.ReadOnly = true;
            else if (radioGroup_KhoSach.EditValue.Equals("Update"))
                textEdit_KhoSach.ReadOnly = false;
        }
    }
}