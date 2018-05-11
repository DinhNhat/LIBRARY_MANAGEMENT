using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using View;

namespace Presenter
{
    public abstract class EntityPresenter<T> : EntityListPresenter<T> where T : class
    {
        public List<T> EntityList { get { return this.EntityList; } }

        //abstract methods
        abstract protected T getEntity(T o);
        abstract protected void setNewInfo(T newEntity, T old);

        //thêm mới một entity
        public int addNewEntity()
        {
            int num = 0;
            T entity = view.AddNewEntity();
            if (getEntity(entity) == null)
            {
                entitySet.Add(entity);
                num = entitiesTV.SaveChanges();
                if (num > 0)
                {
                    maxKey += 1;
                    this.bindingsource.DataSource = entitySet.ToList();
                }
            }
            return num;
        }

        //delete một entity
        public int deleteEntity()
        {
            int num = 0;
            T entity = view.DeleteEntity();
            T entityToDelete = getEntity(entity);
            if (entityToDelete != null)
            {
                entitySet.Remove(entityToDelete);
                num = entitiesTV.SaveChanges();
                if (num > 0)
                {
                    this.bindingsource.DataSource = entitySet.ToList();
                }

            }
            return num;
        }

        //Cập nhật một entity
        public int updateEntity()
        {
            int num = 0;
            T entity = view.UpdateEntity();
            T old = getEntity(entity);
            if (old != null)
            {
                setNewInfo(entity, old);
                num = entitiesTV.SaveChanges();
                if (num > 0)
                {
                    this.bindingsource.DataSource = entitySet.ToList();
                }
            }
            return num;
        }

        // lấy giá trị key của entity đứng cuối cùng
        public int LastKey
        {
            get { return this.maxKey; }
        }
    }
}
