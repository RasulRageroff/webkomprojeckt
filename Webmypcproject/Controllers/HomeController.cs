using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webmypcproject.Models;
using Webmypcproject.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Collections.Generic;



using Dapper;
using System.Security.Claims;

namespace Webmypcproject.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IConfiguration config, RasulpcContext rasulpcContext)
        {
            
            _logger = logger;
            _config = config;
            
        }
        [HttpGet]
        public IActionResult Index()
       {
            UsersInput usersinput = new UsersInput();
          

            //RasulpcContext rasulpcContext;
            //User userContext = new User();

           

            return View(usersinput);
       }
        [HttpPost]
        public IActionResult Index(UsersInput usersinput)
        {
            RasulpcContext rasulpcContext = new RasulpcContext();
            var status = rasulpcContext.Users.Where(m => m.Login == usersinput.Login && m.Password == usersinput.Password).FirstOrDefault();
            if(status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                switch (status.IdRole)
                {
                    case 1:
                       

                        break;
                    case 2:
                        return RedirectToAction("Menu", "Home");
                        break;
                }
            }



            return View(usersinput);
        }

        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Menu()
        {
            return View();
        }







    }
}