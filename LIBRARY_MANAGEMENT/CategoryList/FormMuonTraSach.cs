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

            //if (textEdit_NguoiChoMuon.Text != null)
            //{
            //    if (textEdit_NguoiChoMuon.Text == "")
            //        ms.nguoiChoMuon = null;
            //    else
            //        ms.nguoiChoMuon = textEdit_NguoiChoMuon.Text;
            //}
            //else
            //    ms.nguoiChoMuon = null;

            //if (textEdit_NguoiNhanTraSach.Text != null)
            //{
            //    if (textEdit_NguoiNhanTraSach.Text == "")
            //        ms.nguoiNhanSachTra = null;
            //    else
            //        ms.nguoiNhanSachTra = textEdit_NguoiNhanTraSach.Text;
            //}
            //else
            //    ms.nguoiNhanSachTra = null;
            return ms;
        }

        public MuonSach DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public MuonSach UpdateEntity()
        {
            throw new NotImplementedException();
        }
        #endregion

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
            lookUpEdit_Sach.EditValue = muonsach.maSach;
            lookUpEdit_TinhTrang.EditValue = muonsach.maTinhTrangSach;
            lookUpEdit_TrangThai.EditValue = muonsach.maTrangThai;
        }

        void IViewListEntity<MuonSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_MuonTraSach.DataSource = entities;
        }

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {
            preMuonTraSach.ViewList();
            prePhieu.ViewList();
            preSach.ViewList();
            preTTSMT.ViewList();
            preTrangThai.ViewList();
        }

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

        // View Entity Phieu at maphieu by filtering
        void ViewPhieubyFilter()
        {
            //preMuonTraSach.maPhieuSD = maph;
            PhieuSuDungSach phieu = new PhieuSuDungSach();
            phieu = preMuonTraSach.GetEntityPhieuForFilter();
            textEdit_HoTen.Text = phieu.hoTen;
            textEdit_Lop.Text = preMuonTraSach.tenLop;
            dateEdit_NgayThangNamSinh.EditValue = phieu.ngayThangNamSinh;
            textEdit_Email.Text = phieu.email;
            textEdit_SoDT.Text = phieu.soDT;
        }

        private void simpleButton_LocPhieu_Click(object sender, EventArgs e)
        {
            preMuonTraSach.maPhieuSD = textEdit_MaPhieu.Text;
            ViewPhieubyFilter();
            preMuonTraSach.SetBindingSource();
            preMuonTraSach.ViewList();
        }

        private void dataGridView_MuonTraSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
                preMuonTraSach.viewEntityAt(rowIndex);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton_MuonTraSach_Click(object sender, EventArgs e)
        {
            if (radioGroup_MuonTraSach.EditValue.Equals("Add"))
            {
                preMuonTraSach.addNewEntity();
                rowIndex = dataGridView_MuonTraSach.DataBindings.Count - 1;
            }
        }
    }
}