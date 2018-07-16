using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreSach : EntityPresenter<Sach>
    {
        public PreSach() : base()
        {
            base.entitySet = entitiesTV.Saches;
            base.bindingsource.DataSource = entitySet.ToList();
        }

        protected override Sach getEntity(Sach o)
        {
            Sach sach = null;
            sach = base.entitySet.FirstOrDefault(t => t.maSach == o.maSach);
            return sach;
        }

        // for Update Method (assign all values from new entity to old entity)
        protected override void setNewInfo(Sach newEntity, Sach old)
        {
            old.maTacGia = newEntity.maTacGia;
            old.maLoaiSach = newEntity.maLoaiSach;
            old.maNXB = newEntity.maNXB;
            old.maKhoSach = newEntity.maKhoSach;
            old.tenSach = newEntity.tenSach;
            old.namXB = newEntity.namXB;
            old.soTrang = newEntity.soTrang;
            old.soLuong = newEntity.soLuong;
            old.thoiHanMuon = newEntity.thoiHanMuon;
            old.giaTien = newEntity.giaTien;
        }

        public Sach GetThoiHanMuonbyMaSach(string masach)
        {
            Sach sach = null;
            sach = base.entitySet.FirstOrDefault(t => t.maSach == masach);
            return sach;
        }

        public Sach getEntityByMaloaisach(string maloaisach)
        {
            Sach sach = null;
            sach = base.entitySet.FirstOrDefault(t => t.maLoaiSach == maloaisach);
            return sach;
        }
    }
}
