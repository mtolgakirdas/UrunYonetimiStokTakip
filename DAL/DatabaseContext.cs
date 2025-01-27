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