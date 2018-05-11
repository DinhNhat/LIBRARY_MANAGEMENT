using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IViewEntity<T> : IViewListEntity<T>
    {
        void viewEntity(T entity);
        T AddNewEntity();
        T DeleteEntity();
        T UpdateEntity();
    }
}
