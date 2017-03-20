using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommentApp.Models;

namespace CommentApp.Controllers
{
    public class HomeController : Controller
    {
        private static Comment _comment = new Comment();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Json()
        {
            return Json(_comment.listComments, JsonRequestBehavior.AllowGet);
        }
    }
}