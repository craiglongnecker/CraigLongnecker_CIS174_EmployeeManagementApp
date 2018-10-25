using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week5Assignment.domain.Entities;

namespace Week5Assignment.Models
{
    public class UpdateEmployeeModel
    {
        public Guid EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public String Department { get; set; }
        public String JobTitle { get; set; }
        public decimal Salary { get; set; }
        public SalaryType SalaryType { get; set; }
        public String AvailableHours { get; set; }
    }
}