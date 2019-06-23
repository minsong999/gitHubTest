using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitHubTest.DataContext;
using gitHubTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace gitHubTest.Controllers
{
    public class NoteController : Controller
    {

        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            using(var db = new AspnetNoteDBContext())
            {
                var list = db.Notes.ToList(); //테이블 안의 모든 값을 가져올때 사용
                return View(list);
            }
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}