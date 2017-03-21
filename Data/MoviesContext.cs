using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviesWebApplication.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesWebApplication.Models.Movie> Movie { get; set; }
    }
}
