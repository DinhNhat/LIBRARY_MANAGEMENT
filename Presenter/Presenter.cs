using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class Presenter
    {
        // get all elements of DbSet entity from Model(Database)
        protected static ThuVienDBDHEntities entitiesTV;

        // Constructor Method
        protected Presenter() { setEntityContext(); }

        protected static void setEntityContext()
        {
            if (entitiesTV == null)
                entitiesTV = new ThuVienDBDHEntities();
        }
    }
}
