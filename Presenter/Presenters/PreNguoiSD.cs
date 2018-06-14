using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    public class PreNguoiSD : EntityPresenter<NguoiSuDung>
    {
        public PreNguoiSD() : base()
        {
            // set real value for fields entitySet and bindingsource.
            base.entitySet = entitiesTV.NguoiSuDungs; // NamHocs from Model Database
            base.bindingsource.DataSource = base.entitySet.ToList();
        }

        protected override NguoiSuDung getEntity(NguoiSuDung o)
        {
            NguoiSuDung ngsd = null;
            ngsd = base.entitySet.FirstOrDefault(t => t.maNguoiSD == o.maNguoiSD);
            return ngsd;
        }

        protected override void setNewInfo(NguoiSuDung newEntity, NguoiSuDung old)
        {
            old.tenNguoiSD = newEntity.tenNguoiSD;
            old.password = newEntity.password;
            old.admin = newEntity.admin;
            old.enable = newEntity.enable;
        }

        public NguoiSuDung CheckUser(NguoiSuDung ng)
        {
            NguoiSuDung ngsd = null;
            ngsd = base.entitySet.FirstOrDefault(t => t.tenNguoiSD == ng.tenNguoiSD && t.password == ng.password);
            return ngsd;
        }

        public string GetIDUserbyName_and_Password(string tenuser, string passWord)
        {
            string idUser = "";
            NguoiSuDung ngsd = new NguoiSuDung();
            ngsd = base.entitySet.FirstOrDefault(ng => ng.tenNguoiSD == tenuser && ng.password == passWord);
            if(ngsd != null)
            {
                idUser = ngsd.maNguoiSD;
                return idUser;
            }
            return idUser;
        }
    }
}
