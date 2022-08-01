namespace SinglePageAppInMVCUsingViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CountryId", "dbo.Countries");
            DropIndex("dbo.Students", new[] { "CountryId" });
            DropTable("dbo.Students");
            DropTable("dbo.Countries");
        }
    }
}
