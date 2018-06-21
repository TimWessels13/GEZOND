namespace GEZOND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Huisartsens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Adres = c.String(),
                        Postcode = c.String(),
                        Plaats = c.String(),
                        Maand = c.String(),
                        Jaar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Klantens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Adres = c.String(),
                        Postcode = c.String(),
                        Plaats = c.String(),
                        Arts = c.String(),
                        Verzekeraar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicaties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KlantId = c.Int(nullable: false),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicaties");
            DropTable("dbo.Klantens");
            DropTable("dbo.Huisartsens");
        }
    }
}
