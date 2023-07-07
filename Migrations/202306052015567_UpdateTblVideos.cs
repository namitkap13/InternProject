namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTblVideos : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.tbl_Videos", "seriesId", "dbo.Series");
        }
        
        public override void Down()
        {
        }
    }
}
