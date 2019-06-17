using CensusApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CensusApp.Data.ContextClasses
{
    public class CensusDbContext : DbContext
    {
        public CensusDbContext(DbContextOptions<CensusDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedPersonData();
        }

    }
}
