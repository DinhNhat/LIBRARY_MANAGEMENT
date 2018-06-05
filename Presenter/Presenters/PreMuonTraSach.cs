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
        public Object trangThai;
        public string tenLop;
        private int countForBindingsource;
        public string oldMaPhieu;

        public int CountForBindingSource { get { return this.countForBindingsource; } }

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
            old.maSach = newEntity.maSach;
            old.maTinhTrangSach = newEntity.maTinhTrangSach;
            old.maTrangThai = newEntity.maTrangThai;
            old.ngayMuon = newEntity.ngayMuon;
            old.ngayDuKienTra = newEntity.ngayDuKienTra;
            old.ngayTra = newEntity.ngayTra;
            old.tienPhat = newEntity.tienPhat;
        }

        public Boolean SetBindingSourceAgainforDelete()
        {
            if(base.countBindingSourcePresenter > 0) // context: there's more than an item in entitySet
            {
                MuonSach ms = null;
                ms = base.entitySet.FirstOrDefault(m => m.maPhieuSD == this.oldMaPhieu);
                if (ms != null) // oldMaPhieu still exists
                {
                    base.bindingsource.DataSource = base.entitySet.Where(m => m.maPhieuSD == this.oldMaPhieu).ToList();
                    return true;
                }
                else // oldMaPhieu has been gone
                {
                    this.oldMaPhieu = "";
                    base.bindingsource.DataSource = base.entitySet.Where(m => m.maPhieuSD == this.oldMaPhieu).ToList();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void SetBindingSourceWhereMaPhieu(string maToSet)
        {
            // oldMaPhieu already exits

            base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maPhieuSD == maToSet).ToList();
        }

        private void SetBindingSourceWhereTrangThai(int maToSet)
        {
            base.bindingsource.DataSource = base.entitySet.Where(ms => ms.maTrangThai == maToSet).ToList();
        }

        private int SetFilterMode(string maphieu, Object matrangthai)
        {
            // for button LocMaPhieu
            if (maphieu != "" && matrangthai == null)
                return 1; // true
            else if (maphieu == "" && matrangthai == null)
                return 2; // false

            // for button LocTrangThai
            else if (maphieu == "" && matrangthai != null)
                return 3; // true
            else // if (maphieu == "" && matrangthai == null)
                return 4; // false
        }

        // filter entity by maPhieuSD
        public Boolean getChiTietbyPhieuSD(string maphieu, Object trangthai)
        {
            Boolean boolean = true;
            int mode = SetFilterMode(maphieu, trangthai);

            #region
            switch(mode)
            {
                case 1:
                    {
                        SetBindingSourceWhereMaPhieu(maphieu);
                        this.countForBindingsource = base.bindingsource.Count;
                        break;
                    }
                case 2:
                    {
                        SetBindingSourceWhereMaPhieu(maphieu);
                        this.countForBindingsource = base.bindingsource.Count;
                        boolean = false;
                        break;
                    }
                case 3:
                    {
                        int tt = (Int32)trangthai;
                        SetBindingSourceWhereTrangThai(tt);
                        this.countForBindingsource = base.bindingsource.Count;
                        break;
                    }
                case 4:
                    {
                        SetBindingSourceWhereMaPhieu(maphieu);
                        this.countForBindingsource = base.bindingsource.Count;
                        boolean = false;
                        break;
                    }
               
            }
            #endregion
            return boolean;
        }

        public Boolean SetBindingSource()
        {
            return getChiTietbyPhieuSD(this.maPhieuSD, this.trangThai);
        }

        public void CheckCountPresenterforBindingSource()
        {
            if(base.countBindingSourcePresenter == 0)
                SetBindingSourceWhereMaPhieu(oldMaPhieu);
            else
                SetBindingSourceWhereMaPhieu(oldMaPhieu);
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
