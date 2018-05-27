using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreKhoSach : EntityPresenter<KhoSach>
    {
        public PreKhoSach() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.KhoSaches; // KhoSaches from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0) // get element with the max key(the maximum maKhoSach)
                maxKey = (int)base.entitySet.Max(t => t.maKhoSach);
        }

        // get the first element of a specified Entity
        protected override KhoSach getEntity(KhoSach o)
        {
            KhoSach ks = null;
            ks = base.entitySet.FirstOrDefault(t => t.maKhoSach == o.maKhoSach);
            return ks;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(KhoSach newEntity, KhoSach old)
        {
            old.tenKhoSach = newEntity.tenKhoSach;
        }
    }
}
