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
    public partial class FormPhieuSuDungSach : DevExpress.XtraEditors.XtraForm, IViewEntity<PhieuSuDungSach>, IViewListEntity<Lop>
    {
        PrePhieuSuDungSach prePhieuSD = new PrePhieuSuDungSach();
        PreLop preLop = new PreLop();
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();

        string maPhieu;
        int rowIndex;
        int oldIndexOfRow;
        Boolean lblErrHeThongCheck = false;

        public FormPhieuSuDungSach()
        {
            InitializeComponent();
            prePhieuSD.View = this;
            preLop.ViewLs = this;
            dataGridView_PhieuSD.AutoGenerateColumns = false;
        }

        void IViewEntity<PhieuSuDungSach>.viewEntity(PhieuSuDungSach phieu)
        {
            maPhieu = phieu.maPhieuSD;
            textEdit_MaPhieu.Text = phieu.maPhieuSD;
            textEdit_HoTen.Text = phieu.hoTen;
            dateEdit_NamSinh.EditValue = (DateTime)phieu.ngayThangNamSinh;
            textEdit_Email.Text = phieu.email;
            textEdit_SoDT.Text = phieu.soDT;
            radioGroup_GioiTinh.EditValue = (bool)phieu.gioiTinh;
            lookUpEdit_TenLop.EditValue = phieu.maLop;
        }

        public PhieuSuDungSach AddNewEntity()
        {
            if (textEdit_MaPhieu.Text != null && textEdit_MaPhieu.Text.Length > 0)
            {
                PhieuSuDungSach phieu = new PhieuSuDungSach();
                phieu.maPhieuSD = textEdit_MaPhieu.Text;
                phieu.hoTen = textEdit_HoTen.Text;
                phieu.ngayThangNamSinh = (DateTime)dateEdit_NamSinh.EditValue;
                phieu.gioiTinh = (bool)radioGroup_GioiTinh.EditValue;
                phieu.email = textEdit_Email.Text;
                phieu.soDT = textEdit_SoDT.Text;
                if (lookUpEdit_TenLop.EditValue != null)
                    phieu.maLop = (int?)lookUpEdit_TenLop.EditValue;
                this.lblErrHeThongCheck = false;
                return phieu;
            }
            else
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
        }

        public PhieuSuDungSach DeleteEntity()
        {
            PhieuSuDungSach phieu = new PhieuSuDungSach();
            phieu.maPhieuSD = maPhieu;
            if(preMuonTraSach.GetEntityByMaPhieuSuDung(phieu.maPhieuSD) != null)
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            else
                return phieu;
        }

        public PhieuSuDungSach UpdateEntity()
        {
            PhieuSuDungSach phieu = new PhieuSuDungSach();
            phieu.maPhieuSD = maPhieu;
            phieu.maPhieuSD = textEdit_MaPhieu.Text;
            phieu.hoTen = textEdit_HoTen.Text;
            phieu.ngayThangNamSinh = (DateTime)dateEdit_NamSinh.EditValue;
            phieu.gioiTinh = (bool)radioGroup_GioiTinh.EditValue;
            phieu.email = textEdit_Email.Text;
            phieu.soDT = textEdit_SoDT.Text;
            if (lookUpEdit_TenLop.EditValue != null)
                phieu.maLop = (int?)lookUpEdit_TenLop.EditValue;
            return phieu;
        }

        void IViewListEntity<PhieuSuDungSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_PhieuSD.DataSource = entities;
        }

        void IViewListEntity<Lop>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenLop.Properties.DataSource = entities;
            colTenLop.DataSource = entities;
            colTenLop.DataPropertyName = "maLop";
            colTenLop.ValueMember = "maLop";
            colTenLop.DisplayMember = "tenLop";
        }

        private void FormPhieuSuDungSach_Load(object sender, EventArgs e)
        {
            prePhieuSD.ViewList();
            preLop.ViewList();
            this.oldIndexOfRow = 0;
        }

        private void simpleButton_PhieuSD_Click(object sender, EventArgs e)
        {
            if (radioGroup_PhieuSD.EditValue.Equals("Add"))
            {
                prePhieuSD.addNewEntity();
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
            else if (radioGroup_PhieuSD.EditValue.Equals("Delete"))
            {
                prePhieuSD.deleteEntity();
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
            else if (radioGroup_PhieuSD.EditValue.Equals("Update"))
                prePhieuSD.updateEntity();
        }

        private void dataGridView_PhieuSD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            prePhieuSD.viewEntityAt(rowIndex);
        }

        private void radioGroup_PhieuSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_PhieuSD.EditValue.Equals("Add"))
            {
                textEdit_MaPhieu.ReadOnly = false;
                textEdit_HoTen.ReadOnly = false;
                dateEdit_NamSinh.ReadOnly = false;
                textEdit_Email.ReadOnly = false;
                textEdit_SoDT.ReadOnly = false;
                lookUpEdit_TenLop.ReadOnly = false;
                radioGroup_GioiTinh.ReadOnly = false;
                simpleButton_PhieuSD.Text = "Thêm phiếu sử dụng";
                this.simpleButton_PhieuSD.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            }
            else if (radioGroup_PhieuSD.EditValue.Equals("Delete"))
            {
                textEdit_MaPhieu.ReadOnly = true;
                textEdit_HoTen.ReadOnly = true;
                dateEdit_NamSinh.ReadOnly = true;
                textEdit_Email.ReadOnly = true;
                textEdit_SoDT.ReadOnly = true;
                lookUpEdit_TenLop.ReadOnly = true;
                radioGroup_GioiTinh.ReadOnly = true;
                simpleButton_PhieuSD.Text = "Xóa phiếu sử dụng";
                this.simpleButton_PhieuSD.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
            }
            else if (radioGroup_PhieuSD.EditValue.Equals("Update"))
            {
                textEdit_MaPhieu.ReadOnly = true;
                textEdit_HoTen.ReadOnly = false;
                dateEdit_NamSinh.ReadOnly = false;
                textEdit_Email.ReadOnly = false;
                textEdit_SoDT.ReadOnly = false;
                lookUpEdit_TenLop.ReadOnly = false;
                radioGroup_GioiTinh.ReadOnly = false;
                simpleButton_PhieuSD.Text = "Sửa thông tin phiếu";
                this.simpleButton_PhieuSD.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
            }
        }
    }
}