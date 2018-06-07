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
using DevExpress.XtraEditors.DXErrorProvider;
using View;
using Presenter.Presenters;
using Presenter;

namespace LIBRARY_MANAGEMENT.CategoryList
{
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm, IViewEntity<NguoiSuDung>
    {
        PreNguoiSD prengsd = new PreNguoiSD();
        string _oldPassforValidate = QLTVMain.OldPassword;

        public FormDoiMatKhau()
        {
            InitializeComponent();
            prengsd.View = this;
        }

        // Inherit from NguoiSD_IViewEntity
        #region
        public NguoiSuDung AddNewEntity()
        {
            throw new NotImplementedException();
        }

        public NguoiSuDung DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public NguoiSuDung UpdateEntity()
        {
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd.maNguoiSD = QLTVMain.user.maNguoiSD;
            ngsd.tenNguoiSD = QLTVMain.user.tenNguoiSD;
            ngsd.password = textEdit_NewPassword.Text;
            ngsd.admin = QLTVMain.user.admin;
            ngsd.enable = QLTVMain.user.enable;
            return ngsd;
        }

        public void viewEntity(NguoiSuDung entity)
        {
            throw new NotImplementedException();
        }

        public void viewListEntity(BindingSource entities)
        {
            throw new NotImplementedException();
        }

        #endregion



        private void simpleButton_UpdatePassword_Click(object sender, EventArgs e)
        {
            prengsd.updateEntity();
        }

        private void simpleButton_Clear_Click(object sender, EventArgs e)
        {
            textEdit_OldPassword.Text = "";
            textEdit_NewPassword.Text = "";
            textEdit_NewPasswordAgain.Text = "";
        }

        private void simpleButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}