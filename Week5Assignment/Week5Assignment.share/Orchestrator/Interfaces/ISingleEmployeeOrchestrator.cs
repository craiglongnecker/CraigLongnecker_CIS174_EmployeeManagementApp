using System.Threading.Tasks;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Orchestrator.Interfaces
{
    public interface ISingleEmployeeOrchestrator
    {
        Task<SingleEmployeeViewModel> GetEmployeeById(int EmployeeNum);
    }
}
