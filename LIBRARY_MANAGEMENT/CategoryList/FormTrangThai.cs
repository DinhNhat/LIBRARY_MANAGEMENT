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
    public partial class FormTrangThai : DevExpress.XtraEditors.XtraForm, IViewEntity<TrangThai>
    {
        PreTrangThai preTrangThai = new PreTrangThai();
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();
        int maTrangThai;
        Boolean lblErrHeThongCheck = false;

        public FormTrangThai()
        {
            InitializeComponent();
            preTrangThai.View = this;
        }

        public void viewEntity(TrangThai tt)
        {
            textEdit_TrangThai.Text = tt.tenTrangThai;
            maTrangThai = tt.maTrangThai;
        }

        public TrangThai AddNewEntity()
        {
            if(textEdit_TrangThai.Text != null && textEdit_TrangThai.Text.Length > 0)
            {
                TrangThai tt = new TrangThai();
                tt.maTrangThai = preTrangThai.LastKey + 1;
                tt.tenTrangThai = textEdit_TrangThai.Text;
                this.lblErrHeThongCheck = false;
                return tt;
            }
            else
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
        }

        public TrangThai DeleteEntity()
        {
            TrangThai tt = new TrangThai();
            tt.maTrangThai = maTrangThai;
            if (preMuonTraSach.GetEntityByMaTrangThai(tt.maTrangThai) != null)
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            else
            {
                tt.tenTrangThai = textEdit_TrangThai.Text;
                return tt;
            }
        }

        public TrangThai UpdateEntity()
        {
            TrangThai tt = new TrangThai();
            tt.maTrangThai = maTrangThai;
            tt.tenTrangThai = textEdit_TrangThai.Text;
            return tt;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_TrangThai.DataSource = entities;
            listBoxControl_TrangThai.DisplayMember = "tenTrangThai";
        }

        private void FormTrangThai_Load(object sender, EventArgs e)
        {
            preTrangThai.ListEntity();
        }

        private void listBoxControl_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_TrangThai.SelectedIndex;
            preTrangThai.viewEntityAt(index);
        }

        private void simpleButton_TrangThai_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_TrangThai.SelectedIndex;
            if (radioGroup_TrangThai.EditValue.Equals("Add"))
            {
                int num = preTrangThai.addNewEntity();
                if(num > 0)
                    listBoxControl_TrangThai.SelectedIndex = listBoxControl_TrangThai.ItemCount - 1;
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
            else if (radioGroup_TrangThai.EditValue.Equals("Delete"))
            {
                int num = preTrangThai.deleteEntity();
                if (num > 0)
                    listBoxControl_TrangThai.SelectedIndex = selectedIndex - 1;
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
            else
            {
                preTrangThai.updateEntity();
                listBoxControl_TrangThai.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_TrangThai.EditValue.Equals("Add"))
            {
                simpleButton_TrangThai.Text = "Thêm trạng thái";
                simpleButton_TrangThai.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_TrangThai.ReadOnly = false;
            }
            else if (radioGroup_TrangThai.EditValue.Equals("Delete"))
            {
                simpleButton_TrangThai.Text = "Xóa trạng thái";
                simpleButton_TrangThai.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_TrangThai.ReadOnly = true;
            }
            else if (radioGroup_TrangThai.EditValue.Equals("Update"))
            {
                simpleButton_TrangThai.Text = "Sửa tên trạng thái";
                simpleButton_TrangThai.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_TrangThai.ReadOnly = false;
            }    
        }
    }
}