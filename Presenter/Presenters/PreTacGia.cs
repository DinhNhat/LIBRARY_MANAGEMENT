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
            base.entitySet = entitiesTV.TacGias;
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maTacGia);
        }

        protected override TacGia getEntity(TacGia o)
        {
            TacGia tg = null;
            tg = base.entitySet.FirstOrDefault(t => t.maTacGia == o.maTacGia);
            return tg;
        }

        protected override void setNewInfo(TacGia newEntity, TacGia old)
        {
            old.tenTacGia = newEntity.tenTacGia;
        }
    }
}
