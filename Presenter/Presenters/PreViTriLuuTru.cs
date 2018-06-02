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
        // Constructor for the beginning data
        public PreViTriLuuTru() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.ViTriLuuTrus; // ViTriLuuTrus from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            // assign the max ID in list entity for maxkey
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maViTriLuuTru);
        }

        // get the FIRST element of a specified Entity
        protected override ViTriLuuTru getEntity(ViTriLuuTru o)
        {
            ViTriLuuTru vtll = null;
            vtll = base.entitySet.FirstOrDefault(t => t.maViTriLuuTru == o.maViTriLuuTru);
            return vtll;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(ViTriLuuTru newEntity, ViTriLuuTru old)
        {
            old.tenViTriLuuTru = newEntity.tenViTriLuuTru;
        }
    }       
}
