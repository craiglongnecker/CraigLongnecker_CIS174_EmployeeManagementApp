using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Week5Assignment.api.Models;
using Week5Assignment.share.Orchestrator;

namespace Week5Assignment.api.Controllers
{
    [Route("api/v1/allemployees")]
    public class AllEmployeesController : ApiController
    {
        private AllEmployeesOrchestrator _allEmployeesOrchestrator;

        public AllEmployeesController()
        {
            _allEmployeesOrchestrator = new AllEmployeesOrchestrator();
        }

        public AllEmployeesModel[] allEmployees = new AllEmployeesModel[]
        {
            new AllEmployeesModel {EmployeeNum = 1, FirstName = "Brock", MiddleName = "David", LastName = "Purdy" },
            new AllEmployeesModel {EmployeeNum = 2, FirstName = "David", MiddleName = "James", LastName = "Montgomery" },
            new AllEmployeesModel {EmployeeNum = 3, FirstName = "Ray", MiddleName = "Gregory", LastName = "Maloney" },
            new AllEmployeesModel {EmployeeNum = 4, FirstName = "Steven", MiddleName = "Samuel", LastName = "Prohm" },
            new AllEmployeesModel {EmployeeNum = 5, FirstName = "Amy", MiddleName = "Jorene", LastName = "Sprecher" },
            new AllEmployeesModel {EmployeeNum = 6, FirstName = "Jamie", MiddleName = "Joseph", LastName = "Pollard" },
            new AllEmployeesModel {EmployeeNum = 7, FirstName = "Hakeem", MiddleName = "Muhammed", LastName = "Butler" },
            new AllEmployeesModel {EmployeeNum = 8, FirstName = "Daniel", MiddleName = "Day", LastName = "Lewis" },
            new AllEmployeesModel {EmployeeNum = 9, FirstName = "Barbara", MiddleName = "Ann", LastName = "Smith" },
            new AllEmployeesModel {EmployeeNum = 10, FirstName = "Julie", MiddleName = "Jo", LastName = "Jungling" },
            new AllEmployeesModel {EmployeeNum = 11, FirstName = "David", MiddleName = "John", LastName = "Smith" },
            new AllEmployeesModel {EmployeeNum = 12, FirstName = "Craig", MiddleName = "David", LastName = "Longnecker" }
        };

        [HttpGet]
        public async Task<List<AllEmployeesModel>> GetAllEmployees()
        {
            var allEmployees = await _allEmployeesOrchestrator.GetAllEmployees();

            var employeeModels = allEmployees.Select(x => new AllEmployeesModel
            {
                EmployeeNum = x.EmployeeNum,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
            }).ToList();
            return employeeModels;
        }
    }
}