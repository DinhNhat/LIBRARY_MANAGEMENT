using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreNhaXuatBan : EntityPresenter<NhaXuatBan>
    {
        public PreNhaXuatBan() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.NhaXuatBans; // NhaXuatBans from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maNXB);
        }

        // get the first element of a specified Entity
        protected override NhaXuatBan getEntity(NhaXuatBan o)
        {
            NhaXuatBan nxb = null;
            nxb = base.entitySet.FirstOrDefault(t => t.maNXB == o.maNXB);
            return nxb;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(NhaXuatBan newEntity, NhaXuatBan old)
        {
            old.tenNXB = newEntity.tenNXB;
        }
    }
}
