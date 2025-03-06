using Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
       
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Veritaban�nda olu�acak olan tablolar�n isimlerine s tak�s� gelmemesi i�in.(t�rk�ele�me)

            base.OnModelCreating(modelBuilder);
        }
        //Migration : veritaban� g�ncelleme veritab�ndaki eski verileri koruyarak i�lem yapar.


        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>//CreateDatabaseIfNotExists e�er veritaban� yoksa olu�tur.DatabaseContext'e i�erisindeki dbsetlere g�re.
        {
            protected override void Seed(DatabaseContext context)//seed methodu veritaban� olu�turulduktan sonra devreye girip i�lem yapmam�z� sa�lar.
            {
                if (!context.Kullanicilar.Any()) 
                {
                    context.Kullanicilar.Add(
                        new Kullanici()
                        {
                            Aktif = true,
                            KullaniciAdi="Admin",
                            Sifre = "12345"
                        }
                        );
                    context.SaveChanges();


                }
                base.Seed(context);
            }
        }

    }
}
/*
 * Migratioon i�lemleri ile veritab�n�n� silmeden tablolar� g�ncelleyebilir veya tabloda class larda yapt���m�z de�i�ikleri kullanarak g�ncelleme yapabiliyoruz.
 * M�GRAT�ONU AKT�F ETMEK ���N YAPILACAKLAR
 * 1-�ncelikle pmc package manager console kapal� ise onu Vs nun �st men�s�nden aktif ediyoruz.pmc ile komutlar kullanarak paket y�kleme(Entity framework vb),
 * migration i�lemler vb yapabilmek i�in
 * 2-pmc ekran�nda komut �al��t�raca��m�z projeyi(DAL katman�)default project alan�ndan se�iyoruz.EF'nin bu katmanda y�kl� olmas� gerekir
 * 3-Komut sat�r�na enable-migration komutunu yaz�p �al��t�r�yoruz ve DAL katman�nda Migrations klas�r� i�erisindeki classlar olu�mas� laz�m.
 *  i�lem ba�ar�l� ise, i�lem ba�ar�s�z olursa 
 */
