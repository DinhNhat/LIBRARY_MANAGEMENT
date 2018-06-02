using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Presenter.Presenters
{
    public class PreMuonTraSach : EntityPresenter<MuonSach>
    {
        public string maPhieuSD;
        public string tenLop;
        PrePhieuSuDungSach prePhieu = new PrePhieuSuDungSach();
        PreLop lop = new PreLop();
        public PreMuonTraSach() : base()
        {
            base.entitySet = entitiesTV.MuonSaches;
            //base.bindingsource.DataSource = entitySet.ToList();
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.soTT);
        }

        protected override MuonSach getEntity(MuonSach o)
        {
            MuonSach muonsach = null;
            muonsach = base.entitySet.FirstOrDefault(t => t.soTT == o.soTT && t.maPhieuSD == o.maPhieuSD);
            return muonsach;
        }

        protected override void setNewInfo(MuonSach newEntity, MuonSach old)
        {
            old.ngayMuon = newEntity.ngayMuon;
            old.ngayDuKienTra = newEntity.ngayDuKienTra;
            old.ngayTra = newEntity.ngayTra;
            old.tienPhat = newEntity.tienPhat;
            old.nguoiChoMuon = newEntity.nguoiChoMuon;
            old.nguoiNhanSachTra = newEntity.nguoiNhanSachTra;
        }

        // filter entity by maPhieuSD
        public void getChiTietbyPhieuSD(string maphieu)
        {
            base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maPhieuSD == maphieu).ToList();
        }

        public void SetBindingSource()
        {
            getChiTietbyPhieuSD(this.maPhieuSD);
        }

        public PhieuSuDungSach GetEntityPhieuForFilter()
        {
            PhieuSuDungSach ph = new PhieuSuDungSach();
            ph = prePhieu.GetPhieuforFilterbyMaPhieu(maPhieuSD);
            tenLop = lop.GetLopforFilter((Int32)ph.maLop);
            return ph;
        }

    }
}
