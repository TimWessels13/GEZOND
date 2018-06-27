namespace GEZOND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "ArtsId", c => c.Int(nullable: false));
            DropColumn("dbo.Klantens", "ArtsNaam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "ArtsNaam", c => c.String());
            DropColumn("dbo.Klantens", "ArtsId");
        }
    }
}
