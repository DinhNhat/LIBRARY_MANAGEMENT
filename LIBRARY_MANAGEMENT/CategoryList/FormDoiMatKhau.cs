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

        private Boolean CheckIsOldaPassword()
        {
            if (textEdit_OldPassword.Text != "") // user is typing...
            {
                if (QLTVMain.OldPassword == textEdit_OldPassword.Text) // old password was right !!!
                    return true;
                else
                    return false;
            }
            else // user leave it blank
                return false;
        }

        private void simpleButton_UpdatePassword_Click(object sender, EventArgs e)
        {
            // check new password again == new password Is??
            if(textEdit_NewPassword.Text != "")
            {
                if(textEdit_NewPasswordAgain.Text == textEdit_NewPassword.Text)
                {
                    labelControl_DoiMatKhau.ForeColor = Color.Blue;
                    labelControl_DoiMatKhau.Text = " Đổi mật khẩu thành công !!! ";
                    labelControl_DoiMatKhau.Update();
                    prengsd.updateEntity();
                }
                else
                {
                    labelControl_DoiMatKhau.ForeColor = Color.Red;
                    labelControl_DoiMatKhau.Text = " Mật khẩu mới không hợp lệ !!! Vui lòng nhập lại ";
                    labelControl_DoiMatKhau.Update();
                }
            }
            else
            {
                labelControl_DoiMatKhau.ForeColor = Color.Red;
                labelControl_DoiMatKhau.Text = " Mật khẩu mới không hợp lệ !!! Vui lòng nhập lại ";
                labelControl_DoiMatKhau.Update();
            }
        }

        private void simpleButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit_OldPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (CheckIsOldaPassword() == false)
            {
                labelControl_CheckOldPassword.ForeColor = Color.Red;
                labelControl_CheckOldPassword.Text = " Mật khẩu cũ không đúng!!! Vui lòng nhập lại. ";
                labelControl_CheckOldPassword.Update();
            }
            else
            {
                labelControl_CheckOldPassword.ForeColor = Color.Blue;
                labelControl_CheckOldPassword.Text = " Mật khẩu cũ đúng. ";
                labelControl_CheckOldPassword.Update();
            }
        }
    }
}