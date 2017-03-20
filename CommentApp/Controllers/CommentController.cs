using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommentApp.Models;
using System.Web.UI;

namespace CommentApp.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        private static Comment _comment = new Comment();

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Index()
        {
            return View(_comment.listComments);
        }

        public ActionResult InsertComment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertComment(CommentModels _commentModel)
        {
            if (_comment.listComments.Count > 0)
            {
                _commentModel.id = _comment.listComments[_comment.listComments.Count - 1].id + 1;
            }
            else
            {
                _commentModel.id = 1;
            }
            _commentModel.insert = DateTime.Now;
            _comment.InsertComment(_commentModel);
            return RedirectToAction("Index");
        }

        public ViewResult DeleteComment(int id)
        {
            return View(_comment.GetComment(id));

        }

        [HttpPost]
        public RedirectToRouteResult DeleteComment(int id, FormCollection collection)
        {
            _comment.DeleteComment(id);
            return RedirectToAction("Index");
        }
    }
}