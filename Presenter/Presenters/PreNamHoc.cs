using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreNamHoc : EntityPresenter<NamHoc>
    {
        public PreNamHoc() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.NamHocs; // NamHocs from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            // assign the max ID in list entity for maxkey
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maNamHoc);
        }

        // get the first element of a specified Entity
        protected override NamHoc getEntity(NamHoc o)
        {
            NamHoc nh = null;
            nh = base.entitySet.FirstOrDefault(t => t.maNamHoc == o.maNamHoc || t.tenNamHoc == o.tenNamHoc);
            return nh;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(NamHoc newEntity, NamHoc old)
        {
            old.tenNamHoc = newEntity.tenNamHoc;
        }
    }
}
