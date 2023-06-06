using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample1.Models;

namespace Sample1.Data
{
    public class Sample1Context : DbContext
    {
        public Sample1Context (DbContextOptions<Sample1Context> options)
            : base(options)
        {
        }

        public DbSet<Sample1.Models.Movie> Movie { get; set; } = default!;
    }
}
