using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PrePhieuSuDungSach : EntityPresenter<PhieuSuDungSach>
    {
        public PrePhieuSuDungSach() : base()
        {
            base.entitySet = entitiesTV.PhieuSuDungSaches;
            base.bindingsource.DataSource = entitySet.ToList();
        }

        protected override PhieuSuDungSach getEntity(PhieuSuDungSach o)
        {
            PhieuSuDungSach phieu = null;
            phieu = base.entitySet.FirstOrDefault(t => t.maPhieuSD == o.maPhieuSD);
            return phieu;
        }

        protected override void setNewInfo(PhieuSuDungSach newEntity, PhieuSuDungSach old)
        {
            old.maLop = newEntity.maLop;
        }
    }
}
