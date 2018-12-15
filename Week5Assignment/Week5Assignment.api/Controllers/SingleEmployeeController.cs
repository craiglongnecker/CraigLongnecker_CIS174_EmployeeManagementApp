using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Week5Assignment.api.Models;
using Week5Assignment.share.Orchestrator;

namespace Week5Assignment.api.Controllers
{
    [Route("api/v1/singleemployee")]
    public class SingleEmployeeController : ApiController
    {
        private SingleEmployeeOrchestrator _singleEmployeeOrchestrator;

        public SingleEmployeeController()
        {
            _singleEmployeeOrchestrator = new SingleEmployeeOrchestrator();
        }

        public SingleEmployeeModel[] se = new SingleEmployeeModel[]
    {
            new SingleEmployeeModel {EmployeeNum = 1, FirstName = "Brock", MiddleName = "David", LastName = "Purdy", BirthDate1 = "1980-09-09", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 2, FirstName = "David", MiddleName = "James", LastName = "Montgomery", BirthDate1 = "1998-09-23", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 3, FirstName = "Ray", MiddleName = "Gregory", LastName = "Maloney", BirthDate1 = "1959-06-30", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 4, FirstName = "Steven", MiddleName = "Samuel", LastName = "Prohm", BirthDate1 = "1970-11-07", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 5, FirstName = "Amy", MiddleName = "Jorene", LastName = "Sprecher", BirthDate1 = "1961-06-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeNum = 6, FirstName = "Jamie", MiddleName = "Joseph", LastName = "Pollard", BirthDate1 = "1976-12-06", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeNum = 7, FirstName = "Hakeem", MiddleName = "Muhammed", LastName = "Butler", BirthDate1 = "1976-11-07", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 8, FirstName = "Daniel", MiddleName = "Day", LastName = "Lewis", BirthDate1 = "1965-03-06", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeNum = 9, FirstName = "Barbara", MiddleName = "Ann", LastName = "Smith", BirthDate1 = "1938-08-14", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeNum = 10, FirstName = "Julie", MiddleName = "Jo", LastName = "Jungling", BirthDate1 = "1961-06-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeNum = 11, FirstName = "David", MiddleName = "John", LastName = "Smith", BirthDate1 = "1960-09-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeNum = 12, FirstName = "Craig", MiddleName = "David", LastName = "Longnecker", BirthDate1 = "1960-09-23", Department = "Executive"}
    };
    public IEnumerable<SingleEmployeeModel> GetSingleEmployee()
    {
        return se;
    }

        public IHttpActionResult GetEmployee(int num)
        {
            var empl = se.FirstOrDefault((x) => x.EmployeeNum == num);
            if (empl == null)
            {
                return NotFound();
            }
            return Ok(empl);
        }

//        [HttpPost]
//        public async Task<List<SingleEmployeeModel>> GetEmployeeById(int EmployeeNum)
//        {
//            var singleEmployee = await _singleEmployeeOrchestrator.GetEmployeeById(EmployeeNum);

//            return singleEmployee;
//        }
        [HttpPost]
        public async Task<SingleEmployeeModel> GetEmployeeById(int EmployeeNum)
        {
            var employee = await _singleEmployeeOrchestrator.GetEmployeeById(EmployeeNum);

            var singleEmployeeViewModel = new SingleEmployeeModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate1 = employee.BirthDate1,
                Department = employee.Department
            };
            return singleEmployeeViewModel;
        }
    }
}

