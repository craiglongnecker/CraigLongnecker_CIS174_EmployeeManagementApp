﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Week5Assignment.api.Models;
using Week5Assignment.domain;
using Week5Assignment.share.Orchestrator;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();

            return employees;
        }
    }
}
