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
        public Object maPhieuSD;
        public Object trangThai;
        public string tenLop;
        PrePhieuSuDungSach prePhieu = new PrePhieuSuDungSach();
        PreLop lop = new PreLop();
        PreTrangThai trangthai = new PreTrangThai();
        public PreMuonTraSach() : base()
        {
            base.entitySet = entitiesTV.MuonSaches;
            base.bindingsource.DataSource = entitySet.ToList();
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
        public Boolean getChiTietbyPhieuSD(Object maphieu, Object trangthai)
        {
            if (maphieu != null && trangthai == null)
            {
                string maphieu1 = maphieu.ToString();
                base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maPhieuSD == maphieu1).ToList();
                return true;
            }
            else if(maphieu != null && trangthai != null)
            {
                string maphieu1 = maphieu.ToString();
                int matt = (Int32)trangthai;
                base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maPhieuSD == maphieu1 && ms.maTrangThai == matt).ToList();
                return true;
            }
            else if(maphieu == null && trangthai != null)
            {
                int matt = (Int32)trangthai;
                base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maTrangThai == matt).ToList();
                return false;
            }
            else
            {
                base.bindingsource.DataSource = null;
                return false;
            }
        }

        public Boolean SetBindingSource()
        {
            return getChiTietbyPhieuSD(this.maPhieuSD, this.trangThai);
        }

        public PhieuSuDungSach GetEntityPhieuForFilter()
        {
            PhieuSuDungSach ph;
            ph = prePhieu.GetEntityPhieuforFilterbyMaPhieu(this.maPhieuSD);
            if(ph != null)
                tenLop = lop.GetTenLopforFilter((Int32)ph.maLop);
            return ph;
        }

    }
}
