using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RADLab3Solution.Models;

namespace Lab3Solution2025.Data
{
    public class Lab3Solution2025Context : DbContext
    {
        public Lab3Solution2025Context (DbContextOptions<Lab3Solution2025Context> options)
            : base(options)
        {
        }

        public DbSet<RADLab3Solution.Models.Book> Book { get; set; } = default!;
        public DbSet<RADLab3Solution.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<RADLab3Solution.Models.Author> Author { get; set; } = default!;
    }
}
