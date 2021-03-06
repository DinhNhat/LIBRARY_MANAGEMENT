﻿using System;
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

        public void viewEntity(ViTriLuuTru vtlt)
        {
            textEdit_VTLT.Text = vtlt.tenViTriLuuTru;
            maVTLT = vtlt.maViTriLuuTru;
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
                int num = preViTriLuuTru.addNewEntity();
                if (num > 0)
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

        private void radioGroup_VTLT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_VTLT.EditValue.Equals("Add"))
            {
                textEdit_VTLT.ReadOnly = false;
                simpleButton_VTLT.Text = "Thêm vị trí lưu trữ";
                simpleButton_VTLT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            }
            else if (radioGroup_VTLT.EditValue.Equals("Delete"))
            {
                textEdit_VTLT.ReadOnly = true;
                simpleButton_VTLT.Text = "Xóa vị trí lưu trữ";
                simpleButton_VTLT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
            }
            else if (radioGroup_VTLT.EditValue.Equals("Update"))
            {
                textEdit_VTLT.ReadOnly = false;
                simpleButton_VTLT.Text = "Sửa tên vị trí lưu trữ";
                simpleButton_VTLT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
            }
        }
    }
}