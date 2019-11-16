﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbmsQLNS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyNhanSuEntities : DbContext
    {
        public QuanLyNhanSuEntities()
            : base("name=QuanLyNhanSuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CapNhatLuong> CapNhatLuongs { get; set; }
        public virtual DbSet<CapNhatTrinhDoHocVan> CapNhatTrinhDoHocVans { get; set; }
        public virtual DbSet<ChiTietLuong> ChiTietLuongs { get; set; }
        public virtual DbSet<ChucVuNhanVien> ChucVuNhanViens { get; set; }
        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<LuanChuyenNhanVien> LuanChuyenNhanViens { get; set; }
        public virtual DbSet<LuongA1GV> LuongA1GV { get; set; }
        public virtual DbSet<LuongA21PGS> LuongA21PGS { get; set; }
        public virtual DbSet<LuongA31GS> LuongA31GS { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThoiViec> ThoiViecs { get; set; }
        public virtual DbSet<TrinhDoHocVan> TrinhDoHocVans { get; set; }
    
        [DbFunction("QuanLyNhanSuEntities", "f_Search")]
        public virtual IQueryable<f_Search_Result> f_Search(string searchString)
        {
            var searchStringParameter = searchString != null ?
                new ObjectParameter("searchString", searchString) :
                new ObjectParameter("searchString", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<f_Search_Result>("[QuanLyNhanSuEntities].[f_Search](@searchString)", searchStringParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> Sp_Account_Login(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("Sp_Account_Login", usernameParameter, passwordParameter);
        }
    
        public virtual int Sp_NhanViens_Insert(string manv, string matkhau, string name, Nullable<System.DateTime> ngaysinh, string quequan, string hinhanh, Nullable<int> gioitinh, string dantoc, string sdt_NhanVien, string macv, Nullable<bool> trangthai, string mapb, string mahd, string macn, string matd, string cmnd)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var quequanParameter = quequan != null ?
                new ObjectParameter("quequan", quequan) :
                new ObjectParameter("quequan", typeof(string));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(int));
    
            var dantocParameter = dantoc != null ?
                new ObjectParameter("dantoc", dantoc) :
                new ObjectParameter("dantoc", typeof(string));
    
            var sdt_NhanVienParameter = sdt_NhanVien != null ?
                new ObjectParameter("sdt_NhanVien", sdt_NhanVien) :
                new ObjectParameter("sdt_NhanVien", typeof(string));
    
            var macvParameter = macv != null ?
                new ObjectParameter("macv", macv) :
                new ObjectParameter("macv", typeof(string));
    
            var trangthaiParameter = trangthai.HasValue ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(bool));
    
            var mapbParameter = mapb != null ?
                new ObjectParameter("mapb", mapb) :
                new ObjectParameter("mapb", typeof(string));
    
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var macnParameter = macn != null ?
                new ObjectParameter("macn", macn) :
                new ObjectParameter("macn", typeof(string));
    
            var matdParameter = matd != null ?
                new ObjectParameter("matd", matd) :
                new ObjectParameter("matd", typeof(string));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_NhanViens_Insert", manvParameter, matkhauParameter, nameParameter, ngaysinhParameter, quequanParameter, hinhanhParameter, gioitinhParameter, dantocParameter, sdt_NhanVienParameter, macvParameter, trangthaiParameter, mapbParameter, mahdParameter, macnParameter, matdParameter, cmndParameter);
        }
    
        public virtual ObjectResult<Sp_NhanViens_ShowList_Result> Sp_NhanViens_ShowList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_NhanViens_ShowList_Result>("Sp_NhanViens_ShowList");
        }
    
        public virtual ObjectResult<Sp_search_Result> Sp_search(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_search_Result>("Sp_search", manvParameter);
        }
    
        public virtual ObjectResult<Sp_Luongs_ShowList_Result> Sp_Luongs_ShowList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Luongs_ShowList_Result>("Sp_Luongs_ShowList");
        }
    
        public virtual ObjectResult<Sp_ChiTietLuong_ShowList_Result> Sp_ChiTietLuong_ShowList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_ChiTietLuong_ShowList_Result>("Sp_ChiTietLuong_ShowList");
        }
    
        public virtual ObjectResult<Nullable<bool>> Sp_CheckMaNV(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("Sp_CheckMaNV", manvParameter);
        }
    
        public virtual int Sp_DelNhanVien(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_DelNhanVien", manvParameter);
        }
    }
}
