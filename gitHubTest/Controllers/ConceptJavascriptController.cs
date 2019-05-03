using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gitHubTest.Models;


namespace gitHubTest.Controllers
{
    public class ConceptJavascriptController : Controller
    {
        public IActionResult CallStack()
        {
            return View();
        }
    }
}
