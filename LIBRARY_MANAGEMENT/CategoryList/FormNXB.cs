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
    public partial class FormNXB : DevExpress.XtraEditors.XtraForm, IViewEntity<NhaXuatBan>
    {
        PreNhaXuatBan preNXB = new PreNhaXuatBan();
        int maNXB;

        public FormNXB()
        {
            InitializeComponent();
            preNXB.View = this;
        }

        public NhaXuatBan AddNewEntity()
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.maNXB = preNXB.LastKey + 1;
            nxb.tenNXB = textEdit_NXB.Text;
            return nxb;
        }

        public NhaXuatBan DeleteEntity()
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.maNXB = maNXB;
            return nxb;
        }

        public NhaXuatBan UpdateEntity()
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.maNXB = maNXB;
            nxb.tenNXB = textEdit_NXB.Text;
            return nxb;
        }

        public void viewEntity(NhaXuatBan nxb)
        {
            textEdit_NXB.Text = nxb.tenNXB;
            maNXB = nxb.maNXB;
        }

        public void viewListEntity(BindingSource entities)
        {
            listBoxControl_NXB.DataSource = entities;
            listBoxControl_NXB.DisplayMember = "tenNXB";
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            preNXB.ListEntity();
        }

        private void listBoxControl_NXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxControl_NXB.SelectedIndex;
            preNXB.viewEntityAt(index);
        }

        private void simpleButton_NXB_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxControl_NXB.SelectedIndex;
            if (radioGroup_NXB.EditValue.Equals("Add"))
            {
                int num = preNXB.addNewEntity();
                if (num > 0)
                    listBoxControl_NXB.SelectedIndex = listBoxControl_NXB.ItemCount - 1;
            }
            else
                if (radioGroup_NXB.EditValue.Equals("Delete"))
            {
                int num = preNXB.deleteEntity();
                if (num > 0)
                    listBoxControl_NXB.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                preNXB.updateEntity();
                listBoxControl_NXB.SelectedIndex = selectedIndex;
            }
        }

        private void radioGroup_NXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_NXB.EditValue.Equals("Add"))
            {
                textEdit_NXB.ReadOnly = false;
                simpleButton_NXB.Text = "Thêm nhà xuất bản";
                this.simpleButton_NXB.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.addnewdatasource_32x32;
            }  
            else if (radioGroup_NXB.EditValue.Equals("Delete"))
            {
                textEdit_NXB.ReadOnly = true;
                simpleButton_NXB.Text = "Xóa nhà xuất bản";
                this.simpleButton_NXB.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.deletedatasource2_32x32;
            }
            else if (radioGroup_NXB.EditValue.Equals("Update"))
            {
                textEdit_NXB.ReadOnly = false;
                simpleButton_NXB.Text = "Sửa tên nhà xuất bản";
                this.simpleButton_NXB.Image = global::LIBRARY_MANAGEMENT.Properties.Resources.editdatasource_32x32;
            }
        }
    }
}