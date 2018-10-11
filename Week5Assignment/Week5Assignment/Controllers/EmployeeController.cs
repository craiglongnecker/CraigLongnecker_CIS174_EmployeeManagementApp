using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Week5Assignment.share.Orchestrator;
using Week5Assignment.share.ViewModels;
using Week5Assignment.Models;

namespace Week5Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();

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
    }
}