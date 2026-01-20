namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Code", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Code");
        }
    }
}
