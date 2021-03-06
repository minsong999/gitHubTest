﻿using System;
using Microsoft.AspNetCore.Mvc;
using Dapper;
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
            int numPlusOne = Add(num, 1);
            Console.WriteLine(numPlusOne);
            return View();
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public IActionResult ifAndValidation()
        {
            String abc = "";
            if (abc == "") { }
            if (String.IsNullOrWhiteSpace(abc)) { } //null, "", "빈 스페이스값만 있는지" 체크
            if (String.IsNullOrEmpty(abc)) { } //null , "" 체크


            int number = 1;
            abc = "1";

            Boolean blabla = true;
            if (int.TryParse(abc, out number) == false) { //abc라는 스트링 값이 숫자로 변환이 가능하다면 number에 넣고 true를 리턴함
                Console.WriteLine("문자 abc는 숫자로 변환할 수 없는 값입니다.");
            }

            if (blabla)
            {
                Console.WriteLine("blabla가 true이니까 실행");
            }
            else
            {
                Console.WriteLine("blabla가 false이니까 실행");
            }

            //값 비교 연산자 ==, !=, >, >=, ,< ,<= 
            return View();
        }

        public IActionResult accessModifier()
        {
            //public
            //private
            //protected
            //

            Models.Cat myCat = new Models.Cat(13,"졸린고양이");

            return View(model: myCat);
        }

        public IActionResult CSharpDateTime()
        {
            //prop + tab 을 하면 코드 getset 자동생성을 할 수 있다.
            DateTime date = new DateTime(2016, 2, 28);
            DateTime current = DateTime.Now; // 이코드가 실행 될 때의 시간

            return View();
        }

        public IActionResult forAndWhile()
        {
            //if (A == B)
            //{yourcode}
            //else if
            //{yourcode}
            //else
            //{yourcode}

            //for(int i=0; i<=10; i++) {} i값 정의, 반복이 지속되는 조건, i값 변화식

            //while(조건식){yourcode}

            //Dapper는 프로젝트 우클릭 -> nuget 패키지 관리에서 dapper 검색후 다운로드하여 .cs 파일 상단에 using Dapper로 사용할 수 있다. 
            return View();
        }
    }
}
