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
    public partial class FormViTriLuuTru : DevExpress.XtraEditors.XtraForm, IViewEntity<ViTriLuuTru>
    {
        PreViTriLuuTru preViTriLuuTru = new PreViTriLuuTru();
        int maVTLT;

        public FormViTriLuuTru()
        {
            InitializeComponent();
            preViTriLuuTru.View = this;
        }

        // implement interface IViewEntity<ViTriLuuTru>
        #region
        public ViTriLuuTru AddNewEntity()
        {
            ViTriLuuTru vtlt = new ViTriLuuTru();
            vtlt.maViTriLuuTru = preViTriLuuTru.LastKey + 1;
            vtlt.tenViTriLuuTru = textEdit_VTLT.Text;
            return vtlt;
        }

        public ViTriLuuTru DeleteEntity()
        {
            ViTriLuuTru vtlt = new ViTriLuuTru();
            vtlt.maViTriLuuTru = maVTLT;
            return vtlt;
        }

        public ViTriLuuTru UpdateEntity()
        {
            ViTriLuuTru vtlt = new ViTriLuuTru();
            vtlt.maViTriLuuTru = maVTLT;
            vtlt.tenViTriLuuTru = textEdit_VTLT.Text;
            return vtlt;
        }

        public void viewEntity(ViTriLuuTru vtlt)
        {
            textEdit_VTLT.Text = vtlt.tenViTriLuuTru;
            maVTLT = vtlt.maViTriLuuTru;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_VTLT.DataSource = entities;
            listBoxControl_VTLT.DisplayMember = "tenViTriLuuTru";
        }
        #endregion
        // End Emplimentation

        private void FormViTriLuuTru_Load(object sender, EventArgs e)
        {
            preViTriLuuTru.ListEntity();
        }

        private void listBoxControl_VTLT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_VTLT.SelectedIndex;
            preViTriLuuTru.viewEntityAt(index);
        }

        private void simpleButton_VTLT_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_VTLT.SelectedIndex;
            if (radioGroup_VTLT.EditValue.Equals("Add"))
            {
                preViTriLuuTru.addNewEntity();
                listBoxControl_VTLT.SelectedIndex = listBoxControl_VTLT.ItemCount - 1;
            }
            else
                if (radioGroup_VTLT.EditValue.Equals("Delete"))
            {
                int num = preViTriLuuTru.deleteEntity();
                if (num > 0)
                    listBoxControl_VTLT.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preViTriLuuTru.updateEntity();
                listBoxControl_VTLT.SelectedIndex = selectedIndex;
            }
        }
    }
}