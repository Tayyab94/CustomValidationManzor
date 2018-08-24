namespace ValidationPracticeManzor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CostomAnnotationAddinToDepartmentTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "HOD", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "HOD", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
