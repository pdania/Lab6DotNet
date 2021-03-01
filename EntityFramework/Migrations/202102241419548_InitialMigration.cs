namespace EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Middlename = c.String(name: "Middle name"),
                        Position = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee");
        }
    }
}
