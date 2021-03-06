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
    public partial class FormLop : DevExpress.XtraEditors.XtraForm, IViewEntity<Lop>, IViewListEntity<NamHoc>
    {
        PreLop preLop = new PreLop();
        PreNamHoc preNamHoc = new PreNamHoc();
        PrePhieuSuDungSach prePhieu = new PrePhieuSuDungSach();

        int maLop;
        int rowIndex;
        Boolean lblErrHeThongCheck = false;

        public FormLop()
        {
            InitializeComponent();
            preLop.View = this;
            preNamHoc.ViewLs = this;
            dataGridView_Lop.AutoGenerateColumns = false;
        }

        public Lop AddNewEntity()
        {
            if(textEdit_TenLop.Text != null && textEdit_TenLop.Text.Length > 0)
            {
                Lop lop = new Lop();
                lop.tenLop = textEdit_TenLop.Text;
                lop.maLop = preLop.LastKey + 1;
                lop.tenLop = textEdit_TenLop.Text;
                if (lookUpEdit_TenNamHoc.EditValue != null)
                    lop.maNamHoc = (int?)lookUpEdit_TenNamHoc.EditValue;
                this.lblErrHeThongCheck = false;
                return lop;
            }
            else
            {
                this.lblErrHeThongCheck = true;
                return null;
            } 
        }

        public Lop DeleteEntity()
        {
            Lop lop = new Lop();
            lop.maLop = maLop;
            if(prePhieu.getEntityByMaLop(lop.maLop) != null)
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            else
            {
                lop.tenLop = textEdit_TenLop.Text;
                return lop;
            }
        }

        public Lop UpdateEntity()
        {
            Lop lop = new Lop();
            lop.maLop = maLop;
            lop.tenLop = textEdit_TenLop.Text;
            if (lookUpEdit_TenNamHoc.EditValue != null)
                lop.maNamHoc = (int?)lookUpEdit_TenNamHoc.EditValue;
            return lop;
        }

        void IViewEntity<Lop>.viewEntity(Lop lop)
        {
            maLop = lop.maLop;
            textEdit_TenLop.Text = lop.tenLop;
            lookUpEdit_TenNamHoc.EditValue = lop.maNamHoc;
        }

        void IViewListEntity<Lop>.viewListEntity(BindingSource entities)
        {
            dataGridView_Lop.DataSource = entities;
        }

        void IViewListEntity<NamHoc>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenNamHoc.Properties.DataSource = entities;
            colNamHoc.DataSource = entities;
            colNamHoc.DataPropertyName = "maNamHoc";
            colNamHoc.ValueMember = "maNamHoc";
            colNamHoc.DisplayMember = "tenNamHoc";
        }

        private void simpleButton_Lop_Click(object sender, EventArgs e)
        {
            if (radioGroup_Lop.EditValue.Equals("Add"))
            {
                preLop.addNewEntity();
                rowIndex = dataGridView_Lop.DataBindings.Count - 1;
                if (this.lblErrHeThongCheck == true)
                {
                    labelControl_ErrorHeThong.ForeColor = Color.Red;
                    labelControl_ErrorHeThong.Text = "Lỗi hệ thống !!! Thêm không thành công.";
                    labelControl_ErrorHeThong.Update();
                    this.lblErrHeThongCheck = false;
                }
                else
                {
                    labelControl_ErrorHeThong.ForeColor = Color.Blue;
                    labelControl_ErrorHeThong.Text = "Thêm thành công.";
                    labelControl_ErrorHeThong.Update();
                }
            }
            else if (radioGroup_Lop.EditValue.Equals("Delete"))
            {
                preLop.deleteEntity();
                rowIndex = dataGridView_Lop.DataBindings.Count - 1;
                if (this.lblErrHeThongCheck == true)
                {
                    labelControl_ErrorHeThong.ForeColor = Color.Red;
                    labelControl_ErrorHeThong.Text = "Lỗi hệ thống !!! Xóa không thành công.";
                    labelControl_ErrorHeThong.Update();
                    this.lblErrHeThongCheck = false;
                }
                else
                {
                    labelControl_ErrorHeThong.ForeColor = Color.Blue;
                    labelControl_ErrorHeThong.Text = "Xóa thành công.";
                    labelControl_ErrorHeThong.Update();
                }
            }
            else if (radioGroup_Lop.EditValue.Equals("Update"))
            {
                preLop.updateEntity();
            }
        }

        private void dataGridView_Lop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            preLop.viewEntityAt(rowIndex);
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            preLop.ViewList();
            preNamHoc.ViewList();
        }

        private void radioGroup_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_Lop.EditValue.Equals("Add"))
            {
                simpleButton_Lop.Text = "Thêm lớp";
                simpleButton_Lop.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_TenLop.ReadOnly = false;
                lookUpEdit_TenNamHoc.ReadOnly = false;
            }
            else if (radioGroup_Lop.EditValue.Equals("Delete"))
            {
                simpleButton_Lop.Text = "Xóa lớp";
                simpleButton_Lop.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_TenLop.ReadOnly = true;
                lookUpEdit_TenNamHoc.ReadOnly = true;
            }
            else if (radioGroup_Lop.EditValue.Equals("Update"))
            {
                simpleButton_Lop.Text = "Sửa tên lớp";
                simpleButton_Lop.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_TenLop.ReadOnly = false;
                lookUpEdit_TenNamHoc.ReadOnly = false;
            }
        }
    }
}