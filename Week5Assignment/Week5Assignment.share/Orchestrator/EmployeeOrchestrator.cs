using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Assignment.domain;
using Week5Assignment.domain.Entities;
using Week5Assignment.share.Orchestrator.Interfaces;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Orchestrator
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        private EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
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
            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                HireDate = x.HireDate,
                Department = x.Department,
                JobTitle = x.JobTitle,
                Salary = x.Salary,
                SalaryType = x.SalaryType,
                AvailableHours = x.AvailableHours
            }).ToListAsync();
            return employees;
        }

        public async Task<EmployeeViewModel> SearchEmployee(string searchString)
        {
            var employee = await _employeeContext.Employees
                .Where(x => x.LastName.StartsWith(searchString))
                .FirstOrDefaultAsync();

            if (employee == null)
            {
                return new EmployeeViewModel();
            }

            var viewModel = new EmployeeViewModel
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
            };

            return viewModel;
        }

        public async Task<bool> UpdateEmployee(EmployeeViewModel employee)
        {
            var updateEntity = await _employeeContext.Employees.FindAsync(employee.EmployeeID);

            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = employee.FirstName;
            updateEntity.MiddleName = employee.MiddleName;
            updateEntity.LastName = employee.LastName;
            updateEntity.BirthDate = employee.BirthDate;
            updateEntity.HireDate = employee.HireDate;
            updateEntity.Department = employee.Department;
            updateEntity.JobTitle = employee.JobTitle;
            updateEntity.Salary = employee.Salary;
            updateEntity.SalaryType = employee.SalaryType;
            updateEntity.AvailableHours = employee.AvailableHours;

            await _employeeContext.SaveChangesAsync();

            return true;
        }
    }
}
