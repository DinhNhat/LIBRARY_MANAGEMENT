using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreThongKeSach : EntityListPresenter<View_ThongKeSach>
    {
        // Constructor
        public PreThongKeSach() : base()
        {
            base.entitySet = entitiesTV.View_ThongKeSach;
        }


        public void TKSachMuonByDate(DateTime start, DateTime end)
        {
            var query = entitiesTV.View_ThongKeSach.Where(t => t.ngayMuon >= start && t.ngayMuon <= end).
                GroupBy(t => new
                { t.maSach, t.tenSach, t.soLuong, t.tenLoaiSach, t.tenNXB, t.namXB, t.tenTacGia }).
                Select(t => new {
                    t.Key.maSach, t.Key.tenSach, t.Key.soLuong, t.Key.tenLoaiSach, t.Key.tenNXB, t.Key.namXB, t.Key.tenTacGia,
                    soluotMuon = t.Select(x => x.maSach).Count(),
                    soLuongMat = t.Select(x => x.maTinhTrangSach).Count(p => p.Value == 1),
                    soTienPhat = t.Select(x => x.tienPhat).Sum()
                });
            bindingsource.DataSource = query.ToList();
        }

        public void TKSachDangMuon()
        {
            var query = entitiesTV.View_ThongKeSach.Where(t => t.maTrangThai == 1).
                GroupBy(t => new
                { t.maSach, t.tenSach, t.soLuong, t.tenLoaiSach, t.tenNXB, t.namXB, t.tenTacGia }).
                Select(t => new
                {
                    t.Key.maSach,
                    t.Key.tenSach,
                    t.Key.soLuong,
                    t.Key.tenLoaiSach,
                    t.Key.tenNXB,
                    t.Key.namXB,
                    t.Key.tenTacGia,
                    soLuotMuon = t.Select(x => x.maSach).Count(),
                    soLuongMat = 0,
                    soTienPhat = 0
                });
            bindingsource.DataSource = query.ToList();
        }

        public void TKSachKhongMuonByDate(DateTime start, DateTime end)
        {
            var query = entitiesTV.View_ThongKeSach.Where(t => t.ngayMuon == null || t.ngayMuon < start || t.ngayMuon > end).
                GroupBy(t => new
                {
                    maSach = t.maSach,
                    tenSach = t.tenSach,
                    soLuong = t.soLuong,
                    soLuotMuon = 0,
                    soLuongMat = 0,
                    soTienPhat = 0,
                    tenLoaiSach = t.tenLoaiSach,
                    tenNXB = t.tenNXB,
                    namXB = t.namXB,
                    tenTacGia = t.tenTacGia
                }).Select(t => new { t.Key.maSach, t.Key.tenSach, t.Key.soLuong, t.Key.soLuotMuon, t.Key.soLuongMat,
                    t.Key.soTienPhat, t.Key.tenLoaiSach, t.Key.tenNXB, t.Key.namXB, t.Key.tenTacGia});

            bindingsource.DataSource = query.ToList();
        }

    }
}
