using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Itu_AnaBianca_Lab8.Models;

namespace Itu_AnaBianca_Lab8.Data
{
    public class Itu_AnaBianca_Lab8Context : DbContext
    {
        public Itu_AnaBianca_Lab8Context (DbContextOptions<Itu_AnaBianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Itu_AnaBianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Itu_AnaBianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Itu_AnaBianca_Lab8.Models.Category> Category { get; set; }
    }
}
