using System.Collections.Generic;
using Week5Assignment.api.Models;

namespace Week5Assignment.api.Controllers
{
    [Route("api/v1/allemployees")]
    public class AllEmployeesController : ApiController
    {
        public AllEmployeesModel[] allEmployees = new AllEmployeesModel[]
        {
            new AllEmployeesModel {EmployeeID = 1, FirstName = "Brock", MiddleName = "David", LastName = "Purdy" },
            new AllEmployeesModel {EmployeeID = 2, FirstName = "David", MiddleName = "James", LastName = "Montgomery" },
            new AllEmployeesModel {EmployeeID = 3, FirstName = "Ray", MiddleName = "Gregory", LastName = "Maloney" },
            new AllEmployeesModel {EmployeeID = 4, FirstName = "Steven", MiddleName = "Samuel", LastName = "Prohm" },
            new AllEmployeesModel {EmployeeID = 5, FirstName = "Amy", MiddleName = "Jorene", LastName = "Sprecher" },
            new AllEmployeesModel {EmployeeID = 6, FirstName = "Jamie", MiddleName = "Joseph", LastName = "Pollard" },
            new AllEmployeesModel {EmployeeID = 7, FirstName = "Hakeem", MiddleName = "Muhammed", LastName = "Butler" },
            new AllEmployeesModel {EmployeeID = 8, FirstName = "Daniel", MiddleName = "Day", LastName = "Lewis" },
            new AllEmployeesModel {EmployeeID = 9, FirstName = "Barbara", MiddleName = "Ann", LastName = "Smith" },
            new AllEmployeesModel {EmployeeID = 10, FirstName = "Julie", MiddleName = "Jo", LastName = "Jungling" },
            new AllEmployeesModel {EmployeeID = 11, FirstName = "David", MiddleName = "John", LastName = "Smith" },
            new AllEmployeesModel {EmployeeID = 12, FirstName = "Craig", MiddleName = "David", LastName = "Longnecker" }
        };

        public IEnumerable<AllEmployeesModel> GetAllEmployees()
        {
            return allEmployees;
        }
    }
}