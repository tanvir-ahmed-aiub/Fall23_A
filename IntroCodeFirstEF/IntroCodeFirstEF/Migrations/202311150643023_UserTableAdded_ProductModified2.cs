namespace IntroCodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded_ProductModified2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Username);
            
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Products", "Qty", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Qty", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropTable("dbo.Users");
        }
    }
}
