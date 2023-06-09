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
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(TransaksiMetadata))]
    public partial class Transaksi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaksi()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.Transaksi_Kendaraan = new HashSet<Transaksi_Kendaraan>();
        }
    
        public int ID_Transaksi { get; set; }
        public int ID_Paket { get; set; }
        public string ID_Customer { get; set; }
        public Nullable<int> ID_Pegawai { get; set; }
        public decimal Harga_total { get; set; }
        public int Jumlah_Penumpang { get; set; }
        public System.DateTime Tanggal_Pesanan { get; set; }
        public string Bukti_DP { get; set; }
        public string Bukti_Pelunasan { get; set; }
        public Nullable<decimal> biaya_tambahan { get; set; }
        public int Status_Transaksi { get; set; }
        public Nullable<double> PaketLama_Perjalanan { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual Paket Paket { get; set; }
        public virtual Pegawai Pegawai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi_Kendaraan> Transaksi_Kendaraan { get; set; }
    }
}
