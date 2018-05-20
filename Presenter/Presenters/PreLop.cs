using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreLop : EntityPresenter<Lop>
    {
        public PreLop() : base()
        {
            base.entitySet = entitiesTV.Lops;
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override Lop getEntity(Lop o)
        {
            Lop l = null;
            l = base.entitySet.FirstOrDefault(t => t.maLop == o.maLop);
            return l;
        }

        protected override void setNewInfo(Lop newEntity, Lop old)
        {
            old.tenLop = newEntity.tenLop;
            old.maNamHoc = newEntity.maNamHoc;
        }
    }
}
