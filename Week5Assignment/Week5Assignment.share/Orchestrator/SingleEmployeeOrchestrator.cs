using System.Data.Entity;
using System.Threading.Tasks;
using Week5Assignment.domain;
using Week5Assignment.share.Orchestrator.Interfaces;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Orchestrator
{
    public class SingleEmployeeOrchestrator : ISingleEmployeeOrchestrator
    {
        private EmployeeContext _singleEmployeeContext;

        public SingleEmployeeOrchestrator()
        {
            _singleEmployeeContext = new EmployeeContext();
        }

        public async Task<SingleEmployeeViewModel> GetEmployeeById(int EmployeeNum)
        {
            var employee = await _singleEmployeeContext.Employees
                .SingleOrDefaultAsync(x => x.EmployeeNum == EmployeeNum);

            if (employee == null)
                return new SingleEmployeeViewModel();

            return new SingleEmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate1 = employee.BirthDate1,
                Department = employee.Department
            };
        }
    }
}
