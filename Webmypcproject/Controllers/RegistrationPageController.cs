using Microsoft.AspNetCore.Mvc;

namespace Webmypcproject.Controllers
{
    public class RegistrationPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
