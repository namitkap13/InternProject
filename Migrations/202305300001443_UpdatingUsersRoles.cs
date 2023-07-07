namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingUsersRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tbl_User", "roleId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_User", "roleId");
            DropTable("dbo.tbl_Roles");
        }
    }
}
