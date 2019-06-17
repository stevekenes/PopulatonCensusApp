using CensusApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CensusApp.Data.ContextClasses
{
    public static class CensusSeedingClass
    {
        public static void SeedPersonData(this ModelBuilder builder)
        {
            builder.Entity<Person>().HasData(
                new Person[]
                {
                    new Person { Id = 1, FirstName = "Anthony", LastName = "Ikechukwu", Gender = "Male", DateOfBirth = "02/04/1987", HomeTown = "Oko",
                        LGAOfOrigin = "Aguata", StateOfOrigin = "Anambra", ResidentialAdress = "Ikeja Lagos", Occupation = "Civil Servant",
                        PhoneNumber = 09034544532, Email = "tony@gmail.com", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },

                    new Person { Id = 2, FirstName = "Omoye", LastName = "Adeleke", Gender = "Fale", DateOfBirth = "22/07/1989", HomeTown = "Alaba",
                        LGAOfOrigin = "Ojo", StateOfOrigin = "Lagos", ResidentialAdress = "Lekki Lagos", Occupation = "Treader",
                        PhoneNumber = 07034374532, Email = "omo@gmail.com", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },

                    new Person { Id = 3, FirstName = "Adams", LastName = "Musa", Gender = "Male", DateOfBirth = "13/10/1990", HomeTown = "Wuse",
                        LGAOfOrigin = "Wuse", StateOfOrigin = "Abuja", ResidentialAdress = "Festac Lagos", Occupation = "Farmer",
                        PhoneNumber = 08093544532, Email = "musa@gmail.com", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                });
        }
    }
}
