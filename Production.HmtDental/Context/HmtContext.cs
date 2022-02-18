using Microsoft.EntityFrameworkCore;
using Production.HmtDental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Context
{
    public class HmtContext : DbContext
    {
        private readonly DbContextOptions _options;

        public HmtContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SupportUser> SupportUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<New> New { get; set; }
        public DbSet<Background> Background { get; set; }
    }
}
