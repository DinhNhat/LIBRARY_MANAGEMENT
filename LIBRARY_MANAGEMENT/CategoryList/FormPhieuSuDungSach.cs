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
        string maPhieu;
        int rowIndex;

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
            PhieuSuDungSach phieu = new PhieuSuDungSach();
            //phieu.maPhieuSD = prePhieuSD.LastKey + 1.ToString();
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

        public PhieuSuDungSach DeleteEntity()
        {
            PhieuSuDungSach phieu = new PhieuSuDungSach();
            //ls.maLoaiSach = textEdit_MaLoaiSach.Text;
            phieu.maPhieuSD = maPhieu;
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
        }

        private void simpleButton_PhieuSD_Click(object sender, EventArgs e)
        {
            if (radioGroup_PhieuSD.EditValue.Equals("Add"))
                prePhieuSD.addNewEntity();
            else if (radioGroup_PhieuSD.EditValue.Equals("Delete"))
                prePhieuSD.deleteEntity();
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
            }
        }
    }
}