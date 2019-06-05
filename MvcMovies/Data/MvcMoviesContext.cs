using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovies.Models
{
    public class MvcMoviesContext : DbContext
    {
        public MvcMoviesContext (DbContextOptions<MvcMoviesContext> options)
            : base(options)
        {
        }

        // a DB set corresponds to a table in SQL
        // an entity corresponds to a row
        public DbSet<MvcMovies.Models.Film> Film { get; set; }
    }
}
