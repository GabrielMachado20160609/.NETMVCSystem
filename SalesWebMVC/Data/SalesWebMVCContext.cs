using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Department> Department { get; set; } = default!;
        public DbSet<Models.SalesRecord> SalesRecord { get; set; } = default!;
        public DbSet<Models.Seller> Seller { get; set; } = default!;
    }
}
