using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using View;

namespace Presenter
{
    public class EntityListPresenter<T> : Presenter where T : class
    {
        protected DbSet<T> entitySet;
        protected BindingSource bindingsource = new BindingSource();

        // fileds for view and viewLs
        protected IViewEntity<T> view;
        protected IViewListEntity<T> viewLs;
        //properties for View and ViewLs
        public IViewEntity<T> View { set { this.view = value; } }
        public IViewListEntity<T> ViewLs { set { this.viewLs = value; } }

        protected int maxKey = 0;
        public int currentIndex;

        //Thiết lập view cho presenter
        //public EntityListPresenter():base(){}


        // 1 method ViewList
        public void ListEntity()
        {
            if (viewLs != null)
                viewLs.viewListEntity(bindingsource);
            else
                view.viewListEntity(bindingsource);
        }

        //Hiến thi một Entity tại một vị trí trong danh sách
        public void viewEntityAt(int index)
        {
            if (index >= 0 && index < bindingsource.Count)
            {
                T entity = (T)bindingsource[index];
                if (entity != null)
                    view.viewEntity(entity);
            }
        }

        public void ViewList()
        {
            if (view != null)
                view.viewListEntity(bindingsource);
            if (viewLs != null)
                viewLs.viewListEntity(bindingsource);
        }
    }
}
