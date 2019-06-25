using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitHubTest.DataContext;
using gitHubTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class NoteController : Controller
    {
        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            using (var db = new AspnetNoteDBContext())
            {
                var list = db.Notes.ToList();
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

        [HttpPost]
        public IActionResult Add(Note model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDBContext())
                {
                    db.Notes.Add(model);
                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("index"); // 동일한 컨드롤일경우 
                    }


                }

                ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
            }

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

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            return View();
        }
    }
}