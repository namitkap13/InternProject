namespace SchoolProject.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatingPatient : DbMigration
    {

        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Patient",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    DOB = c.DateTime(nullable: false),
                    Gender = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }
        public override void Down()
        {
            DropTable("dbo.tbl_Patient");
        }
    }
}
