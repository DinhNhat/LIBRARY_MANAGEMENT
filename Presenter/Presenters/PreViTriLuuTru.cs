using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Presenter.Presenters
{
    public class PreViTriLuuTru : EntityPresenter<ViTriLuuTru>
    {
        public PreViTriLuuTru() : base()
        {
            base.entitySet = entitiesTV.ViTriLuuTrus;
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maViTriLuuTru);
        }

        protected override ViTriLuuTru getEntity(ViTriLuuTru o)
        {
            ViTriLuuTru vtll = null;
            vtll = base.entitySet.FirstOrDefault(t => t.maViTriLuuTru == o.maViTriLuuTru);
            return vtll;
        }

        protected override void setNewInfo(ViTriLuuTru newEntity, ViTriLuuTru old)
        {
            old.tenViTriLuuTru = newEntity.tenViTriLuuTru;
        }
    }       
}
