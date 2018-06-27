namespace GEZOND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pizza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "ArtsId", c => c.Int(nullable: false));
            DropColumn("dbo.Klantens", "Arts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "Arts", c => c.String());
            DropColumn("dbo.Klantens", "ArtsId");
        }
    }
}
