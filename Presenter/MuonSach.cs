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
    
    public partial class MuonSach
    {
        public string maPhieuSD { get; set; }
        public int soTT { get; set; }
        public string maSach { get; set; }
        public Nullable<int> maTinhTrangSach { get; set; }
        public Nullable<int> maTrangThai { get; set; }
        public System.DateTime ngayMuon { get; set; }
        public Nullable<System.DateTime> ngayDuKienTra { get; set; }
        public Nullable<System.DateTime> ngayTra { get; set; }
        public Nullable<int> tienPhat { get; set; }
        public string nguoiChoMuon { get; set; }
        public string nguoiNhanSachTra { get; set; }
    
        public virtual NguoiSuDung NguoiSuDung { get; set; }
        public virtual NguoiSuDung NguoiSuDung1 { get; set; }
        public virtual PhieuSuDungSach PhieuSuDungSach { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual TinhTrangSachMuonTra TinhTrangSachMuonTra { get; set; }
        public virtual TrangThai TrangThai { get; set; }
    }
}
