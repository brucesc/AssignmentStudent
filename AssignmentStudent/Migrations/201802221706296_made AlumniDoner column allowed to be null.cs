namespace AssignmentStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeAlumniDonercolumnallowedtobenull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AlumniDoner", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "AlumniDoner", c => c.Boolean(nullable: false));
        }
    }
}
