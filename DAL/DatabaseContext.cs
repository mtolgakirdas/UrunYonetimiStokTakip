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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Veritabanýnda oluþacak olan tablolarýn isimlerine s takýsý gelmemesi için.(türkçeleþme)

            base.OnModelCreating(modelBuilder);
        }
        //Migration : veritabaný güncelleme veritabýndaki eski verileri koruyarak iþlem yapar.


        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>//CreateDatabaseIfNotExists eðer veritabaný yoksa oluþtur.DatabaseContext'e içerisindeki dbsetlere göre.
        {
            protected override void Seed(DatabaseContext context)//seed methodu veritabaný oluþturulduktan sonra devreye girip iþlem yapmamýzý saðlar.
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