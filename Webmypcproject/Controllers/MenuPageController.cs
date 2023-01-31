using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webmypcproject.Controllers
{
    public class MenuPageController : Controller
    {
        // GET: MenuPageController
        public ActionResult Index()
        {
            return View();
        }

    }
}
