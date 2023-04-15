using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) : base (options) 
        {

        }

        public DbSet<News> News { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public string GetConectionString() 
        {
            string strcon = "";
            return strcon; 
        }
    }

}
