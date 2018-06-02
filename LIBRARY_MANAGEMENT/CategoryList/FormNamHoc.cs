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
    public partial class FormNamHoc : DevExpress.XtraEditors.XtraForm, IViewEntity<NamHoc>
    {
        PreNamHoc preNamHoc = new PreNamHoc();
        int maNamHoc;

        public FormNamHoc()
        {
            InitializeComponent();
            preNamHoc.View = this;
        }

        public NamHoc AddNewEntity()
        {
            NamHoc nh = new NamHoc();
            nh.maNamHoc = preNamHoc.LastKey + 1;
            nh.tenNamHoc = textEdit_NamHoc.Text;
            return nh;
        }

        public NamHoc DeleteEntity()
        {
            NamHoc nh = new NamHoc();
            nh.maNamHoc = maNamHoc;
            return nh;
        }

        public NamHoc UpdateEntity()
        {
            NamHoc nh = new NamHoc();
            nh.maNamHoc = maNamHoc;
            nh.tenNamHoc = textEdit_NamHoc.Text;
            return nh;
        }

        public void viewEntity(NamHoc nh)
        {
            textEdit_NamHoc.Text = nh.tenNamHoc;
            maNamHoc = nh.maNamHoc;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_NamHoc.DataSource = entities;
            listBoxControl_NamHoc.DisplayMember = "tenNamHoc";
        }

        private void FormNamHoc_Load(object sender, EventArgs e)
        {
            preNamHoc.ListEntity();
        }

        private void listBoxControl_NamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_NamHoc.SelectedIndex;
            preNamHoc.viewEntityAt(index);
        }

        private void simpleButton_NamHoc_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_NamHoc.SelectedIndex;
            if (radioGroup_NamHoc.EditValue.Equals("Add"))
            {
                preNamHoc.addNewEntity();
                listBoxControl_NamHoc.SelectedIndex = listBoxControl_NamHoc.ItemCount - 1;
            }
            else
                if (radioGroup_NamHoc.EditValue.Equals("Delete"))
            {
                int num = preNamHoc.deleteEntity();
                if (num > 0)
                    listBoxControl_NamHoc.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preNamHoc.updateEntity();
                listBoxControl_NamHoc.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_NamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_NamHoc.EditValue.Equals("Add"))
                textEdit_NamHoc.ReadOnly = false;
            else 
                if (radioGroup_NamHoc.EditValue.Equals("Delete"))
                    textEdit_NamHoc.ReadOnly = true;
            else
                if (radioGroup_NamHoc.EditValue.Equals("Update"))
                    textEdit_NamHoc.ReadOnly = false;
        }
    }
}