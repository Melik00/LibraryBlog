﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneBlog.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DboGemlikKitabevimEntities : DbContext
    {
        public DboGemlikKitabevimEntities()
            : base("name=DboGemlikKitabevimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_BLOG> TBL_BLOG { get; set; }
        public virtual DbSet<TBL_HAKKIMIZDA> TBL_HAKKIMIZDA { get; set; }
        public virtual DbSet<TBL_ILETISIM> TBL_ILETISIM { get; set; }
        public virtual DbSet<TBL_KATEGORI> TBL_KATEGORI { get; set; }
        public virtual DbSet<TBL_KAYITLAR> TBL_KAYITLAR { get; set; }
        public virtual DbSet<TBL_KITAPLAR> TBL_KITAPLAR { get; set; }
        public virtual DbSet<TBL_OGRENCILER> TBL_OGRENCILER { get; set; }
        public virtual DbSet<TBL_TUR> TBL_TUR { get; set; }
        public virtual DbSet<TBL_YORUM> TBL_YORUM { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_ADMIN> TBL_ADMIN { get; set; }
    }
}
