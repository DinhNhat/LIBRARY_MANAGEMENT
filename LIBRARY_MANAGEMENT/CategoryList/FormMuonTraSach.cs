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
    public partial class FormMuonTraSach : DevExpress.XtraEditors.XtraForm, IViewEntity<MuonSach>, IViewListEntity<Sach>, IViewListEntity<TinhTrangSachMuonTra>, IViewListEntity<TrangThai>
    {
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();
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
            preSach.ViewLs = this;
            preTTSMT.ViewLs = this;
            preTrangThai.ViewLs = this;
        }

        // CRUD Methods
        #region
        public MuonSach AddNewEntity()
        {
            throw new NotImplementedException();
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
            //dateEdit_NgayTra.EditValue = (DateTime)muonsach.ngayTra;
            textEdit_TienPhat.Text = muonsach.tienPhat.ToString();
            lookUpEdit_Sach.EditValue = muonsach.maSach;
            lookUpEdit_TinhTrang.EditValue = muonsach.maTinhTrangSach;
            lookUpEdit_TrangThai.EditValue = muonsach.maTrangThai;
        }

        void IViewListEntity<MuonSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_MuonTraSach.DataSource = entities;
        }

        // ViewList Methods for LookUpEdit
        #region
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

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {
            preMuonTraSach.ViewList();
            preSach.ViewList();
            preTTSMT.ViewList();
            preTrangThai.ViewList();
        }

        private void simpleButton_LocPhieu_Click(object sender, EventArgs e)
        {
            preMuonTraSach.maphieu = textEdit_MaPhieu.Text;
            preMuonTraSach.SetBindingSource();
            preMuonTraSach.ViewList();
        }

        private void dataGridView_MuonTraSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
                preMuonTraSach.viewEntityAt(rowIndex);
        }

    }
}