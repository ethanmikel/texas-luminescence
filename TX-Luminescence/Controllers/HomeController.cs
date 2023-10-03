using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace base_folders_files.Controllers
{
    // Controllers/HomeController.cs

    public class HomeController : Controller
    {
        public ActionResult CurrentProjects()
        {
            // Logic to fetch and prepare data for the "CurrentProjects" page
            var projects = GetProjects(); // Example: Load current projects
            return View("CurrentProjects", projects);
        }

        public ActionResult Events()
        {
            // Logic to fetch and prepare data for the "Events" page
            var events = GetEvents(); // Example: Load all events
            return View("Events", events);
        }

        public ActionResult FAQs()
        {
            // Logic to fetch and prepare data for the "FAQs" page
            var faqs = GetFAQs(); // Example: Load all FAQs
            return View("FAQs", faqs);
        }
    }
}