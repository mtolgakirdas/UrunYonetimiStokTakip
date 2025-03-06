using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Urun : IEntity
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public int MarkaId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAcıklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Aktif { get; set; }
        public decimal UrunFiyati { get; set; }
        public int KDV { get; set; }
        public int StokMiktari { get; set; }
        public int Iskonto{ get; set; }
        public decimal ToptanFiyat { get; set; }




    }
}
