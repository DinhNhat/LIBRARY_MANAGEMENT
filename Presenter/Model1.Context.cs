﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ThuVienDBDHEntities : DbContext
    {
        public ThuVienDBDHEntities()
            : base("name=ThuVienDBDHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DangNhap> DangNhaps { get; set; }
        public DbSet<KhoSach> KhoSaches { get; set; }
        public DbSet<LoaiSach> LoaiSaches { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MuonSach> MuonSaches { get; set; }
        public DbSet<NamHoc> NamHocs { get; set; }
        public DbSet<NguoiSuDung> NguoiSuDungs { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<PhieuSuDungSach> PhieuSuDungSaches { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<TinhTrangSachMuonTra> TinhTrangSachMuonTras { get; set; }
        public DbSet<TrangThai> TrangThais { get; set; }
        public DbSet<ViTriLuuTru> ViTriLuuTrus { get; set; }
        public DbSet<View_Sach> View_Sach { get; set; }
        public DbSet<View_ThongKeSach> View_ThongKeSach { get; set; }
    }
}
