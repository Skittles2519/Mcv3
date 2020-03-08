using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mcv3.Models
{
    public class Mcv3Context : DbContext
    {
        public Mcv3Context (DbContextOptions<Mcv3Context> options)
            : base(options)
        {
        }

        public DbSet<Mcv3.Models.Movie> Movie { get; set; }
    }
}
