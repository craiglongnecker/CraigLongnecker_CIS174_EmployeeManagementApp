using Week5Assignment.domain.Entities;

namespace Week5Assignment.domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week5Assignment.domain.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week5Assignment.domain.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(x => x.EmployeeID,
                new Employee()
                {
                    EmployeeID = Guid.Parse("f0780baa-a3fa-47b7-a63c-fc81505f1ae5"),
                    FirstName = "David",
                    MiddleName = "John",
                    LastName = "Smith",
                    BirthDate = new DateTime(1960, 9, 23),
                    HireDate = new DateTime(2007, 9, 9),
                    Department = "Accounting",
                    JobTitle = "Accountant",
                    Salary = 75000,
                    SalaryType = SalaryType.Annual,
                    AvailableHours = "8 to 5"
                });
        }
    }
}
