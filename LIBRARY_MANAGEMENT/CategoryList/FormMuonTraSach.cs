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
    public partial class FormMuonTraSach : DevExpress.XtraEditors.XtraForm, IViewEntity<MuonSach>, IViewListEntity<Sach>, IViewListEntity<TinhTrangSachMuonTra>, IViewListEntity<TrangThai>, IViewListEntity<PhieuSuDungSach>, IViewListEntity<NguoiSuDung>
    {
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();
        PrePhieuSuDungSach prePhieu = new PrePhieuSuDungSach();
        PreSach preSach = new PreSach();
        PreTinhTrangSachMuonTra preTTSMT = new PreTinhTrangSachMuonTra();
        PreTrangThai preTrangThai = new PreTrangThai();
        PreNguoiSD preNguoiSD = new PreNguoiSD();

        int soTT;
        string maPhieu;
        int rowIndex;
        int oldIndexOfRow;

        public FormMuonTraSach()
        {
            InitializeComponent();
            preMuonTraSach.View = this;
            prePhieu.ViewLs = this;
            preSach.ViewLs = this;
            preTTSMT.ViewLs = this;
            preTrangThai.ViewLs = this;
            preNguoiSD.ViewLs = this;
            dataGridView_MuonTraSach.AutoGenerateColumns = false;
        }

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {
            prePhieu.ViewList();
            preSach.ViewList();
            preTTSMT.ViewList();
            preTrangThai.ViewList();
            preNguoiSD.ViewList();
            this.oldIndexOfRow = 0;
        }

        void IViewEntity<MuonSach>.viewEntity(MuonSach muonsach)
        {
            soTT = muonsach.soTT;
            maPhieu = muonsach.maPhieuSD;
            dateEdit_NgayMuon.EditValue = (DateTime)muonsach.ngayMuon;
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
            if (lookUpEdit_Sach.EditValue != null)
            {
                object thoihanmuon = preMuonTraSach.GetThoiHanMuonby_MaSach(lookUpEdit_Sach.EditValue.ToString());
                if (thoihanmuon != null)
                    ms.ngayDuKienTra = ms.ngayMuon.AddDays((Int32)thoihanmuon);
                else
                    ms.ngayDuKienTra = null;
            } 
            if (dateEdit_NgayTra.EditValue != null)
                ms.ngayTra = (DateTime)dateEdit_NgayTra.EditValue;
            if (textEdit_TienPhat.Text != null)
                if(textEdit_TienPhat.Text == "")
                    ms.tienPhat = null;
                else
                    ms.tienPhat = Int32.Parse(textEdit_TienPhat.Text);
            else
                ms.tienPhat = null;
            ms.nguoiChoMuon = QLTVMain.user.maNguoiSD;

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
            if (lookUpEdit_Sach.EditValue != null)
            {
                object thoihanmuon = preMuonTraSach.GetThoiHanMuonby_MaSach(lookUpEdit_Sach.EditValue.ToString());
                if (thoihanmuon != null)
                    ms.ngayDuKienTra = ms.ngayMuon.AddDays((Int32)thoihanmuon);
                else
                    ms.ngayDuKienTra = null;
            }
            if (dateEdit_NgayTra.EditValue != null)
                ms.ngayTra = (DateTime)dateEdit_NgayTra.EditValue;
            if (textEdit_TienPhat.Text != null)
                if (textEdit_TienPhat.Text == "")
                    ms.tienPhat = null;
                else
                    ms.tienPhat = Int32.Parse(textEdit_TienPhat.Text);
            else
                ms.tienPhat = null;
            ms.nguoiNhanSachTra = QLTVMain.user.maNguoiSD;

            return ms;
        }
        #endregion

        // ViewList Methods for LookUpEdit
        #region
        void IViewListEntity<PhieuSuDungSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_MaPhieu.Properties.DataSource = entities;
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

        void IViewListEntity<NguoiSuDung>.viewListEntity(BindingSource entities)
        {
            colNguoiChoMuon.DataSource = entities;
            colNguoiNhanSachTra.DataSource = entities;

            colNguoiChoMuon.DataPropertyName = "nguoiChoMuon";
            colNguoiChoMuon.ValueMember = "maNguoiSD";
            colNguoiChoMuon.DisplayMember = "tenNguoiSD";

            colNguoiNhanSachTra.DataPropertyName = "nguoiNhanSachTra";
            colNguoiNhanSachTra.ValueMember = "maNguoiSD";
            colNguoiNhanSachTra.DisplayMember = "tenNguoiSD";
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
            dateEdit_NgayTra.EditValue = null;
            textEdit_TienPhat.Text = "";
        }

        private void simpleButton_LocMaPhieu_Click(object sender, EventArgs e)
        {
            preMuonTraSach.maPhieuSD = textEdit_MaPhieu_forFilter.Text;
            lookUpEdit_TrangThai_forFilter.EditValue = null;
            preMuonTraSach.isButtonLocMaPhieuClicked = true;
            preMuonTraSach.isButtonLocTrangThaiClicked = false;
            preMuonTraSach.SetBindingSource();
            //preMuonTraSach.trangThai = null;
            if (preMuonTraSach.countForExit > 0) // value of text has already existed
            {
                ViewChiTietDocGiabyFilter();
                preMuonTraSach.ViewList();
            }
            else // value of text wrong or == ""
            {
                preMuonTraSach.ViewList();
                ViewChiTietDocGiabyFilter();
                ClearDatafromControl();
            }
        }

        private void simpleButton_LocTrangThai_Click(object sender, EventArgs e)
        {
            preMuonTraSach.maPhieuSD = textEdit_MaPhieu_forFilter.Text;
            if (lookUpEdit_TrangThai_forFilter.EditValue != null)
                preMuonTraSach.trangThai = (Int32)lookUpEdit_TrangThai_forFilter.EditValue;
            else
                preMuonTraSach.trangThai = 0;
            preMuonTraSach.isButtonLocMaPhieuClicked = false;
            preMuonTraSach.isButtonLocTrangThaiClicked = true;
            preMuonTraSach.SetBindingSource();
            //preMuonTraSach.trangThai = null;
            if (preMuonTraSach.countForExit > 0) // value of text has already existed
            {
                ViewChiTietDocGiabyFilter();
                preMuonTraSach.ViewList();
            }
            else // value of text wrong or == ""
            {
                ViewChiTietDocGiabyFilter();
                preMuonTraSach.ViewList();
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
                // check trangthai
                preMuonTraSach.oldMaPhieu = lookUpEdit_MaPhieu.EditValue.ToString();
                preMuonTraSach.updateEntity();
                preMuonTraSach.SetBindingSourceWhereMaPhieu(preMuonTraSach.oldMaPhieu);
                preMuonTraSach.ViewList();
            }
        }

        private void radioGroup_MuonTraSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_MuonTraSach.EditValue.Equals("Add"))
            {
                simpleButton_MuonTraSach.Text = "Thêm mượn trả sách";
                simpleButton_MuonTraSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                lookUpEdit_MaPhieu.ReadOnly = false;
                lookUpEdit_Sach.ReadOnly = false;
                lookUpEdit_TinhTrang.ReadOnly = false;
                lookUpEdit_TrangThai.ReadOnly = false;
                dateEdit_NgayMuon.ReadOnly = false;
                dateEdit_NgayTra.ReadOnly = false;
                textEdit_TienPhat.ReadOnly = false;
            }
            else if (radioGroup_MuonTraSach.EditValue.Equals("Delete"))
            {
                simpleButton_MuonTraSach.Text = "Xóa mượn trả sách";
                simpleButton_MuonTraSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                lookUpEdit_MaPhieu.ReadOnly = true;
                lookUpEdit_Sach.ReadOnly = true;
                lookUpEdit_TinhTrang.ReadOnly = true;
                lookUpEdit_TrangThai.ReadOnly = true;
                dateEdit_NgayMuon.ReadOnly = true;
                dateEdit_NgayTra.ReadOnly = true;
                textEdit_TienPhat.ReadOnly = true;
            }
            else if(radioGroup_MuonTraSach.EditValue.Equals("Update"))
            {
                simpleButton_MuonTraSach.Text = "Cập nhật mượn trả sách";
                simpleButton_MuonTraSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                lookUpEdit_MaPhieu.ReadOnly = true;
                lookUpEdit_Sach.ReadOnly = false;
                lookUpEdit_TinhTrang.ReadOnly = false;
                lookUpEdit_TrangThai.ReadOnly = false;
                dateEdit_NgayMuon.ReadOnly = false;
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