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
using Presenter;

namespace LIBRARY_MANAGEMENT
{
    public partial class QLTVMain : DevExpress.XtraEditors.XtraForm
    {
        public NguoiSuDung user = new NguoiSuDung();
        public QLTVMain()
        {
            InitializeComponent();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLop lop = new FormLop();
            lop.Show();
        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNamHoc nh = new FormNamHoc();
            nh.Show();
        }

        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPhieuSuDungSach phieu = new FormPhieuSuDungSach();
            phieu.Show();
        }

        private void barStaticItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSach sach = new FormSach();
            sach.Show();
        }

        private void barStaticItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTrangThai tt = new FormTrangThai();
            tt.Show();
        }

        private void barStaticItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTinhTrangSachMuonTra ttsmt = new FormTinhTrangSachMuonTra();
            ttsmt.Show();
        }

        private void barStaticItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLoaiSach ls = new FormLoaiSach();
            ls.Show();
        }

        private void barStaticItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNXB nxb = new FormNXB();
            nxb.Show();
        }

        private void barStaticItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTacGia tg = new FormTacGia();
            tg.Show();
        }

        private void barStaticItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormViTriLuuTru vtlt = new FormViTriLuuTru();
            vtlt.Show();
        }

        private void barStaticItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormKhoSach ks = new FormKhoSach();
            ks.Show();
        }
    }
}