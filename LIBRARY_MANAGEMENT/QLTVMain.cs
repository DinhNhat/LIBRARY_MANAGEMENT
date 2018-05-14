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
using LIBRARY_MANAGEMENT.CategoryList;

namespace LIBRARY_MANAGEMENT
{
    public partial class QLTVMain : DevExpress.XtraEditors.XtraForm
    {
        public QLTVMain()
        {
            InitializeComponent();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormViTriLuuTru vtlt = new FormViTriLuuTru();
            vtlt.Show();
        }
    }
}