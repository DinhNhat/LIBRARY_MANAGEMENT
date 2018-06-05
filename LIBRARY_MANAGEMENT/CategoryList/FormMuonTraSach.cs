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
    public partial class FormMuonTraSach : DevExpress.XtraEditors.XtraForm, IViewEntity<MuonSach>, IViewListEntity<Sach>, IViewListEntity<TinhTrangSachMuonTra>, IViewListEntity<TrangThai>, IViewListEntity<PhieuSuDungSach>
    {
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();
        PrePhieuSuDungSach prePhieu = new PrePhieuSuDungSach();
        PreSach preSach = new PreSach();
        PreTinhTrangSachMuonTra preTTSMT = new PreTinhTrangSachMuonTra();
        PreTrangThai preTrangThai = new PreTrangThai();

        int soTT;
        string maPhieu;
        int rowIndex;

        public FormMuonTraSach()
        {
            InitializeComponent();
            preMuonTraSach.View = this;
            prePhieu.ViewLs = this;
            preSach.ViewLs = this;
            preTTSMT.ViewLs = this;
            preTrangThai.ViewLs = this;
            dataGridView_MuonTraSach.AutoGenerateColumns = false;
        }

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {
            prePhieu.ViewList();
            preSach.ViewList();
            preTTSMT.ViewList();
            preTrangThai.ViewList();
        }

        void IViewEntity<MuonSach>.viewEntity(MuonSach muonsach)
        {
            soTT = muonsach.soTT;
            maPhieu = muonsach.maPhieuSD;
            dateEdit_NgayMuon.EditValue = (DateTime)muonsach.ngayMuon;
            if (muonsach.ngayDuKienTra != null)
                dateEdit_NgayDuKienTra.EditValue = (DateTime)muonsach.ngayDuKienTra;
            else
                dateEdit_NgayDuKienTra.EditValue = null;
            if (muonsach.ngayTra != null)
                dateEdit_NgayTra.EditValue = (DateTime)muonsach.ngayTra;
            else
                dateEdit_NgayTra.EditValue = null;
            textEdit_TienPhat.Text = muonsach.tienPhat.ToString();
            lookUpEdit_MaPhieu.EditValue = muonsach.maPhieuSD;
            lookUpEdit_Sach.EditValue = muonsach.maSach;
            lookUpEdit_TinhTrang.EditValue = muonsach.maTinhTrangSach;
            lookUpEdit_TrangThai.EditValue = muonsach.maTrangThai;
        }

        void IViewListEntity<MuonSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_MuonTraSach.DataSource = entities;
        }

        // CRUD Methods
        #region
        public MuonSach AddNewEntity()
        {
            MuonSach ms = new MuonSach();
            ms.soTT = preMuonTraSach.LastKey + 1;
            if (lookUpEdit_MaPhieu.EditValue != null)
                ms.maPhieuSD = lookUpEdit_MaPhieu.EditValue.ToString();
            if(lookUpEdit_Sach.EditValue != null)
                ms.maSach = lookUpEdit_Sach.EditValue.ToString();
            if (lookUpEdit_TinhTrang.EditValue != null)
                ms.maTinhTrangSach = (Int32)lookUpEdit_TinhTrang.EditValue;
            if (lookUpEdit_TrangThai.EditValue != null)
                ms.maTrangThai = (Int32)lookUpEdit_TrangThai.EditValue;
            if(dateEdit_NgayMuon.EditValue != null)
                ms.ngayMuon = (DateTime)dateEdit_NgayMuon.EditValue;
            if (dateEdit_NgayDuKienTra.EditValue != null)
                ms.ngayDuKienTra = (DateTime)dateEdit_NgayDuKienTra.EditValue;
            if (dateEdit_NgayTra.EditValue != null)
                ms.ngayTra = (DateTime)dateEdit_NgayTra.EditValue;
            if (textEdit_TienPhat.Text != null)
            {
                if(textEdit_TienPhat.Text == "")
                    ms.tienPhat = null;
                else
                    ms.tienPhat = Int32.Parse(textEdit_TienPhat.Text);
            }
            else
                ms.tienPhat = null;

            return ms;
        }

        public MuonSach DeleteEntity()
        {
            MuonSach muonsach = new MuonSach();
            muonsach.maPhieuSD = maPhieu;
            muonsach.soTT = soTT;
            return muonsach;
        }

        public MuonSach UpdateEntity()
        {
            MuonSach ms = new MuonSach();
            ms.maPhieuSD = maPhieu;
            ms.soTT = soTT;
            if (lookUpEdit_Sach.EditValue != null)
                ms.maSach = lookUpEdit_Sach.EditValue.ToString();
            if (lookUpEdit_TinhTrang.EditValue != null)
                ms.maTinhTrangSach = (Int32)lookUpEdit_TinhTrang.EditValue;
            if (lookUpEdit_TrangThai.EditValue != null)
                ms.maTrangThai = (Int32)lookUpEdit_TrangThai.EditValue;
            if (dateEdit_NgayMuon.EditValue != null)
                ms.ngayMuon = (DateTime)dateEdit_NgayMuon.EditValue;
            if (dateEdit_NgayDuKienTra.EditValue != null)
                ms.ngayDuKienTra = (DateTime)dateEdit_NgayDuKienTra.EditValue;
            if (dateEdit_NgayTra.EditValue != null)
                ms.ngayTra = (DateTime)dateEdit_NgayTra.EditValue;
            if (textEdit_TienPhat.Text != null)
            {
                if (textEdit_TienPhat.Text == "")
                    ms.tienPhat = null;
                else
                    ms.tienPhat = Int32.Parse(textEdit_TienPhat.Text);
            }
            else
                ms.tienPhat = null;

            return ms;
        }
        #endregion

        // ViewList Methods for LookUpEdit
        #region
        void IViewListEntity<PhieuSuDungSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_MaPhieu.Properties.DataSource = entities;
            // lookUpEdit_MaPhieu_forFilter.Properties.DataSource = entities;
        }
        void IViewListEntity<Sach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_Sach.Properties.DataSource = entities;
            colSach.DataSource = entities;
            colSach.DataPropertyName = "maSach";
            colSach.ValueMember = "maSach";
            colSach.DisplayMember = "tenSach";
        }

        void IViewListEntity<TrangThai>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TrangThai.Properties.DataSource = entities;
            lookUpEdit_TrangThai_forFilter.Properties.DataSource = entities;
            colTrangThai.DataSource = entities;
            colTrangThai.DataPropertyName = "maTrangThai";
            colTrangThai.ValueMember = "maTrangThai";
            colTrangThai.DisplayMember = "tenTrangThai";
        }

        void IViewListEntity<TinhTrangSachMuonTra>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TinhTrang.Properties.DataSource = entities;
            colTinhTrang.DataSource = entities;
            colTinhTrang.DataPropertyName = "maTinhTrangSach";
            colTinhTrang.ValueMember = "maTinhTrangSach";
            colTinhTrang.DisplayMember = "tenTinhTrangSach";
        }


        #endregion

        // View Detail for Doc Gia
        void ViewChiTietDocGiabyFilter()
        {
            PhieuSuDungSach phieu;
            phieu = preMuonTraSach.GetEntityPhieuForFilter();
            if(phieu != null)
            {
                textEdit_HoTen.Text = phieu.hoTen;
                textEdit_Lop.Text = preMuonTraSach.tenLop;
                dateEdit_NgayThangNamSinh.EditValue = phieu.ngayThangNamSinh;
                textEdit_Email.Text = phieu.email;
                textEdit_SoDT.Text = phieu.soDT;
            }
            else
            {
                textEdit_HoTen.Text = "";
                textEdit_Lop.Text = "";
                dateEdit_NgayThangNamSinh.EditValue = null;
                textEdit_Email.Text = "";
                textEdit_SoDT.Text = "";
            } 
        }

        // clear data from some controls for filter nothing or clear button
        void ClearDatafromControl()
        {
            lookUpEdit_MaPhieu.EditValue = null;
            lookUpEdit_Sach.EditValue = null;
            lookUpEdit_TinhTrang.EditValue = null;
            lookUpEdit_TrangThai.EditValue = null;
            dateEdit_NgayMuon.EditValue = null;
            dateEdit_NgayDuKienTra.EditValue = null;
            dateEdit_NgayTra.EditValue = null;
            textEdit_TienPhat.Text = "";
        }

        private void simpleButton_LocMaPhieu_Click(object sender, EventArgs e)
        {
            preMuonTraSach.maPhieuSD = textEdit_MaPhieu_forFilter.Text;
            lookUpEdit_TrangThai_forFilter.EditValue = null;
            preMuonTraSach.trangThai = null;

            if (preMuonTraSach.SetBindingSource() == true) // value of text != ""
            {
                if (preMuonTraSach.CountForBindingSource > 0) // value of text right
                {
                    ViewChiTietDocGiabyFilter();
                    preMuonTraSach.ViewList();
                }
                else // value of text wrong
                {
                    preMuonTraSach.ViewList();
                    ClearDatafromControl();
                }
            }
            else // value of text == ""
            {
                ViewChiTietDocGiabyFilter();
                ClearDatafromControl();
            }
        }

        private void simpleButton_LocTrangThai_Click(object sender, EventArgs e)
        {
            textEdit_MaPhieu_forFilter.Text = "";
            preMuonTraSach.maPhieuSD = "";
            preMuonTraSach.trangThai = lookUpEdit_TrangThai_forFilter.EditValue;

            if (preMuonTraSach.SetBindingSource() == true) // context: lookUpEdit_TrangThai_forFilter.EditValue != null
            {
                if (preMuonTraSach.CountForBindingSource > 0) // context: lookUpEdit_TrangThai_forFilter.EditValue already exists
                {
                    ViewChiTietDocGiabyFilter();
                    preMuonTraSach.ViewList();
                }
                else // context: lookUpEdit_TrangThai_forFilter.EditValue haven't existed yet
                {
                    preMuonTraSach.ViewList();
                    ClearDatafromControl();
                }
            }
            else // context: lookUpEdit_TrangThai_forFilter.EditValue == null
            {
                ViewChiTietDocGiabyFilter();
                ClearDatafromControl();
            }
        }

        private void simpleButton_MuonTraSach_Click(object sender, EventArgs e)
        {
            if (radioGroup_MuonTraSach.EditValue.Equals("Add"))
            {
                preMuonTraSach.oldMaPhieu = lookUpEdit_MaPhieu.EditValue.ToString();
                preMuonTraSach.addNewEntity();
                preMuonTraSach.SetBindingSourceWhereMaPhieu(preMuonTraSach.oldMaPhieu);
                preMuonTraSach.ViewList();
            }
            else if (radioGroup_MuonTraSach.EditValue.Equals("Delete"))
            {
                preMuonTraSach.oldMaPhieu = lookUpEdit_MaPhieu.EditValue.ToString();
                preMuonTraSach.deleteEntity();
                if(preMuonTraSach.SetBindingSourceAgainforDelete() == true)
                    preMuonTraSach.ViewList();
                else
                {
                    preMuonTraSach.maPhieuSD = "";
                    ViewChiTietDocGiabyFilter();
                    ClearDatafromControl();
                }
            }
            else if(radioGroup_MuonTraSach.EditValue.Equals("Update"))
            {
                preMuonTraSach.oldMaPhieu = lookUpEdit_MaPhieu.EditValue.ToString();
                preMuonTraSach.updateEntity();
                preMuonTraSach.SetBindingSourceWhereMaPhieu(preMuonTraSach.oldMaPhieu);
                preMuonTraSach.ViewList();
            }
        }

        // Clear data for Clear Button
        private void ClearOldData()
        {
            textEdit_MaPhieu_forFilter.Text = "";
            lookUpEdit_TrangThai_forFilter.EditValue = null;

            ClearDatafromControl();

            preMuonTraSach.maPhieuSD = "";
            preMuonTraSach.trangThai = null;
            ViewChiTietDocGiabyFilter();
            preMuonTraSach.SetBindingSource();
            preMuonTraSach.ViewList();
        }

        private void simpleButton_Clear_Click(object sender, EventArgs e)
        {
            ClearOldData();
        }

        private void radioGroup_MuonTraSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_MuonTraSach.EditValue.Equals("Add"))
            {
                lookUpEdit_MaPhieu.ReadOnly = false;
                lookUpEdit_Sach.ReadOnly = false;
                lookUpEdit_TinhTrang.ReadOnly = false;
                lookUpEdit_TrangThai.ReadOnly = false;
                dateEdit_NgayMuon.ReadOnly = false;
                dateEdit_NgayDuKienTra.ReadOnly = false;
                dateEdit_NgayTra.ReadOnly = false;
                textEdit_TienPhat.ReadOnly = false;
            }
            else if (radioGroup_MuonTraSach.EditValue.Equals("Delete"))
            {
                lookUpEdit_MaPhieu.ReadOnly = true;
                lookUpEdit_Sach.ReadOnly = true;
                lookUpEdit_TinhTrang.ReadOnly = true;
                lookUpEdit_TrangThai.ReadOnly = true;
                dateEdit_NgayMuon.ReadOnly = true;
                dateEdit_NgayDuKienTra.ReadOnly = true;
                dateEdit_NgayTra.ReadOnly = true;
                textEdit_TienPhat.ReadOnly = true;
            }
            else if(radioGroup_MuonTraSach.EditValue.Equals("Update"))
            {
                lookUpEdit_MaPhieu.ReadOnly = true;
                lookUpEdit_Sach.ReadOnly = false;
                lookUpEdit_TinhTrang.ReadOnly = false;
                lookUpEdit_TrangThai.ReadOnly = false;
                dateEdit_NgayMuon.ReadOnly = false;
                dateEdit_NgayDuKienTra.ReadOnly = false;
                dateEdit_NgayTra.ReadOnly = false;
                textEdit_TienPhat.ReadOnly = false;
            }
        }

        private void dataGridView_MuonTraSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
                preMuonTraSach.viewEntityAt(rowIndex);
            MuonSach ms = (MuonSach)preMuonTraSach.Bindingsource[rowIndex];
            preMuonTraSach.maPhieuSD = ms.maPhieuSD;
            ViewChiTietDocGiabyFilter();
        }

    }
}