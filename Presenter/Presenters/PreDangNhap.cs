using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreDangNhap : EntityPresenter<DangNhap>
    {
        public NguoiSuDung nguoiSuDung = new NguoiSuDung();
        public Boolean isDangNhap = false;

        public PreDangNhap() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.DangNhaps; // DangNhaps from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0) // get element with the max key(the maximum maKhoSach)
                maxKey = (int)base.entitySet.Max(t => t.maDangNhap);
        }

        protected override DangNhap getEntity(DangNhap o)
        {
            DangNhap dn = null;
            dn = base.entitySet.FirstOrDefault(t => t.maDangNhap == o.maDangNhap);
            return dn;
        }

        protected override void setNewInfo(DangNhap newEntity, DangNhap old)
        {
            old.thoiGianThoat = newEntity.thoiGianThoat;
        }

        // check for Nguoisd true or false
        public NguoiSuDung CheckIskUser()
        {
            PreNguoiSD prengsd = new PreNguoiSD();
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd = prengsd.CheckUser(nguoiSuDung);
            return ngsd;
        }

    }
}
