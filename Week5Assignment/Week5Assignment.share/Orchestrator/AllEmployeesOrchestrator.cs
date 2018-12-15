using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Week5Assignment.domain;
using Week5Assignment.share.Orchestrator.Interfaces;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Orchestrator
{
    public class AllEmployeesOrchestrator : IAllEmployeesOrchestrator
    {
        private EmployeeContext _allEmployeesContext;

        public AllEmployeesOrchestrator()
        {
            _allEmployeesContext = new EmployeeContext();
        }

        public async Task<List<AllEmployeesViewModel>> GetAllEmployees()
        {
            var allEmployees = await _allEmployeesContext.Employees
                .Select(x => new AllEmployeesViewModel
                {
                    EmployeeNum = x.EmployeeNum,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                }).ToListAsync();
            return allEmployees;
        }

    }
}