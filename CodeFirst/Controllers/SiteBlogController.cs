using CodeFirst.Models.DTO;
using CodeFirst.Models.ORM.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class SiteBlogController : SiteBaseController
    {
        public ActionResult Index(int id, string title)
        {
            BlogPost blogpost = db.BlogPosts.FirstOrDefault(x => x.ID == id);
            SiteBlogPostDTO model = new SiteBlogPostDTO();

            model.Content = blogpost.Content;
            model.Title = blogpost.Title;
            model.PostImagePath = blogpost.ImagePath;
            model.Category = blogpost.Category.Name;
            return View(model);
        }
    }
}