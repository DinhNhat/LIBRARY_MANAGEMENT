using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreNguoiSD : EntityPresenter<NguoiSuDung>
    {
        public PreNguoiSD() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.NguoiSuDungs; // NamHocs from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override NguoiSuDung getEntity(NguoiSuDung o)
        {
            NguoiSuDung ngsd = null;
            ngsd = base.entitySet.FirstOrDefault(t => t.maNguoiSD == o.maNguoiSD || t.tenNguoiSD == o.tenNguoiSD);
            return ngsd;
        }

        protected override void setNewInfo(NguoiSuDung newEntity, NguoiSuDung old)
        {
            old.maNguoiSD = newEntity.maNguoiSD;
            old.tenNguoiSD = newEntity.tenNguoiSD;
        }

        public NguoiSuDung CheckUser(string maNguoiSD, string tenNguoiSD)
        {
            NguoiSuDung ngsd = null;
            ngsd = base.entitySet.FirstOrDefault(t => t.maNguoiSD == maNguoiSD || t.tenNguoiSD == tenNguoiSD);
            return ngsd;
        }
    }
}
