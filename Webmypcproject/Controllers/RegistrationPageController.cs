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
    public class RegistrationPageController : Controller
    {
        RasulpcContext rasulpcContext = new RasulpcContext();
        [HttpGet]
        public IActionResult Index()
        {
            UsersInput usersInput = new UsersInput();



            return View(usersInput);
        }

        [HttpPost]
        public IActionResult Index(UsersInput usersInput)
        {

            if (rasulpcContext.Users.Count(x => x.Login == usersInput.Login) > 0)
            {
                var message = "kek";
            }
            else
            {
                try
                {
                    User userObj = new User()
                    {
                        Login = usersInput.Login,
                        Password = usersInput.Password,
                        IdRole = 2
                    };

                    rasulpcContext.Users.Add(userObj);
                    rasulpcContext.SaveChanges();


                }
                catch (Exception)
                {

                    throw;
                }
            }

            return View(usersInput);

        }

    }
}
