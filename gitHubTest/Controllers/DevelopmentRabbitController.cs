using System;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Threading.Tasks;
using gitHubTest.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitHubTest.Controllers
{
    public class DevelopmentRabbitController : Controller
    {

        public IActionResult Contents()
        {
            return View();
        }

        public IActionResult IntroudceASPNET()
        {
            return View();
        }

        public IActionResult MakeMVCCoreProject()
        {
            return View();
        }

        public IActionResult UseLayout()
        {
            return View();
        }

        public IActionResult RazorSyntax()
        {
            return View();
        }

        public IActionResult MoveDataViewFromController()
        {
            //두가지 방법이 존재함
            //var firstUser = new User();
            //firstUser.userName = "홍길동";

            var hongUser = new User
            {
                UserNo = 1,
                UserName = "홍길동"
            };

            //#1 방식(View(model);
            //return View(hongUser);

            //#2 방식
            //ViewBag.hongUser = hongUser;
            //return View();

            //#3 방식
            ViewData["hongUserName"] = hongUser.UserName;
            ViewData["hongUserNo"] = hongUser.UserNo;
            return View();
        }

        public IActionResult EntityFramework()
        {
            return View();
        }

        public IActionResult MakeDatabaseWithEntityFramework()
        {
            return View();
        }

        public IActionResult MakeSignUpAndLogin()
        {
            return View();
        }
    }
}
