﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public interface IViewListEntity<T>
    {
        void viewListEntity(BindingSource entities);
    }
}
