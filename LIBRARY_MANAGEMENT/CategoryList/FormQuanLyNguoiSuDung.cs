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
        int oldIndexOfRow;
        Boolean isButCapNhapClick;
        Boolean isButCapMoiMatKhauClick;

        public FormQuanLyNguoiSuDung()
        {
            InitializeComponent();
            preNguoiSD.View = this;
            dataGridView_QuanLyNguoiSD.AutoGenerateColumns = false;
        }

        public NguoiSuDung AddNewEntity()
        {
            if (textEdit_MaNguoiSD.Text != null && textEdit_MaNguoiSD.Text.Length > 0)
            {
                NguoiSuDung ngsd = new NguoiSuDung();
                ngsd.maNguoiSD = textEdit_MaNguoiSD.Text;
                ngsd.tenNguoiSD = textEdit_TenNguoiSD.Text;

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
            else
                return null;
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
            if (this.isButCapMoiMatKhauClick == true && this.isButCapNhapClick == false)
            {
                NguoiSuDung ngsd1 = new NguoiSuDung();
                ngsd1.maNguoiSD = maNguoiSD;
                ngsd = preNguoiSD.getUserbyIDforUpdateNewPassword(ngsd1);
                ngsd.password = textEdit_NhapLaiMatKhauCapMoi.Text;
            }
            else if (this.isButCapNhapClick == true && this.isButCapMoiMatKhauClick == false)
            {
                NguoiSuDung ngsd1 = new NguoiSuDung();
                ngsd1.maNguoiSD = maNguoiSD;

                ngsd.maNguoiSD = maNguoiSD;
                ngsd.tenNguoiSD = textEdit_TenNguoiSD.Text;
                ngsd.password = preNguoiSD.getUserbyIDforUpdateNewPassword(ngsd1).password;
                if (toggleSwitch_TrangThaiHoatDong.IsOn == true)
                    ngsd.enable = true;
                else
                    ngsd.enable = false;
                if (toggleSwitch_Admin.IsOn == true)
                    ngsd.admin = true;
                else
                    ngsd.admin = false;
            }
            return ngsd;
        }

        public void viewEntity(NguoiSuDung entity)
        {
            maNguoiSD = entity.maNguoiSD;
            textEdit_MaNguoiSD.Text = entity.maNguoiSD;
            textEdit_TenNguoiSD.Text = entity.tenNguoiSD;
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
            this.oldIndexOfRow = 0;
        }

        private void dataGridView_QuanLyNguoiSD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            //for (int i = 0; i < dataGridView_QuanLyNguoiSD.Rows[e.RowIndex].Cells.Count; i++)
            //{
            //    dataGridView_QuanLyNguoiSD.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            //}
            preNguoiSD.viewEntityAt(rowIndex);
        }

        private void simpleButton_QuanLyUser_Click(object sender, EventArgs e)
        {
            if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Add"))
            {
                preNguoiSD.addNewEntity();
                //rowIndex = dataGridView_QuanLyNguoiSD.DataBindings.Count - 1;
                //rowIndex = preNguoiSD.countBindingSourcePresenter - 1;
            }
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Delete"))
            {
                preNguoiSD.deleteEntity();
            }
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Update"))
            {
                this.isButCapNhapClick = true;
                this.isButCapMoiMatKhauClick = false;
                preNguoiSD.updateEntity();
            }  
        }

        private void radioGroup_QuanLyNguoiSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Add"))
            {
                simpleButton_QuanLyUser.Text = "Thêm người sử dụng";
                simpleButton_QuanLyUser.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_MaNguoiSD.ReadOnly = false;
                textEdit_TenNguoiSD.ReadOnly = false;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = false;
                toggleSwitch_Admin.ReadOnly = false;
            }
            else if(radioGroup_QuanLyNguoiSD.EditValue.Equals("Delete"))
            {
                simpleButton_QuanLyUser.Text = "Xóa người sử dụng";
                simpleButton_QuanLyUser.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_MaNguoiSD.ReadOnly = true;
                textEdit_TenNguoiSD.ReadOnly = true;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = true;
                toggleSwitch_Admin.ReadOnly = true;
            }
            else if (radioGroup_QuanLyNguoiSD.EditValue.Equals("Update"))
            {
                simpleButton_QuanLyUser.Text = "Sửa thông tin người sử dụng";
                simpleButton_QuanLyUser.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_MaNguoiSD.ReadOnly = true;
                textEdit_TenNguoiSD.ReadOnly = false;
                toggleSwitch_TrangThaiHoatDong.ReadOnly = false;
                toggleSwitch_Admin.ReadOnly = false;
            }
        }

        //private void dataGridView_QuanLyNguoiSD_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (this.oldIndexOfRow == e.RowIndex)
        //        dataGridView_QuanLyNguoiSD.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
        //    else
        //    {
        //        dataGridView_QuanLyNguoiSD.Rows[this.oldIndexOfRow].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
        //        this.oldIndexOfRow = e.RowIndex;
        //        dataGridView_QuanLyNguoiSD.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
        //    }
        //}

        private void simpleButton_CapMoiMatKhau_Click(object sender, EventArgs e)
        {
            if (textEdit_CapMoiMatKhau.Text != null && textEdit_CapMoiMatKhau.Text.Length > 0)
            {
                if (textEdit_NhapLaiMatKhauCapMoi.Text == textEdit_CapMoiMatKhau.Text)
                {
                    labelControl_CheckMatKhauCapMoi.ForeColor = Color.Blue;
                    labelControl_CheckMatKhauCapMoi.Text = "Cấp mới khẩu thành công !!!";
                    labelControl_CheckMatKhauCapMoi.Update();
                    this.isButCapMoiMatKhauClick = true;
                    this.isButCapNhapClick = false;
                    preNguoiSD.updateEntity();
                }
                else
                {
                    labelControl_CheckMatKhauCapMoi.ForeColor = Color.Red;
                    labelControl_CheckMatKhauCapMoi.Text = "Mật khẩu cấp mới không hợp lệ !!! Vui lòng nhập lại";
                    labelControl_CheckMatKhauCapMoi.Update();
                }
            }
            else
            {
                labelControl_CheckMatKhauCapMoi.ForeColor = Color.Red;
                labelControl_CheckMatKhauCapMoi.Text = "Mật khẩu cấp mới không hợp lệ !!! Vui lòng nhập lại";
                labelControl_CheckMatKhauCapMoi.Update();
            }  
        }
    }
}