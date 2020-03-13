namespace SqlTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.College",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        YearsOfStudy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CollegeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.College", t => t.CollegeID, cascadeDelete: true)
                .Index(t => t.CollegeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "CollegeID", "dbo.College");
            DropIndex("dbo.Student", new[] { "CollegeID" });
            DropTable("dbo.Student");
            DropTable("dbo.College");
        }
    }
}
