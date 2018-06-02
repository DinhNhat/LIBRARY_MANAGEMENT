using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreTinhTrangSachMuonTra : EntityPresenter<TinhTrangSachMuonTra>
    {
        public PreTinhTrangSachMuonTra() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.TinhTrangSachMuonTras; // TinhTrangSachMuonTras from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            // assign the max ID in list entity for maxkey
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maTinhTrangSach);
        }

        // get the first element of a specified Entity
        protected override TinhTrangSachMuonTra getEntity(TinhTrangSachMuonTra o)
        {
            TinhTrangSachMuonTra ttsmt = null;
            ttsmt = base.entitySet.FirstOrDefault(t => t.maTinhTrangSach == o.maTinhTrangSach);
            return ttsmt;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(TinhTrangSachMuonTra newEntity, TinhTrangSachMuonTra old)
        {
            old.tenTinhTrangSach = newEntity.tenTinhTrangSach;
        }
    }
}
