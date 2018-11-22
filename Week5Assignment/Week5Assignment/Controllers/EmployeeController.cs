using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Week5Assignment.share.Orchestrator.Interfaces;
using Week5Assignment.share.ViewModels;
using Week5Assignment.Models;

namespace Week5Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController(IEmployeeOrchestrator employeeOrchestrator)
        {
            _employeeOrchestrator = employeeOrchestrator;
        }

        // GET: Employee
        public async Task<ActionResult> Index()
        {
        
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employee = await _employeeOrchestrator.GetAllEmployees()
            };
            return View(employeeDisplayModel);
        }

        public async Task<ActionResult> Create(CreateEmployeeModel employee)
        {
            if(string.IsNullOrWhiteSpace(employee.FirstName))
                return View();

            var updateCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
            {
                EmployeeID = Guid.NewGuid(),
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                AvailableHours = employee.AvailableHours
            });
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdateEmployee(UpdateEmployeeModel employee)
        {
            if (employee.EmployeeID == Guid.Empty)
                return Json(false, JsonRequestBehavior.AllowGet);

            var result = await _employeeOrchestrator.UpdateEmployee(new EmployeeViewModel
            {
                EmployeeID = employee.EmployeeID,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                SalaryType = employee.SalaryType,
                AvailableHours = employee.AvailableHours
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string searchString)
        {
            var viewModel = await _employeeOrchestrator.SearchEmployee(searchString);

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
  
        public async Task<ActionResult> YearsEmployed()
        {

            var yearsEmployedModel = new EmployeeDisplayModel
            {
                Employee = await _employeeOrchestrator.GetAllEmployees()
            };
            return View(yearsEmployedModel);
        }
    }
}