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
    public partial class FormQuanLyNguoiSuDung : DevExpress.XtraEditors.XtraForm, IViewEntity<NguoiSuDung>
    {
        PreNguoiSD preNguoiSD = new PreNguoiSD();
        string maNguoiSD;
        int rowIndex;

        public FormQuanLyNguoiSuDung()
        {
            InitializeComponent();
            preNguoiSD.View = this;
            dataGridView_QuanLyNguoiSD.AutoGenerateColumns = false;
        }

        public NguoiSuDung AddNewEntity()
        {
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd.maNguoiSD = textEdit_MaNguoiSD.Text;
            ngsd.tenNguoiSD = textEdit_TenNguoiSD.Text;
            ngsd.password = textEdit_MatKhau.Text;

            if (toggleSwitch_TrangThaiHoatDong.IsOn == true)
                ngsd.enable = true;
            else
                ngsd.enable = false;
            if (toggleSwitch_Admin.IsOn == true)
                ngsd.admin = true;
            else
                ngsd.admin = false;

            return ngsd;
        }

        public NguoiSuDung DeleteEntity()
        {
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd.maNguoiSD = maNguoiSD;
            return ngsd;
        }

        public NguoiSuDung UpdateEntity()
        {
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd.maNguoiSD = maNguoiSD;
            ngsd.tenNguoiSD = textEdit_TenNguoiSD.Text;
            ngsd.password = textEdit_MatKhau.Text;

            if (toggleSwitch_TrangThaiHoatDong.IsOn == true)
                ngsd.enable = true;
            else
                ngsd.enable = false;
            if (toggleSwitch_Admin.IsOn == true)
                ngsd.admin = true;
            else
                ngsd.admin = false;

            return ngsd;
        }

        public void viewEntity(NguoiSuDung entity)
        {
            maNguoiSD = entity.maNguoiSD;
            textEdit_MaNguoiSD.Text = entity.maNguoiSD;
            textEdit_TenNguoiSD.Text = entity.tenNguoiSD;
            textEdit_MatKhau.Text = entity.password;
            if(entity.enable == true)
                toggleSwitch_TrangThaiHoatDong.IsOn = true;
            else
                toggleSwitch_TrangThaiHoatDong.IsOn = false;
            if (entity.admin == true)
                toggleSwitch_Admin.IsOn = true;
            else
                toggleSwitch_Admin.IsOn = false;
        }

        public void viewListEntity(BindingSource entities)
        {
            dataGridView_QuanLyNguoiSD.DataSource = entities;
        }

        private void FormQuanLyNguoiSuDung_Load(object sender, EventArgs e)
        {
            preNguoiSD.ViewList();
        }

        private void dataGridView_QuanLyNguoiSD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            preNguoiSD.viewEntityAt(rowIndex);
        }

        private void simpleButton_QuanLyUser_Click(object sender, EventArgs e)
        {
            if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Add"))
            {
                preNguoiSD.addNewEntity();
                rowIndex = dataGridView_QuanLyNguoiSD.DataBindings.Count - 1;
            }
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Delete"))
                preNguoiSD.deleteEntity();
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Update"))
                preNguoiSD.updateEntity();
        }

        private void radioGroup_QuanLyNguoiSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Add"))
            {
                textEdit_MaNguoiSD.ReadOnly = false;
                textEdit_TenNguoiSD.ReadOnly = false;
                textEdit_MatKhau.ReadOnly = false;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = false;
                toggleSwitch_Admin.ReadOnly = false;
            }
            else if(radioGroup_QuanLyNguoiSD.EditValue.Equals("Delete"))
            {
                textEdit_MaNguoiSD.ReadOnly = true;
                textEdit_TenNguoiSD.ReadOnly = true;
                textEdit_MatKhau.ReadOnly = true;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = true;
                toggleSwitch_Admin.ReadOnly = true;
            }
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Update"))
            {
                textEdit_MaNguoiSD.ReadOnly = true;
                textEdit_TenNguoiSD.ReadOnly = false;
                textEdit_MatKhau.ReadOnly = false;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = false;
                toggleSwitch_Admin.ReadOnly = false;
            }
        }
    }
}