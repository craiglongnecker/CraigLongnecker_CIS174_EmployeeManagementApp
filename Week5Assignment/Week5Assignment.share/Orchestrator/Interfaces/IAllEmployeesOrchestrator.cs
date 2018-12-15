using System.Collections.Generic;
using System.Threading.Tasks;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Orchestrator.Interfaces
{
    public interface IAllEmployeesOrchestrator
    {
        Task<List<AllEmployeesViewModel>> GetAllEmployees();
    }
}
