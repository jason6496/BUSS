//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class view_LaporanDestinasi
    {
        public int ID_Destinasi { get; set; }
        public string Nama_Destinasi { get; set; }
        public decimal Harga_Tiket { get; set; }
        public int ID_Kota { get; set; }
        public double Rating { get; set; }
        public System.TimeSpan Jam_buka { get; set; }
        public System.TimeSpan Jam_tutup { get; set; }
        public string Deskripsi { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Nama_Kota { get; set; }
    }
}
