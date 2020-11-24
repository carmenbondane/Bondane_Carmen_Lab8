using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bondane_Carmen_Lab8.Models;

namespace Bondane_Carmen_Lab8.Data
{
    public class Bondane_Carmen_Lab8Context : DbContext
    {
        public Bondane_Carmen_Lab8Context (DbContextOptions<Bondane_Carmen_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bondane_Carmen_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bondane_Carmen_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bondane_Carmen_Lab8.Models.Category> Category { get; set; }
    }
}
