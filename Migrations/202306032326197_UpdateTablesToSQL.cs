namespace SchoolProject.Migrations
{
    using SchoolProject.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTablesToSQL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_Series",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_Study",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Videos");
            DropTable("dbo.tbl_Study");
            DropTable("dbo.tbl_Series");
            DropTable("dbo.tbl_Reports");
            DropTable("dbo.tbl_Images");
        }
    }
}
