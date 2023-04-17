﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BUSS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BUSSEntities : DbContext
    {
        public BUSSEntities()
            : base("name=BUSSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Destinasi> Destinasis { get; set; }
        public virtual DbSet<Detail_Foto> Detail_Foto { get; set; }
        public virtual DbSet<Detail_Kategori> Detail_Kategori { get; set; }
        public virtual DbSet<Detail_Paket> Detail_Paket { get; set; }
        public virtual DbSet<Detail_Rating_Destinasi> Detail_Rating_Destinasi { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Jenis_Kendaraan> Jenis_Kendaraan { get; set; }
        public virtual DbSet<Kategori_Wilayah> Kategori_Wilayah { get; set; }
        public virtual DbSet<Kendaraan> Kendaraans { get; set; }
        public virtual DbSet<Kota> Kotas { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<Pegawai> Pegawais { get; set; }
        public virtual DbSet<Transaksi> Transaksis { get; set; }
        public virtual DbSet<Transaksi_Kendaraan> Transaksi_Kendaraan { get; set; }
        public virtual DbSet<view_DashboardCustomer> view_DashboardCustomer { get; set; }
        public virtual DbSet<view_DestinasiTerlaris> view_DestinasiTerlaris { get; set; }
        public virtual DbSet<view_JumlahDestinasiWilayah> view_JumlahDestinasiWilayah { get; set; }
        public virtual DbSet<view_LaporanDestinasi> view_LaporanDestinasi { get; set; }
        public virtual DbSet<view_LaporanFeedback> view_LaporanFeedback { get; set; }
        public virtual DbSet<view_LaporanTransaksi> view_LaporanTransaksi { get; set; }
        public virtual DbSet<view_PaketHome> view_PaketHome { get; set; }
        public virtual DbSet<view_StatusTransCount> view_StatusTransCount { get; set; }
        public virtual DbSet<view_TransaksiCount> view_TransaksiCount { get; set; }
        public virtual DbSet<view_TransaksiAdmin> view_TransaksiAdmin { get; set; }
        public virtual DbSet<view_TransaksiCustomer> view_TransaksiCustomer { get; set; }
    }
}
