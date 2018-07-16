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
    public partial class FormLoaiSach : DevExpress.XtraEditors.XtraForm, IViewEntity<LoaiSach>, IViewListEntity<ViTriLuuTru>
    {
        PreLoaiSach preLoaiSach = new PreLoaiSach();
        PreViTriLuuTru preVTLT = new PreViTriLuuTru();
        PreSach preSach = new PreSach();

        string maLoaiSach;
        int rowIndex;
        Boolean lblErrHeThongCheck = false;

        public FormLoaiSach()
        {
            InitializeComponent();
            preLoaiSach.View = this;
            preVTLT.ViewLs = this;
            dataGridView_LoaiSach.AutoGenerateColumns = false;
        }

        void IViewEntity<LoaiSach>.viewEntity(LoaiSach ls)
        {
            maLoaiSach = ls.maLoaiSach;
            textEdit_MaLoaiSach.Text = ls.maLoaiSach;
            textEdit_TenLoaiSach.Text = ls.tenLoaiSach;
            lookUpEdit_TenVTLT.EditValue = ls.maViTriLuuTru;
        }

        public LoaiSach AddNewEntity()
        {
            if (textEdit_MaLoaiSach.Text != null && textEdit_MaLoaiSach.Text.Length > 0)
            {
                LoaiSach ls = new LoaiSach();
                ls.maLoaiSach = textEdit_MaLoaiSach.Text;
                ls.tenLoaiSach = textEdit_TenLoaiSach.Text;
                if (lookUpEdit_TenVTLT.EditValue != null)
                    ls.maViTriLuuTru = (int?)lookUpEdit_TenVTLT.EditValue;
                this.lblErrHeThongCheck = false;
                return ls;
            }
            else
            {
                this.lblErrHeThongCheck = true;
                return null;
            } 
        }

        public LoaiSach DeleteEntity()
        {
            LoaiSach ls = new LoaiSach();
            ls.maLoaiSach = maLoaiSach;
            if (preSach.getEntityByMaloaisach(ls.maLoaiSach) != null)
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            else
                return ls;
        }

        public LoaiSach UpdateEntity()
        {
            LoaiSach ls = new LoaiSach();
            ls.maLoaiSach = maLoaiSach;
            ls.maLoaiSach = textEdit_MaLoaiSach.Text;
            ls.tenLoaiSach = textEdit_TenLoaiSach.Text;
            if (lookUpEdit_TenVTLT.EditValue != null)
                ls.maViTriLuuTru = (int?)lookUpEdit_TenVTLT.EditValue;
            return ls;
        }

        private void FormLoaiSach_Load(object sender, EventArgs e)
        {
            preLoaiSach.ViewList();
            preVTLT.ViewList();
        }

        void IViewListEntity<LoaiSach>.viewListEntity(BindingSource entities)
        {
            dataGridView_LoaiSach.DataSource = entities;
        }

        void IViewListEntity<ViTriLuuTru>.viewListEntity(BindingSource entities)
        {
            lookUpEdit_TenVTLT.Properties.DataSource = entities;
            colVTLT.DataSource = entities;
            colVTLT.DataPropertyName = "maViTriLuuTru";
            colVTLT.ValueMember = "maViTriLuuTru";
            colVTLT.DisplayMember = "tenViTriLuuTru";
        }

        private void simpleButton_LoaiSach_Click(object sender, EventArgs e)
        {
            if (radioGroup_LoaiSach.EditValue.Equals("Add"))
            {
                preLoaiSach.addNewEntity();
                rowIndex = dataGridView_LoaiSach.DataBindings.Count - 1;
                if(this.lblErrHeThongCheck == true)
                {
                    labelControl_ErrorheThong.ForeColor = Color.Red;
                    labelControl_ErrorheThong.Text = "Lỗi hệ thống !!! Thêm không thành công.";
                    labelControl_ErrorheThong.Update();
                    this.lblErrHeThongCheck = false;
                }
                else
                {
                    labelControl_ErrorheThong.ForeColor = Color.Blue;
                    labelControl_ErrorheThong.Text = "Thêm thành công.";
                    labelControl_ErrorheThong.Update();
                }
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Delete"))
            {
                preLoaiSach.deleteEntity();
                if (this.lblErrHeThongCheck == true)
                {
                    labelControl_ErrorheThong.ForeColor = Color.Red;
                    labelControl_ErrorheThong.Text = "Lỗi hệ thống !!! Xóa không thành công.";
                    labelControl_ErrorheThong.Update();
                    this.lblErrHeThongCheck = false;
                }
                else
                {
                    labelControl_ErrorheThong.ForeColor = Color.Blue;
                    labelControl_ErrorheThong.Text = "Xóa thành công.";
                    labelControl_ErrorheThong.Update();
                }
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Update"))
                preLoaiSach.updateEntity();
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            preLoaiSach.viewEntityAt(rowIndex);
        }

        // Event SelectedIndexChanged for RadioGroup
        private void radioGroup_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_LoaiSach.EditValue.Equals("Add"))
            {
                simpleButton_LoaiSach.Text = "Thêm loại sách";
                simpleButton_LoaiSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_MaLoaiSach.ReadOnly = false;
                textEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenVTLT.ReadOnly = false;
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Delete"))
            {
                simpleButton_LoaiSach.Text = "Xóa loại sách";
                simpleButton_LoaiSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_MaLoaiSach.ReadOnly = true;
                textEdit_TenLoaiSach.ReadOnly = true;
                lookUpEdit_TenVTLT.ReadOnly = true;
            }
            else if (radioGroup_LoaiSach.EditValue.Equals("Update"))
            {
                simpleButton_LoaiSach.Text = "Sửa tên loại sách";
                simpleButton_LoaiSach.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_MaLoaiSach.ReadOnly = true;
                textEdit_TenLoaiSach.ReadOnly = false;
                lookUpEdit_TenVTLT.ReadOnly = false;
            }
        }

        //private void dataGridView_LoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //if (this.oldIndexOfRow == e.RowIndex)
        //    //    dataGridView_LoaiSach.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
        //    //else
        //    //{
        //    //    // oldIndexOfRow out of range

        //    //    dataGridView_LoaiSach.Rows[this.oldIndexOfRow].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
        //    //    this.oldIndexOfRow = e.RowIndex;
        //    //    dataGridView_LoaiSach.CurrentRow.DefaultCellStyle.BackColor = Color.Salmon;
        //    //}
        //}
    }
}