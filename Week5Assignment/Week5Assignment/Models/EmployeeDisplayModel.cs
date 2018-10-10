using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.Models
{
    public class EmployeeDisplayModel
    {
        public EmployeeDisplayModel(List<EmployeeViewModel> list)
        {
        }

        public List<EmployeeViewModel> Employee { get; set; }
    }
}