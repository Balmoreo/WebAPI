using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Pais> Pais { get; set; }

        public DbSet<WebAPI.Models.Usuarios> Usuarios { get; set; }

        public DbSet<WebAPI.Models.Actividades> Actividades { get; set; }
    }
}
