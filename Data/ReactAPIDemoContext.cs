using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactAPIDemo.Models;

namespace ReactAPIDemo.Data
{
    public class ReactAPIDemoContext : DbContext
    {
        public ReactAPIDemoContext (DbContextOptions<ReactAPIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ReactAPIDemo.Models.SuperHero> SuperHero { get; set; } = default!;
    }
}
