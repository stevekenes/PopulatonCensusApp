using CensusApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CensusApp.Data.ContextClasses
{
    public static class CensusSeederClass
    {
        public static void SeedPersonData(this ModelBuilder builder)
        {
            builder.Entity<Person>().HasData(
                new Person[]
                {
                });
        }
    }
}
