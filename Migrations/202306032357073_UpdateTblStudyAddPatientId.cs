namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTblStudyAddPatientId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Study", "patientId", c => c.Int(nullable: false));
            DropColumn("dbo.tbl_Study", "seriesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Study", "seriesId", c => c.Int(nullable: false));
            DropColumn("dbo.tbl_Study", "patientId");
        }
    }
}
