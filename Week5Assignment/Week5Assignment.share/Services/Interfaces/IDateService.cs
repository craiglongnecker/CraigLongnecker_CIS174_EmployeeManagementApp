using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Services.Interfaces
{
    public interface IDateService
    {
        bool IsTodayYourBirthday(EmployeeViewModel employee);
        bool IsTodayNotYourBirthday(EmployeeViewModel employee);
        bool IsTodayYourAnniversary(EmployeeViewModel employee);
        bool IsTodayNotYourAnniversary(EmployeeViewModel employee);
    }
}
