using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Assignment.share.Services.Interfaces;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.share.Services
{
    public class DateService : IDateService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public bool IsTodayYourBirthday(EmployeeViewModel employee)
        {
            return employee.BirthDate?.DayOfYear == _dateTimeService.Now().DayOfYear;
        }

        public bool IsTodayNotYourBirthday(EmployeeViewModel employee)
        {
            return employee.BirthDate?.DayOfYear == _dateTimeService.Now().DayOfYear;
        }

        public bool IsTodayYourAnniversary(EmployeeViewModel employee)
        {
            return employee.HireDate?.DayOfYear == _dateTimeService.Now().DayOfYear;
        }

        public bool IsTodayNotYourAnniversary(EmployeeViewModel employee)
        {
            return employee.HireDate?.DayOfYear == _dateTimeService.Now().DayOfYear;
        }

        public int GetAge(DateTime BirthDate)
        {
            DateTime n = DateTime.Now;
            int age = n.Year - BirthDate.Year;

            if (n.Month < BirthDate.Month || (n.Month == BirthDate.Month && n.Day < BirthDate.Day))
                age--;

            return age;
        }

        public int GetAnniversary(DateTime HireDate)
        {
            DateTime n = DateTime.Now;
            int age = n.Year - HireDate.Year;

            if (n.Month < HireDate.Month || (n.Month == HireDate.Month && n.Day < HireDate.Day))
                age--;

            return age;
        }
    }
}
