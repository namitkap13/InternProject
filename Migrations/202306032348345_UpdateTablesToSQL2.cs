namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTablesToSQL2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Reports", "seriesId", c => c.Int(nullable: false));
            AddColumn("dbo.tbl_Series", "studyId", c => c.Int(nullable: false));
            AddColumn("dbo.tbl_Study", "seriesId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Study", "seriesId");
            DropColumn("dbo.tbl_Series", "studyId");
            DropColumn("dbo.tbl_Reports", "seriesId");
        }
    }
}
