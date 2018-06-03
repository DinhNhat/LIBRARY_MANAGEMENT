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
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.Lops; // Lops from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            // assign the max ID in list entity for maxkey
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maLop);
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

        public string GetTenLopforFilter(int malop)
        {
            Lop lop;
            lop = base.entitySet.FirstOrDefault(l => l.maLop == malop);
            return lop.tenLop;
        }

    }
}
