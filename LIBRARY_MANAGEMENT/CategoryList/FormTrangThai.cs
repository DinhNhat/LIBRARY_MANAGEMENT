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
    public partial class FormTrangThai : DevExpress.XtraEditors.XtraForm, IViewEntity<TrangThai>
    {
        PreTrangThai preTrangThai = new PreTrangThai();
        int maTrangThai;

        public FormTrangThai()
        {
            InitializeComponent();
            preTrangThai.View = this;
        }

        public void viewEntity(TrangThai tt)
        {
            textEdit_TrangThai.Text = tt.tenTrangThai;
            maTrangThai = tt.maTrangThai;
        }

        public TrangThai AddNewEntity()
        {
            TrangThai tt = new TrangThai();
            tt.maTrangThai = preTrangThai.LastKey + 1;
            tt.tenTrangThai = textEdit_TrangThai.Text;
            return tt;
        }

        public TrangThai DeleteEntity()
        {
            TrangThai tt = new TrangThai();
            tt.maTrangThai = maTrangThai;
            return tt;
        }

        public TrangThai UpdateEntity()
        {
            TrangThai tt = new TrangThai();
            tt.maTrangThai = maTrangThai;
            tt.tenTrangThai = textEdit_TrangThai.Text;
            return tt;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_TrangThai.DataSource = entities;
            listBoxControl_TrangThai.DisplayMember = "tenTrangThai";
        }

        private void FormTrangThai_Load(object sender, EventArgs e)
        {
            preTrangThai.ListEntity();
        }

        private void listBoxControl_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_TrangThai.SelectedIndex;
            preTrangThai.viewEntityAt(index);
        }

        private void simpleButton_TrangThai_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_TrangThai.SelectedIndex;
            if (radioGroup_TrangThai.EditValue.Equals("Add"))
            {
                preTrangThai.addNewEntity();
                listBoxControl_TrangThai.SelectedIndex = listBoxControl_TrangThai.ItemCount - 1;
            }
            else
                if (radioGroup_TrangThai.EditValue.Equals("Delete"))
            {
                int num = preTrangThai.deleteEntity();
                if (num > 0)
                    listBoxControl_TrangThai.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preTrangThai.updateEntity();
                listBoxControl_TrangThai.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_TrangThai.EditValue.Equals("Add"))
                textEdit_TrangThai.ReadOnly = false;
            else if (radioGroup_TrangThai.EditValue.Equals("Delete"))
                textEdit_TrangThai.ReadOnly = true;
            else if (radioGroup_TrangThai.EditValue.Equals("Update"))
                textEdit_TrangThai.ReadOnly = false;
        }
    }
}