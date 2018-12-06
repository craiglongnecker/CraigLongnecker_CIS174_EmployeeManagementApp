using System.Collections.Generic;
using System.Linq;
using Week5Assignment.api.Models;

namespace Week5Assignment.api.Controllers
{
    [Route("api/v1/singleemployee")]
    public class SingleEmployeeController : ApiController
    {
    public SingleEmployeeModel[] se = new SingleEmployeeModel[]
    {
            new SingleEmployeeModel {EmployeeID = 1, FirstName = "Brock", MiddleName = "David", LastName = "Purdy", BirthDate = "1980-09-09", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 2, FirstName = "David", MiddleName = "James", LastName = "Montgomery", BirthDate = "1998-09-23", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 3, FirstName = "Ray", MiddleName = "Gregory", LastName = "Maloney", BirthDate = "1959-06-30", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 4, FirstName = "Steven", MiddleName = "Samuel", LastName = "Prohm", BirthDate = "1970-11-07", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 5, FirstName = "Amy", MiddleName = "Jorene", LastName = "Sprecher", BirthDate = "1961-06-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeID = 6, FirstName = "Jamie", MiddleName = "Joseph", LastName = "Pollard", BirthDate = "1976-12-06", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeID = 7, FirstName = "Hakeem", MiddleName = "Muhammed", LastName = "Butler", BirthDate = "1976-11-07", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 8, FirstName = "Daniel", MiddleName = "Day", LastName = "Lewis", BirthDate = "1965-03-06", Department = "Manufacturing"},
            new SingleEmployeeModel {EmployeeID = 9, FirstName = "Barbara", MiddleName = "Ann", LastName = "Smith", BirthDate = "1938-08-14", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeID = 10, FirstName = "Julie", MiddleName = "Jo", LastName = "Jungling", BirthDate = "1961-06-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeID = 11, FirstName = "David", MiddleName = "John", LastName = "Smith", BirthDate = "1960-09-23", Department = "Accounting"},
            new SingleEmployeeModel {EmployeeID = 12, FirstName = "Craig", MiddleName = "David", LastName = "Longnecker", BirthDate = "1960-09-23", Department = "Executive"}
    };
    public IEnumerable<SingleEmployeeModel> GetSingleEmployee()
    {
        return se;
    }

        public IHttpActionResult GetEmployee(int id)
        {
            var empl = se.FirstOrDefault((x) => x.EmployeeID == id);
            if (empl == null)
            {
                return NotFound();
            }
            return Ok(empl);
        }
    }
}
