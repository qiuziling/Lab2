using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Car> Car { get; set; }

        public DbSet<WebApi.Models.Member> Member { get; set; }

        public DbSet<WebApi.Models.Dealership> Dealership { get; set; }
    }
}
