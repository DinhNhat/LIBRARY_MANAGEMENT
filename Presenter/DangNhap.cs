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
    
    public partial class DangNhap
    {
        public int maDangNhap { get; set; }
        public System.DateTime thoiGianDangNhap { get; set; }
        public string maNguoiSD { get; set; }
        public Nullable<System.DateTime> thoiGianThoat { get; set; }
    
        public virtual NguoiSuDung NguoiSuDung { get; set; }
    }
}
