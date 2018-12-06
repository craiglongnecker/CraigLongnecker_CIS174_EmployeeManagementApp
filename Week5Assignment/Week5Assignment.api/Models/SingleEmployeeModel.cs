using System;

namespace Week5Assignment.api.Models
{
    public class SingleEmployeeModel
    {
        public int EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String BirthDate { get; set; }
        public String Department { get; set; }
    }
}