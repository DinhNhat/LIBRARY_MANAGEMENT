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
    public partial class FormSach : DevExpress.XtraEditors.XtraForm, IViewEntity<Sach>, IViewListEntity<LoaiSach>, IViewListEntity<TacGia>, IViewListEntity<NhaXuatBan>, IViewListEntity<KhoSach>
    {
        PreSach preSach = new PreSach();
        PreLoaiSach preLoaiSach = new PreLoaiSach();
        PreTacGia preTacGia = new PreTacGia();
        PreNhaXuatBan preNXB = new PreNhaXuatBan();
        PreKhoSach preKhoSach = new PreKhoSach();
        string maSach;
        int rowIndex;
        int oldIndexOfRow;

        public FormSach()
        {
            InitializeComponent();
            preSach.View = this;
            preLoaiSach.ViewLs = this;
            preTacGia.ViewLs = this;
            preNXB.ViewLs = this;
            preKhoSach.ViewLs = this;
            dataGridView_Sach.AutoGenerateColumns = false;
        }

        void IViewEntity<Sach>.viewEntity(Sach sach)
        {
            maSach = sach.maSach;
            textEdit_MaSach.Text = sach.maSach;
            textEdit_TenSach.Text = sach.tenSach;
            textEdit_NamXB.Text = sach.namXB.ToString();
            textEdit_SoTrang.Text = sach.soTrang.ToString();
            textEdit_SoLuong.Text = sach.soLuong.ToString();
            textEdit_ThoiHanMuon.Text = sach.thoiHanMuon.ToString();
            textEdit_GiaTien.Text = sach.giaTien.ToString();
            lookUpEdit_TenLoaiSach.EditValue = sach.maLoaiSach;
            lookUpEdit_TenTacGia.EditValue = sach.maTacGia;
            lookUpEdit_TenNXB.EditValue = sach.maNXB;
            lookUpEdit_TenKhoSach.EditValue = sach.maKhoSach;
        }

        public Sach AddNewEntity()
        {
            if (textEdit_MaSach.Text != null && textEdit_MaSach.Text.Length > 0)
            {
                Sach sach = new Sach();
                //sach.maSach = preSach.LastKey + 1.ToString();
                sach.maSach = textEdit_MaSach.Text;
                sach.tenSach = textEdit_TenSach.Text;
                sach.namXB = Int32.Parse(textEdit_NamXB.Text);
                sach.soTrang = Int32.Parse(textEdit_SoTrang.Text);
                sach.soLuong = Int32.Parse(textEdit_SoLuong.Text);
                //sach.thoiHanMuon = Int32.Parse(textEdit_ThoiHanMuon.Text);
                if (textEdit_ThoiHanMuon.Text == "" || textEdit_ThoiHanMuon.Text == "0")
                    sach.thoiHanMuon = null;
                else
                    sach.thoiHanMuon = Int32.Parse(textEdit_ThoiHanMuon.Text);
                sach.giaTien = Int32.Parse(textEdit_GiaTien.Text);
                if (lookUpEdit_TenTacGia.EditValue != null)
                    sach.maTacGia = (int?)lookUpEdit_TenTacGia.EditValue;
                if (lookUpEdit_TenLoaiSach.EditValue != null)
                    sach.maLoaiSach = (string)lookUpEdit_TenLoaiSach.EditValue;
                if (lookUpEdit_TenNXB.EditValue != null)
                    sach.maNXB = (int?)lookUpEdit_TenNXB.EditValue;
                if (lookUpEdit_TenKhoSach.EditValue != null)
                    sach.maKhoSach = (int?)lookUpEdit_TenKhoSach.EditValue;
                return sach;
            }
            else
                return null; 
        }

        public Sach DeleteEntity()
        {
            Sach sach = new Sach();
            sach.maSach = maSach;
            return sach;
        }

        public Sach UpdateEntity()
        {
            Sach sach = new Sach();
            sach.maSach = maSach;
            sach.maSach = textEdit_MaSach.Text;
            sach.tenSach = textEdit_TenSach.Text;
            sach.namXB = Int32.Parse(textEdit_NamXB.Text);
            sach.soTrang = Int32.Parse(textEdit_SoTrang.Text);
            sach.soLuong = Int32.Parse(textEdit_SoLuong.Text);
            sach.thoiHanMuon = Int32.Parse(textEdit_ThoiHanMuon.Text);
            sach.giaTien = Int32.Parse(textEdit_GiaTien.Text);
            if (lookUpEdit_TenTacGia.EditValue != null)
                sach.maTacGia = (int?)lookUpEdit_TenTacGia.EditValue;
            if (lookUpEdit_TenLoaiSach.EditValue != null)
                sach.maLoaiSach = (string)lookUpEdit_TenLoaiSach.EditValue;
            if (lookUpEdit_TenNXB.EditValue != null)
                sach.maNXB = (int?)lookUpEdit_TenNXB.EditValue;
            if (lookUpEdit_TenKhoSach.EditValue != null)
                sach.maKhoSach = (int?)lookUpEdit_TenKhoSach.EditValue;
            return sach;
        }

        void IViewListEntity<Sach>.viewListEntity(BindingSource entities)
        {
            dataGridView_Sach.DataSource = entities;
        }

        // implement LookupEdits viewListEntity
        #region
        void IViewListEntity<LoaiSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenLoaiSach.Properties.DataSource = entities;
            colLoaiSach.DataSource = entities;
            colLoaiSach.DataPropertyName = "maLoaiSach";
            colLoaiSach.ValueMember = "maLoaiSach";
            colLoaiSach.DisplayMember = "tenLoaiSach";
        }

        void IViewListEntity<TacGia>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenTacGia.Properties.DataSource = entities;
            colTacGia.DataSource = entities;
            colTacGia.DataPropertyName = "maTacGia";
            colTacGia.ValueMember = "maTacGia";
            colTacGia.DisplayMember = "tenTacGia";
        }

        void IViewListEntity<NhaXuatBan>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenNXB.Properties.DataSource = entities;
            colNhaXB.DataSource = entities;
            colNhaXB.DataPropertyName = "maNXB";
            colNhaXB.ValueMember = "maNXB";
            colNhaXB.DisplayMember = "tenNXB";
        }

        void IViewListEntity<KhoSach>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenKhoSach.Properties.DataSource = entities;
            colKhoSach.DataSource = entities;
            colKhoSach.DataPropertyName = "maKhoSach";
            colKhoSach.ValueMember = "maKhoSach";
            colKhoSach.DisplayMember = "tenKhoSach";
        }
        #endregion

        private void FormSach_Load(object sender, EventArgs e)
        {
            preSach.ViewList();
            preLoaiSach.ViewList();
            preTacGia.ViewList();
            preNXB.ViewList();
            preKhoSach.ViewList();
            this.oldIndexOfRow = 0;
        }

        private void simpleButton_Sach_Click(object sender, EventArgs e)
        {
            if (radioGroup_Sach.EditValue.Equals("Add"))
                preSach.addNewEntity();
            else if (radioGroup_Sach.EditValue.Equals("Delete"))
                preSach.deleteEntity();
            else if (radioGroup_Sach.EditValue.Equals("Update"))
                preSach.updateEntity();
        }

        private void dataGridView_Sach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            //dataGridView_Sach.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
            preSach.viewEntityAt(rowIndex);

            //int indexRowofCell = e.RowIndex;
            //if (indexRowofCell == this.oldIndexofRow)
            //{
            //    this.oldIndexofRow = indexRowofCell;
            //    dataGridView_Sach.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
            //}
            //else
            //{
            //    dataGridView_Sach.Rows[this.oldIndexofRow].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
            //    dataGridView_Sach.CurrentRow.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
            //}

        }

        private void radioGroup_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_Sach.EditValue.Equals("Add"))
            {
                simpleButton_Sach.Text = "Thêm sách";
                simpleButton_Sach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_MaSach.ReadOnly = false;
                textEdit_TenSach.ReadOnly = false;
                textEdit_NamXB.ReadOnly = false;
                textEdit_SoTrang.ReadOnly = false;
                textEdit_SoLuong.ReadOnly = false;
                textEdit_ThoiHanMuon.ReadOnly = false;
                textEdit_GiaTien.ReadOnly = false ;
                lookUpEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenTacGia.ReadOnly = false;
                lookUpEdit_TenNXB.ReadOnly = false;
                lookUpEdit_TenKhoSach.ReadOnly = false;
            }
            else if(radioGroup_Sach.EditValue.Equals("Delete"))
            {
                simpleButton_Sach.Text = "Xóa sách";
                simpleButton_Sach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_MaSach.ReadOnly = true;
                textEdit_TenSach.ReadOnly = true;
                textEdit_NamXB.ReadOnly = true;
                textEdit_SoTrang.ReadOnly = true;
                textEdit_SoLuong.ReadOnly = true;
                textEdit_ThoiHanMuon.ReadOnly = true;
                textEdit_GiaTien.ReadOnly = true;
                lookUpEdit_TenLoaiSach.ReadOnly = true;
                lookUpEdit_TenTacGia.ReadOnly = true;
                lookUpEdit_TenNXB.ReadOnly = true;
                lookUpEdit_TenKhoSach.ReadOnly = true;
            }
            else if(radioGroup_Sach.EditValue.Equals("Update"))
            {
                simpleButton_Sach.Text = "Sửa thông tin sách";
                simpleButton_Sach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_MaSach.ReadOnly = true;
                textEdit_TenSach.ReadOnly = false;
                textEdit_NamXB.ReadOnly = false;
                textEdit_SoTrang.ReadOnly = false;
                textEdit_SoLuong.ReadOnly = false;
                textEdit_ThoiHanMuon.ReadOnly = false;
                textEdit_GiaTien.ReadOnly = false;
                lookUpEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenTacGia.ReadOnly = false;
                lookUpEdit_TenNXB.ReadOnly = false;
                lookUpEdit_TenKhoSach.ReadOnly = false;
            }
        }
    }
}