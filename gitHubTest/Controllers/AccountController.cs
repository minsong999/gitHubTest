using System.Linq;
using gitHubTest.DataContext;
using gitHubTest.Models;
using gitHubTest.ViewModel;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public IActionResult Login(LoginViewModel model) //파라미터를 받을 때 마이크로소프트 권장은 model로 받는다.
        {
            // ID, 비밀번호 - 필수 입력 값
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDBContext())
                {
                    // Linq 표현 쿼리식 - 메서드 체이닝
                    // => : Go to
                    // u : 람다식 익명 인수 
                    //var user = db.Users.
                    //    FirstOrDefault(u=>u.UserId == model.UserId && u.UserPassword == model.UserPassword); //메모리 누수 발생함
                    var user = db.Users.
                        FirstOrDefault(u => u.UserId.Equals(model.UserId) &&
                        u.UserPassword.Equals(model.UserPassword)); //첫번째 혹은 기본값을 출력함

                    if (user != null)
                    {
                        //로그인에 성공했을 때
                        //HttpContext.Session.SetInt32(key, value);
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("LoignSuccess", "Account"); //로그인에 성공 페이지로 이동
                    }
                }
                //로그인에 실패했을 때
                //사용자 ID 자체가 회원가입이 안 된 경우
                ModelState.AddModelError(string.Empty, "사용자 정보가 올바르지 않습니다.");
            }
            return View(model);
        }

        public IActionResult LoignSuccess()
        {
            //종속성 - Nuget packkage 설치 - Microsoft.AspNetCore.Session 
            
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Contents", "DevelopmentRabbit");
            //HttpContext.Session.Clear(); //모든 세션 제거
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

