namespace Week5Assignment.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYearsEmployedPage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "HireDate", c => c.DateTime());
            AlterColumn("dbo.Employees", "BirthDate", c => c.DateTime());
        }
    }
}
