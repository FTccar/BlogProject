using CodeFirst.Areas.Admin.Models.DTO;
using CodeFirst.Models.ORM.Entity;
using CodeFirst.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class SiteHomeController : SiteBaseController
    {
        public ActionResult Index()
        {
            List<BlogPostDTO> model = db.BlogPosts.Select(x => new BlogPostDTO()
            {
                CategoryID = x.CategoryID,
                Content = x.Content,
                ID = x.ID,
                //PostImage = x.ImagePath,
                Title = x.Title
            }).OrderByDescending(x=>x.ID).ToList();

            return View(model);
        }

        public ActionResult AddComment(CommentDTO model)
        {
            BlogPostComment comment = new BlogPostComment();
            comment.Title = model.Title;
            comment.Content = model.Content;
            db.BlogPostComments.Add(comment);
            db.SaveChanges();

            return RedirectToAction("Index", "SiteBlog", new{ id= model.BlogPostID});
        }
    }
}