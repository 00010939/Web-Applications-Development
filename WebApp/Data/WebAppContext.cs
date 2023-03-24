using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.book> book { get; set; } = default!;

        public DbSet<WebApp.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<WebApp.Models.orders>? orders { get; set; }

        public DbSet<WebApp.Models.report>? report { get; set; }
    }
}
