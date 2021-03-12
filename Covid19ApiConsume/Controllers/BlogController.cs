using System.Web.Mvc;

namespace Covid19ApiConsume.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}