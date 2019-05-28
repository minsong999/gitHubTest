using System;
using Microsoft.AspNetCore.Mvc;
using Dapper;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitHubTest.Controllers
{
    public class DevelopmentRabbitController : Controller
    {
        
        public IActionResult Contents()
        {
            return View();
        }

        public IActionResult introudceASPNET()
        {
            return View();
        }

        public IActionResult makeMVCCoreProject()
        {
            return View();
        }
    }
}
