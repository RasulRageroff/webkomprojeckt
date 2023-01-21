using Microsoft.EntityFrameworkCore;
using static Webmypcproject.Controllers.HomeController;

namespace Webmypcproject.Models
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<Logininacc> Logininaccs { get; set; }
       
    }
}
