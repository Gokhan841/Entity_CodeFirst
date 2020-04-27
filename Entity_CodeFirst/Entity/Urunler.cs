using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_CodeFirst.Entity;

namespace Entity_CodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public Kategoriler Kategoriler { get; set; }


    }
}
