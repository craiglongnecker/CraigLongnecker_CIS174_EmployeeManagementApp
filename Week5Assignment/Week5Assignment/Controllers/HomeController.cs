﻿using System.Web.Mvc;

namespace Week5Assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }
    }
}