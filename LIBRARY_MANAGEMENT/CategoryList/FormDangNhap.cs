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
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        #region // CRUD Methods
        public DangNhap AddNewEntity()
        {
            throw new NotImplementedException();
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

        public void viewEntity(DangNhap entity)
        {
            throw new NotImplementedException();
        }

        public void viewListEntity(BindingSource entities)
        {
            throw new NotImplementedException();
        }

    }
}