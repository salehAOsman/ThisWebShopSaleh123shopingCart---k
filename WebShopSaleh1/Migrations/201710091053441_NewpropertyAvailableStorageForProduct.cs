namespace WebShopSaleh1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewpropertyAvailableStorageForProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AvailableStorage", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "AvailableStorage");
        }
    }
}
