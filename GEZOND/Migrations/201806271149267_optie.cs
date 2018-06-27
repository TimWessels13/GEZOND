namespace GEZOND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "ArtsNaam", c => c.String());
            DropColumn("dbo.Klantens", "ArtsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "ArtsId", c => c.Int(nullable: false));
            DropColumn("dbo.Klantens", "ArtsNaam");
        }
    }
}
