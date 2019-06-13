using gitHubTest.DataContext;
using gitHubTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace gitHubTest.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet] //default 값이 [HttpGet]이다.
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid) //Model에서 Required, Key 어노테이션 된 걸 모두 받았는지를 확인함.
            {
                using (var db = new AspnetNoteDBContext())
                {
                    db.Users.Add(model); //메모리 상에 추가
                    db.SaveChanges(); //실제로 DB에 저장하고 commit 
                }
                return RedirectToAction("Register","Account");
            }
            return View();
        }
    }
}

