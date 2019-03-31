using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakipEntities
{
    public class Islem
    {
        public int IslemNo { get; set; }
        public int MusteriID { get; set; }
        public int ArizaID { get; set; }
        public int PersonelID { get; set; }
        public int DurumID { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime VerilenTarih { get; set; }
    }
}
