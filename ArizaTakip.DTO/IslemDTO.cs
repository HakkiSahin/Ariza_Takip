using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.DTO
{
    public class IslemDTO
    {
        public Islem Islem { get; set; }
        public Musteri Musteri { get; set; }
        public Ariza Ariza { get; set; }
        public Durum Durum { get; set; }
    }
}
