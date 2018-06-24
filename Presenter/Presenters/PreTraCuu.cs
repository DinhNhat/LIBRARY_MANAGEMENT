using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreTraCuu : EntityPresenter<View_Sach>
    {
        public PreTraCuu() : base()
        {
            // set real value for fields -- entitySet and bindingsource.
            base.entitySet = entitiesTV.View_Sach; // View_Sach from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override View_Sach getEntity(View_Sach o)
        {
            throw new NotImplementedException();
        }

        protected override void setNewInfo(View_Sach newEntity, View_Sach old)
        {
            throw new NotImplementedException();
        }

        public void FilterbyTenSach(string tensach)
        {
            base.bindingsource.DataSource = base.entitySet.Where(ts => ts.tenSach.Contains(tensach.Trim())).ToList();
        }
    }
}
