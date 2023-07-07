namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tbl_User", newName: "tbl_User");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tbl_User", newName: "Users");
        }
    }
}
