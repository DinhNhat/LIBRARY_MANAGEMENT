using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Presenter.Presenters
{
    public class PreTacGia : EntityPresenter<TacGia>
    {
        public PreTacGia() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.TacGias; // TacGias from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            // assign the max ID in list entity for maxkey
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maTacGia);
        }

        // get the first element of a specified Entity
        protected override TacGia getEntity(TacGia o)
        {
            TacGia tg = null;
            tg = base.entitySet.FirstOrDefault(t => t.maTacGia == o.maTacGia);
            return tg;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(TacGia newEntity, TacGia old)
        {
            old.tenTacGia = newEntity.tenTacGia;
        }
    }
}
