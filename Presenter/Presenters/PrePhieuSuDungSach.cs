﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PrePhieuSuDungSach : EntityPresenter<PhieuSuDungSach>
    {
        public Boolean checkMaPhieuIsBlank;

        public PrePhieuSuDungSach() : base()
        {
            base.entitySet = entitiesTV.PhieuSuDungSaches;
            base.bindingsource.DataSource = entitySet.ToList();
        }

        // check elements of EntitySet if there's been already existed element
        protected override PhieuSuDungSach getEntity(PhieuSuDungSach o)
        {
            PhieuSuDungSach phieu = null;
            if(o == null)
            {
                o = new PhieuSuDungSach();
                o.maPhieuSD = "";
                phieu = base.entitySet.FirstOrDefault(t => t.maPhieuSD == o.maPhieuSD);
            }
            else
                phieu = base.entitySet.FirstOrDefault(t => t.maPhieuSD == o.maPhieuSD);
            return phieu;
        }

        protected override void setNewInfo(PhieuSuDungSach newEntity, PhieuSuDungSach old)
        {
            old.hoTen = newEntity.hoTen;
            old.ngayThangNamSinh = newEntity.ngayThangNamSinh;
            old.gioiTinh = newEntity.gioiTinh;
            old.email = newEntity.email;
            old.soDT = newEntity.soDT;
            old.maLop = newEntity.maLop;
        }

        public PhieuSuDungSach GetEntityPhieuforFilterbyMaPhieu(string maphieu)
        {
            PhieuSuDungSach ph;
            ph = base.entitySet.FirstOrDefault(t => t.maPhieuSD == maphieu);
            return ph;
        }

        public PhieuSuDungSach getEntityByMaLop(int malop)
        {
            PhieuSuDungSach ph = null;
            ph = base.entitySet.FirstOrDefault(t => t.maLop == malop);
            return ph;
        }
    }
}
