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
    public partial class FormTraCuu : DevExpress.XtraEditors.XtraForm, IViewEntity<View_Sach>, IViewListEntity<LoaiSach>, IViewListEntity<TacGia>, IViewListEntity<NhaXuatBan>, IViewListEntity<KhoSach>
    {
        PreTraCuu pretracuu = new PreTraCuu();
        PreLoaiSach preloaisach = new PreLoaiSach();
        PreTacGia pretacgia = new PreTacGia();
        PreNhaXuatBan prenhaxuatban = new PreNhaXuatBan();
        PreKhoSach prekhosach = new PreKhoSach();

        int oldIndexOfRow;

        public FormTraCuu()
        {
            InitializeComponent();
            pretracuu.View = this;
            preloaisach.ViewLs = this;
            pretacgia.ViewLs = this;
            prenhaxuatban.ViewLs = this;
            prekhosach.ViewLs = this;
            dataGridView_SachTraCuu.AutoGenerateColumns = false;
        }

        private void FormTraCuu_Load(object sender, EventArgs e)
        {
            preloaisach.ViewList();
            pretacgia.ViewList();
            prenhaxuatban.ViewList();
            prekhosach.ViewList();
            this.oldIndexOfRow = 0;
        }

        #region CRUD Methods
        void IViewEntity<View_Sach>.viewEntity(View_Sach entity)
        {
            throw new NotImplementedException();
        }

        View_Sach IViewEntity<View_Sach>.AddNewEntity()
        {
            throw new NotImplementedException();
        }

        View_Sach IViewEntity<View_Sach>.DeleteEntity()
        {
            throw new NotImplementedException();
        }

        View_Sach IViewEntity<View_Sach>.UpdateEntity()
        {
            throw new NotImplementedException();
        }

        void IViewListEntity<View_Sach>.viewListEntity(BindingSource entities)
        {
            dataGridView_SachTraCuu.DataSource = entities;
        }
        #endregion

        void IViewListEntity<LoaiSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_LoaiSachTraCuu.Properties.DataSource = entities;
        }

        void IViewListEntity<TacGia>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TacGiaTraCuu.Properties.DataSource = entities;
        }

        void IViewListEntity<NhaXuatBan>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_NXBTraCuu.Properties.DataSource = entities;
        }

        void IViewListEntity<KhoSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_KhoSachTraCuu.Properties.DataSource = entities;
        }

        #region Classification by Searching
        private void simpleButton_TenSachTraCuu_Click(object sender, EventArgs e)
        {
            string tensach = textEdit_TenSachTraCuu.Text;
            pretracuu.FilterbyTenSach(tensach);
            pretracuu.ViewList();
            lookUpEdit_LoaiSachTraCuu.EditValue = null;
            lookUpEdit_KhoSachTraCuu.EditValue = null;
            lookUpEdit_NXBTraCuu.EditValue = null;
            lookUpEdit_TacGiaTraCuu.EditValue = null;
        }

        private void simpleButton_TenTacGiaTraCuu_Click(object sender, EventArgs e)
        {
            int matacgia = (Int32)lookUpEdit_TacGiaTraCuu.EditValue;
            pretracuu.FilterbyMaTacGia(matacgia);
            pretracuu.ViewList();
            textEdit_TenSachTraCuu.Text = "";
            lookUpEdit_KhoSachTraCuu.EditValue = null;
            lookUpEdit_LoaiSachTraCuu.EditValue = null;
            lookUpEdit_NXBTraCuu.EditValue = null;
        }

        private void simpleButton_LoaiSachTraCuu_Click(object sender, EventArgs e)
        {
            string maloaisach = lookUpEdit_LoaiSachTraCuu.EditValue.ToString();
            pretracuu.FilterbyMaLoaiSach(maloaisach);
            pretracuu.ViewList();
            textEdit_TenSachTraCuu.Text = "";
            lookUpEdit_KhoSachTraCuu.EditValue = null;
            lookUpEdit_NXBTraCuu.EditValue = null;
            lookUpEdit_TacGiaTraCuu.EditValue = null;
        }

        private void simpleButton_TraCuuNXB_Click(object sender, EventArgs e)
        {
            int manxb = (Int32)lookUpEdit_NXBTraCuu.EditValue;
            pretracuu.FilterbyMaNXB(manxb);
            pretracuu.ViewList();
            textEdit_TenSachTraCuu.Text = "";
            lookUpEdit_KhoSachTraCuu.EditValue = null;
            lookUpEdit_LoaiSachTraCuu.EditValue = null;
            lookUpEdit_TacGiaTraCuu.EditValue = null;
        }

        private void simpleButton_TraCuuKhoSach_Click(object sender, EventArgs e)
        {
            int makhosach = (Int32)lookUpEdit_KhoSachTraCuu.EditValue;
            pretracuu.FilterbyMaKhoSach(makhosach);
            pretracuu.ViewList();
            textEdit_TenSachTraCuu.Text = "";
            lookUpEdit_LoaiSachTraCuu.EditValue = null;
            lookUpEdit_NXBTraCuu.EditValue = null;
            lookUpEdit_TacGiaTraCuu.EditValue = null;
        }
        #endregion
    }
}