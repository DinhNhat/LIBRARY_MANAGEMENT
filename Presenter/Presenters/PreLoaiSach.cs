using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreLoaiSach : EntityPresenter<LoaiSach>
    {
        public PreLoaiSach() : base()
        {
            base.entitySet = entitiesTV.LoaiSaches;
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override LoaiSach getEntity(LoaiSach o)
        {
            LoaiSach ls = null;
            ls = base.entitySet.FirstOrDefault(t => t.maLoaiSach == o.maLoaiSach);
            return ls;
        }

        protected override void setNewInfo(LoaiSach newEntity, LoaiSach old)
        {
            old.tenLoaiSach = newEntity.tenLoaiSach;
            old.maViTriLuuTru = newEntity.maViTriLuuTru;
        }
    }
}
