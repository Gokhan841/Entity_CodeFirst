using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CodeFirst.Entity
{
    public class Musteri
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string SoyAd { get; set; }
        public string MusteriSehir { get; set; }

    }
}
