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

namespace LIBRARY_MANAGEMENT.CategoryList
{
    public partial class FormXacThucThoat : DevExpress.XtraEditors.XtraForm
    {
        public QLTVMain qltvMainForm = new QLTVMain();

        public FormXacThucThoat()
        {
            InitializeComponent();
        }

        private void simpleButton_CoThoat_Click(object sender, EventArgs e)
        {
            qltvMainForm.UpdateLogin();
            Application.Exit();
        }

        private void simpleButton_KhongThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}