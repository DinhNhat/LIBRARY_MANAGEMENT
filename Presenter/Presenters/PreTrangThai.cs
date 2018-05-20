﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreTrangThai : EntityPresenter<TrangThai>
    {
        public PreTrangThai() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.TrangThais; // TrangThais from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
            if (base.bindingsource.Count > 0)
                maxKey = (int)base.entitySet.Max(t => t.maTrangThai);
        }

        // get the first element of a specified Entity
        protected override TrangThai getEntity(TrangThai o)
        {
            TrangThai tt = null;
            tt = base.entitySet.FirstOrDefault(t => t.maTrangThai == o.maTrangThai);
            return tt;
        }

        // renew data for new entity after changing (that means swap between both entities)
        protected override void setNewInfo(TrangThai newEntity, TrangThai old)
        {
            old.tenTrangThai = newEntity.tenTrangThai;
        }
    }
}