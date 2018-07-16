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
    public partial class FormTinhTrangSachMuonTra : DevExpress.XtraEditors.XtraForm, IViewEntity<TinhTrangSachMuonTra>
    {
        PreTinhTrangSachMuonTra preTinhTrangSachMuonTra = new PreTinhTrangSachMuonTra();
        PreMuonTraSach preMuonTraSach = new PreMuonTraSach();
        int maTinhTrangSach;
        Boolean lblErrHeThongCheck = false;

        public FormTinhTrangSachMuonTra()
        {
            InitializeComponent();
            preTinhTrangSachMuonTra.View = this;
        }

        public TinhTrangSachMuonTra AddNewEntity()
        {
            if (textEdit_TTSMT.Text != null && textEdit_TTSMT.Text.Length > 0)
            {
                TinhTrangSachMuonTra ttsmt = new TinhTrangSachMuonTra();
                ttsmt.maTinhTrangSach = preTinhTrangSachMuonTra.LastKey + 1;
                ttsmt.tenTinhTrangSach = textEdit_TTSMT.Text;
                this.lblErrHeThongCheck = false;
                return ttsmt;
            }
            else
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            
        }

        public TinhTrangSachMuonTra DeleteEntity()
        {
            TinhTrangSachMuonTra ttsmt = new TinhTrangSachMuonTra();
            ttsmt.maTinhTrangSach = maTinhTrangSach;
            if(preMuonTraSach.GetEntityByMaTinhTrangSach(ttsmt.maTinhTrangSach) != null)
            {
                this.lblErrHeThongCheck = true;
                return null;
            }
            else
            {
                ttsmt.tenTinhTrangSach = textEdit_TTSMT.Text;
                return ttsmt;
            }
        }

        public TinhTrangSachMuonTra UpdateEntity()
        {
            TinhTrangSachMuonTra ttsmt = new TinhTrangSachMuonTra();
            ttsmt.maTinhTrangSach = maTinhTrangSach;
            ttsmt.tenTinhTrangSach = textEdit_TTSMT.Text;
            return ttsmt;
        }

        public void viewEntity(TinhTrangSachMuonTra ttsmt)
        {
            textEdit_TTSMT.Text = ttsmt.tenTinhTrangSach;
            maTinhTrangSach = ttsmt.maTinhTrangSach;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_TTSMT.DataSource = entities;
            listBoxControl_TTSMT.DisplayMember = "tenTinhTrangSach";
        }

        private void FormTinhTrangSachMuonTra_Load(object sender, EventArgs e)
        {
            preTinhTrangSachMuonTra.ListEntity();
        }

        private void listBoxControl_TTSMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_TTSMT.SelectedIndex;
            preTinhTrangSachMuonTra.viewEntityAt(index);
        }

        private void simpleButton_TTSMT_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_TTSMT.SelectedIndex;
            if (radioGroup_TTSMT.EditValue.Equals("Add"))
            {
                int num = preTinhTrangSachMuonTra.addNewEntity();
                if (num > 0)
                    listBoxControl_TTSMT.SelectedIndex = listBoxControl_TTSMT.ItemCount - 1;
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
            else if (radioGroup_TTSMT.EditValue.Equals("Delete"))
            {
                int num = preTinhTrangSachMuonTra.deleteEntity();
                if (num > 0)
                    listBoxControl_TTSMT.SelectedIndex = selectedIndex - 1;
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
                preTinhTrangSachMuonTra.updateEntity();
                listBoxControl_TTSMT.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_TTSMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_TTSMT.EditValue.Equals("Add"))
            {
                simpleButton_TTSMT.Text = "Thêm tình trạng sách";
                simpleButton_TTSMT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
                textEdit_TTSMT.ReadOnly = false;
            }
                
            else if (radioGroup_TTSMT.EditValue.Equals("Delete"))
            {
                simpleButton_TTSMT.Text = "Xóa tình trạng sách";
                simpleButton_TTSMT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
                textEdit_TTSMT.ReadOnly = true;
            }
                
            else if (radioGroup_TTSMT.EditValue.Equals("Update"))
            {
                simpleButton_TTSMT.Text = "Sửa tên tình trạng sách";
                simpleButton_TTSMT.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
                textEdit_TTSMT.ReadOnly = false;
            }
        }
    }
}