﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**==========================================================
Craig Longnecker
Operating System: Windows 10
Microsoft Visual Studio 2017 Enterprise
CIS 174
Name of Homework Assignment: Week 5 Assignment
Program Description: Create a proogram with web pages that show the list of
    employees and one that allows a person to add new employees into the
    employee management system so that employee information can be tracked
    and that can run reports on user data.
Academic Honesty:
I attest that this is my original work.
I have not used unauthorized source code, either modified or unmodified.
I have not given other fellow student(s) access to my program.
==========================================================**/

namespace Week5Assignment.domain.Entities
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public String Department { get; set; }
        public String JobTitle { get; set; }
        public Decimal Salary { get; set; }
        public SalaryType SalaryType { get; set; }
        public String AvailableHours { get; set; }
    }
    public enum SalaryType
    {
        Hourly,
        Annual
    }
}