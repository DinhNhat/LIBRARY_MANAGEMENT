using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreDangNhap : EntityPresenter<DangNhap>
    {
        public string maNguoiSuDung;
        public string tenNguoiSuDung;
        public PreNguoiSD nguoiSuDung = new PreNguoiSD();
        public Boolean isDangNhap;

        protected override DangNhap getEntity(DangNhap o)
        {
            throw new NotImplementedException();
        }

        protected override void setNewInfo(DangNhap newEntity, DangNhap old)
        {
            throw new NotImplementedException();
        }

        // check for Nguoisd true or false
        public NguoiSuDung CheckIskNguoiSuDung()
        {
            NguoiSuDung ng = null;
            ng = nguoiSuDung.CheckUser(this.maNguoiSuDung, this.tenNguoiSuDung);
            return ng;
        }

    }
}
