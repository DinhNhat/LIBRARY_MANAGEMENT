using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreTraCuu : EntityPresenter<TraCuu>
    {
        public PreTraCuu() : base()
        {
            // set real value for fields -- entitySet and bindingsource.
            base.entitySet = entitiesTV.TraCuus; // TraCuus from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override TraCuu getEntity(TraCuu o)
        {
            throw new NotImplementedException();
        }

        protected override void setNewInfo(TraCuu newEntity, TraCuu old)
        {
            throw new NotImplementedException();
        }

        public void FilterbyTenSach(string tensach)
        {
            base.bindingsource.DataSource = base.entitySet.Where(ts => ts.tenTrangThai.Contains(tensach.Trim())).ToList();
        }
    }
}
