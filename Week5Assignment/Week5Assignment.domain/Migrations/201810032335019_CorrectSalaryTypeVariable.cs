namespace Week5Assignment.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectSalaryTypeVariable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "SalaryType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "SalaryType");
        }
    }
}
