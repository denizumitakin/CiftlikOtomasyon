﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiftlikOtomasyon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CiftlikEntities : DbContext
    {
        public CiftlikEntities()
            : base("name=CiftlikEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cins> Cins { get; set; }
        public virtual DbSet<Hayvan> Hayvan { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<StokHareket> StokHareket { get; set; }
        public virtual DbSet<StokTur> StokTur { get; set; }
        public virtual DbSet<SutUretim> SutUretim { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zaman> Zaman { get; set; }
        public virtual DbSet<vKullanici> vKullanici { get; set; }
    }
}
