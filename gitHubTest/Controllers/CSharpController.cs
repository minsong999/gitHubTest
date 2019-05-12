using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gitHubTest.Controllers
{
    public class CSharpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult helloCSharp()
        {
            Console.WriteLine("Hello C#"); //보기 - 출력 - 출력보기 선택에서 ASP.NET Core 웹 서버을 선택하면 확인할 수 있다.
            return View();
        }

        public IActionResult dataType()
        {
            //윈폼을 설명하는데 잘 안 쓰니까... -> ToolBox로 끌어다가 디자인적 요소를 쓸 수 있고 소스보기로 소스를 작성할 수 있다.
            int num1 = 10;
            string operator1 = "+";
            bool isCorrect = true;

            
            return View();
        }

        public IActionResult convert()
        {
            String Sum1 = "1";
            int num = Convert.ToInt32(Sum1);       //문자 -> 숫자 변환
            String num2 = Convert.ToString(num);   //숫자 -> 문자 변환

            float num3 = 3.14f;
            double num4 = 3.25;
            int numPlusOne=Add(num, 1);
            Console.WriteLine(numPlusOne);
            return View();
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
    }
}
