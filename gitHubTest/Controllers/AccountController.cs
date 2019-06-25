using gitHubTest.DataContext;
using gitHubTest.Models;
using gitHubTest.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspnetCoreStudy.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // ID, 비밀번호 - 필수
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDBContext())
                {
                    var user = db.Users
                        .FirstOrDefault(u => u.UserId.Equals(model.UserId)
                            && u.UserPassword.Equals(model.UserPassword));

                    if (user != null)
                    {
                        // 로그인 성공했을때
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("Index", "Home");
                    }

                }

                // 로그인 실패했을때'
                ModelState.AddModelError(string.Empty, "사용자 ID 또는 비밀번호가 올바르지 않습니다.");
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 회원가입 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDBContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}