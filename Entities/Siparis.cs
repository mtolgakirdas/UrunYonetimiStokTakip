using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Siparis:IEntity
    {
        public int Id { get; set; }
        public string siparisNo { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }

    }
}
