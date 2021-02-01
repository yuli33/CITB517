using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private CommentContext _db = new CommentContext();

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Comments()
        {
            var showComments = from comment in _db.Entries 
                               orderby comment.Time descending 
                               select comment;
            ViewBag.Comments = showComments.ToList();
            ViewBag.Db = _db;

            return View();
        }

        [HttpPost]
        public ActionResult Create(CommentModel commentModel)
        {
            CommentEntry commentEntry = new CommentEntry();

            commentEntry.FirstName = commentModel.FirstName;
            commentEntry.LastName = commentModel.LastName;
            commentEntry.Text = commentModel.Comment;
            commentEntry.Time = DateTime.Now;

            _db.Entries.Add(commentEntry);
            _db.SaveChanges();

            return RedirectToAction("Comments");
        }
    }
}