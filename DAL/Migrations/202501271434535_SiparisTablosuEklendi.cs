namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiparisTablosuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Siparis",
                c=> new
                {
                    Id = c.Int(nullable: false, identity: true),
                    siparisNo = c.Int(nullable: false, identity: false),
                    MusteriId = c.Int(nullable: false, identity: false),
                    UrunId = c.Int(nullable: false, identity: false),
                    SiparisTarihi = c.Int(nullable: false, identity: false)
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Siparis");
        }
    }
}
