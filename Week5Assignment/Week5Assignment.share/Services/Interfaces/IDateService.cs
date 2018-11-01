using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
