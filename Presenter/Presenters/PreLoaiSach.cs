using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreLoaiSach : EntityPresenter<LoaiSach>
    {
        public Boolean maLoaiSachIsBlank;

        public PreLoaiSach() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.LoaiSaches; // LoaiSachs from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        // check elements of EntitySet if there's been already existed element
        protected override LoaiSach getEntity(LoaiSach o)
        {
            LoaiSach ls = null;
            if(o == null)
            {
                o = new LoaiSach();
                o.maLoaiSach = "";
                ls = base.entitySet.FirstOrDefault(t => t.maLoaiSach == o.maLoaiSach);
            }
            else
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
