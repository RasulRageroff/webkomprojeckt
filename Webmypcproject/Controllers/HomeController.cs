using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webmypcproject.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;
using Webmypcproject.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Dapper;

namespace Webmypcproject.Controllers
{
    public class HomeController : Controller
    {
         
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            
            _logger = logger;
            _config = config;
            
        }

        public IActionResult Index()
       {
            var bdmodel = Connection;
            
           return View(bdmodel);
       }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        } 


        public class Logininacc
        {

        
            public string Login { get; set; }

            public string Password { get; set; }
        
                    
        
        }



    }
}