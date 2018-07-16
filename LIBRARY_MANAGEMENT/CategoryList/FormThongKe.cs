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
    public partial class FormThongKe : DevExpress.XtraEditors.XtraForm, IViewListEntity<View_ThongKeSach>
    {
        PreThongKeSach prethongke = new PreThongKeSach();
        int oldIndexOfRow;

        public FormThongKe()
        {
            InitializeComponent();
            prethongke.ViewLs = this;
            dataGridView_ThongKeSach.AutoGenerateColumns = false;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            prethongke.ViewList();
            this.oldIndexOfRow = 0;
        }

        void IViewListEntity<View_ThongKeSach>.viewListEntity(BindingSource bindingSource)
        {
            dataGridView_ThongKeSach.DataSource = bindingSource;
        }

        private void simpleButton_ThongKeSachMuon_Click(object sender, EventArgs e)
        {
            DateTime start = dateEdit_NgayBatDau.DateTime;
            DateTime end = dateEdit_NgayKetThuc.DateTime;
            prethongke.TKSachMuonByDate(start, end);
        }

        private void simpleButton_ThongKeSachDangMuon_Click(object sender, EventArgs e)
        {
            prethongke.TKSachDangMuon();
        }

        private void simpleButton_ThongKeSachKhongMuon_Click(object sender, EventArgs e)
        {
            DateTime start = dateEdit_NgayBatDau.DateTime;
            DateTime end = dateEdit_NgayKetThuc.DateTime;
            prethongke.TKSachKhongMuonByDate(start, end);
        }
    }
}