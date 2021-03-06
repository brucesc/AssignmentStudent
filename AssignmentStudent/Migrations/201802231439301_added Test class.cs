namespace AssignmentStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTestclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestName = c.String(nullable: false, maxLength: 50),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "StudentId", "dbo.Students");
            DropIndex("dbo.Tests", new[] { "StudentId" });
            DropTable("dbo.Tests");
        }
    }
}
