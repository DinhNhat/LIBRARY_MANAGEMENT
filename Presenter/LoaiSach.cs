//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiSach
    {
        public LoaiSach()
        {
            this.Saches = new HashSet<Sach>();
        }
    
        public string maLoaiSach { get; set; }
        public Nullable<int> maViTriLuuTru { get; set; }
        public string tenLoaiSach { get; set; }
    
        public virtual ViTriLuuTru ViTriLuuTru { get; set; }
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
