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
    public partial class FormTacGia : DevExpress.XtraEditors.XtraForm , IViewEntity<TacGia>
    {
        PreTacGia preTacGia = new PreTacGia();
        int maTacGia;

        public FormTacGia()
        {
            InitializeComponent();
            preTacGia.View = this;
        }

        public void viewEntity(TacGia tg)
        {
            textEdit_TacGia.Text = tg.tenTacGia;
            maTacGia = tg.maTacGia;
        }

        public TacGia AddNewEntity()
        {
            TacGia tg = new TacGia();
            tg.maTacGia = preTacGia.LastKey + 1;
            tg.tenTacGia = textEdit_TacGia.Text;
            return tg;
        }

        public TacGia DeleteEntity()
        {
            TacGia tg = new TacGia();
            tg.maTacGia = maTacGia;
            return tg;
        }

        public TacGia UpdateEntity()
        {
            TacGia tg = new TacGia();
            tg.maTacGia = maTacGia;
            tg.tenTacGia = textEdit_TacGia.Text;
            return tg;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_TacGia.DataSource = entities;
            listBoxControl_TacGia.DisplayMember = "tenTacGia";
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            preTacGia.ListEntity();
        }

        private void listBoxControl_TacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_TacGia.SelectedIndex;
            preTacGia.viewEntityAt(index);
        }

        private void simpleButton_TacGia_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_TacGia.SelectedIndex;
            if (radioGroup_TacGia.EditValue.Equals("Add"))
            {
                preTacGia.addNewEntity();
                listBoxControl_TacGia.SelectedIndex = listBoxControl_TacGia.ItemCount - 1;
            }
            else
                if (radioGroup_TacGia.EditValue.Equals("Delete"))
            {
                int num = preTacGia.deleteEntity();
                if (num > 0)
                    listBoxControl_TacGia.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preTacGia.updateEntity();
                listBoxControl_TacGia.SelectedIndex = selectedIndex;
            }
        }
    }
}