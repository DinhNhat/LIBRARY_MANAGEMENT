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
using System.Threading;
using View;
using Presenter.Presenters;
using Presenter;

namespace LIBRARY_MANAGEMENT.CategoryList
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm, IViewEntity<DangNhap>
    {
        PreDangNhap preDangNhap = new PreDangNhap();
        QLTVMain formMain;
        int maDangNhap;

        public FormDangNhap()
        {
            InitializeComponent();
            preDangNhap.View = this;
        }

        #region Methods inherit from IViewEntityDangNhap
        public DangNhap AddNewEntity()
        {
            DangNhap dn = new DangNhap();
            dn.maDangNhap = preDangNhap.LastKey + 1;
            dn.thoiGianDangNhap = DateTime.Now;
            dn.maNguoiSD = preDangNhap.CheckIskUser().maNguoiSD; // get maNguoiSD
            this.maDangNhap = dn.maDangNhap;
            return dn;
        }

        public DangNhap DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public DangNhap UpdateEntity()
        {
            throw new NotImplementedException();
        }

        public void viewEntity(DangNhap entity)
        {
            throw new NotImplementedException();
        }

        public void viewListEntity(BindingSource entities)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void simpleButton_DangNhap_Click(object sender, EventArgs e)
        {
            preDangNhap.nguoiSuDung.tenNguoiSD = textEdit_TenUser.Text;
            preDangNhap.nguoiSuDung.password = textEdit_Password.Text;
            labelControl_Error.ForeColor = Color.Blue;
            labelControl_Error.Text = " Đang đăng nhập .... ";
            labelControl_Error.Update();

            try
            {
                if (preDangNhap.CheckIskUser() != null) // user has already exist
                {
                    int num = preDangNhap.addNewEntity();
                    if (num > 0)
                    {
                        // after adding DangNhap successfully and SaveChange is so then assign maDangNhap to user in QLTVMainForm
                        QLTVMain.login.maDangNhap = this.maDangNhap;
                        QLTVMain.user = preDangNhap.CheckIskUser();
                        QLTVMain.SetOldPasswordforUser();
                        preDangNhap.isDangNhap = true;
                        this.Close();
                    }
                    // Login successfully
                }
                else // Invalid Input
                {
                    labelControl_Error.ForeColor = Color.Red;
                    labelControl_Error.Text = " Thông tin đăng nhập không đúng !!! Vui lòng nhập lại. ";
                }
            }
            catch
            {
                labelControl_Error.ForeColor = Color.Red;
                labelControl_Error.Text = " Thông tin đăng nhập không đúng !!! Vui lòng nhập lại. ";
            }
            
        }

        private void simpleButton_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (preDangNhap.isDangNhap == true)
            {
                formMain = new QLTVMain();
                QLTVMain.SetOldPasswordforUser();
                //System.Threading.Thread.Sleep(4000);
                this.Dispose();
            }
            else
                Application.Exit();
        }

        private void simpleButton_Clear_Click(object sender, EventArgs e)
        {
            textEdit_TenUser.Text = "";
            textEdit_Password.Text = "";
        }

        
    }
}