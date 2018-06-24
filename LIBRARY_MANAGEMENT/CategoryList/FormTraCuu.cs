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

        #region Implement LookUpEdit ViewListEntity
        //void IViewListEntity<NhaXuatBan>.viewListEntity(BindingSource entities)
        //{
        //    lookUpEdit_NXBTraCuu.Properties.DataSource = entities;
        //    colNhaXB.DataSource = entities;
        //    colNhaXB.DataPropertyName = "maNXB";
        //    colNhaXB.ValueMember = "maNXB";
        //    colNhaXB.DataPropertyName = "tenNXB";
        //}

        //void IViewListEntity<KhoSach>.viewListEntity(BindingSource entities)
        //{
        //    lookUpEdit_KhoSach.Properties.DataSource = entities;
        //    colKhoSach.DataSource = entities;
        //    colNhaXB.DataPropertyName = "maKhoSach";
        //    colNhaXB.ValueMember = "maKhoSach";
        //    colKhoSach.DataPropertyName = "tenKhoSach";
        //}

        //void IViewListEntity<TacGia>.viewListEntity(BindingSource entities)
        //{
        //    lookUpEdit_TenTacGiaTraCuu.Properties.DataSource = entities;
        //    colTacGia.DataSource = entities;
        //    colNhaXB.DataPropertyName = "maTacGia";
        //    colNhaXB.ValueMember = "maTacGia";
        //    colTacGia.DataPropertyName = "tenTacGia";
        //}

        //void IViewListEntity<LoaiSach>.viewListEntity(BindingSource entities)
        //{
        //    lookUpEdit_LoaiSachTraCuu.Properties.DataSource = entities;
        //    colLoaiSach.DataSource = entities;
        //    colNhaXB.DataPropertyName = "maLoaiSach";
        //    colNhaXB.ValueMember = "maLoaiSach";
        //    colLoaiSach.DataPropertyName = "tenLoaiSach";
        //}

        //void IViewEntity<TraCuu1>.viewEntity(TraCuu1 entity)
        //{
        //    throw new NotImplementedException();
        //}

        //TraCuu1 IViewEntity<TraCuu1>.AddNewEntity()
        //{
        //    throw new NotImplementedException();
        //}

        //TraCuu1 IViewEntity<TraCuu1>.DeleteEntity()
        //{
        //    throw new NotImplementedException();
        //}

        //TraCuu1 IViewEntity<TraCuu1>.UpdateEntity()
        //{
        //    throw new NotImplementedException();
        //}

        //void IViewListEntity<TraCuu1>.viewListEntity(BindingSource entities)
        //{
        //    dataGridView_SachTraCuu.DataSource = entities;
        //}
        #endregion

        private void simpleButton_TenSachTraCuu_Click(object sender, EventArgs e)
        {
            string tensach = textEdit_TenSachTraCuu.Text;
            pretracuu.FilterbyTenSach(tensach);
            pretracuu.ViewList();
        }

        
    }
}