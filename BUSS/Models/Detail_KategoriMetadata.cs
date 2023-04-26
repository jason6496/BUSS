using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BUSS.Models
{
    public class Detail_KategoriMetadata
    {
        public int ID_KategoriWilayah { get; set; }
        [Required(ErrorMessage = "Se requiere ciudad!")]
        public int ID_Kota { get; set; }
        public int Status { get; set; }

        public virtual Kategori_Wilayah Kategori_Wilayah { get; set; }
        public virtual Kota Kota { get; set; }
    }
}