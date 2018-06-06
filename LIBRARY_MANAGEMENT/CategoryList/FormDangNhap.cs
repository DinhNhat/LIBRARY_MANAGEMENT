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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm, IViewEntity<DangNhap>
    {
        PreDangNhap preDangNhap = new PreDangNhap();
        int maDangNhap;

        public FormDangNhap()
        {
            InitializeComponent();
            preDangNhap.View = this;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        #region CRUD Methods
        public DangNhap AddNewEntity()
        {
            DangNhap dn = new DangNhap();
            dn.maDangNhap = preDangNhap.LastKey + 1;
            dn.thoiGianDangNhap = DateTime.Now;
            dn.maNguoiSD = preDangNhap.GetIdUser();
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
        #endregion

        #region Methods inherit from IViewEntity - ViewEntity and ViewListEntity
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
            if(preDangNhap.CheckIskUser() == true)
            {
                preDangNhap.isDangNhap = true;
                int num = preDangNhap.addNewEntity();
                if (num > 0)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Error!!!!!!!!!!!");
            }
            else
            {
                labelControl_Error.Text = "Thông tin đăng nhập không đúng! Vui lòng nhập lại.";
            }
            
        }

        private void simpleButton_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (preDangNhap.isDangNhap == true)
                this.Dispose();
            else
                Application.Exit();
        }
    }
}