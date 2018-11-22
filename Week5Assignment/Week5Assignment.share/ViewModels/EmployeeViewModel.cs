using System;
using Week5Assignment.domain.Entities;

namespace Week5Assignment.share.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthDateString => BirthDate.ToString();
        public DateTime HireDate { get; set; }
        public String HireDateString => HireDate.ToString();
        public String Department { get; set; }
        public String JobTitle { get; set; }
        public decimal Salary { get; set; }
        public String SalaryString => Salary.ToString();
        public SalaryType SalaryType { get; set; }
        public String SalaryTypeString => SalaryType.ToString();
        public String AvailableHours { get; set; }
        public char MiddleInitial => MiddleName[0];
        public int YearsSinceHired => DateTime.Now.Year - HireDate.Year;
        public String Anniversary => String.Format("{0}/{1}/{2}", HireDate.Month, HireDate.Day, DateTime.Now.Year);
    }
}
