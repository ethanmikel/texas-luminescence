﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static TX_Luminescence.Models.SourceModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TX_Luminescence.Controllers
{
    // Controllers/HomeController.cs

    public class HomeController : Controller
    {
        //View Index 
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CurrentProjects()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Events()
        {
            return View();
        }
        [HttpGet]
        public ViewResult FAQs()
        {
            return View();
        }
    }
}