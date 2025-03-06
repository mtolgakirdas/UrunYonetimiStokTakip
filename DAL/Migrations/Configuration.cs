namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//veritabanı değişikleirini otomatik olarak uygula.
            AutomaticMigrationDataLossAllowed = true;//Olası veri kayıplarını kabul ediyorum.
            ContextKey = "DAL.DatabaseContext";
        }

        protected override void Seed(DAL.DatabaseContext context)
        {
            if (!context.Kullanicilar.Any())
            {
                context.Kullanicilar.Add(
                    new Kullanici()
                    {
                        Aktif = true,
                        KullaniciAdi = "Admin",
                        Sifre = "12345"
                    }
                    );
                context.SaveChanges();
            }
            base.Seed(context);
        } //  This method will be called after migrating to the latest version.

            
    }
}
