﻿// <auto-generated />
using System;
using CensusApp.Data.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CensusApp.Data.Migrations
{
    [DbContext(typeof(CensusDbContext))]
    partial class CensusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CensusApp.Data.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DateOfBirth")
                        .IsRequired();

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("HomeTown")
                        .IsRequired();

                    b.Property<string>("LGAOfOrigin")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("ResidentialAdress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("StateOfOrigin")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 6, 17, 11, 6, 31, 813, DateTimeKind.Local).AddTicks(4564),
                            DateOfBirth = "02/04/1987",
                            DateUpdated = new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(3416),
                            Email = "tony@gmail.com",
                            FirstName = "Anthony",
                            Gender = "Male",
                            HomeTown = "Oko",
                            LGAOfOrigin = "Aguata",
                            LastName = "Ikechukwu",
                            Occupation = "Civil Servant",
                            PhoneNumber = 9034544532L,
                            ResidentialAdress = "Ikeja Lagos",
                            StateOfOrigin = "Anambra"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4471),
                            DateOfBirth = "22/07/1989",
                            DateUpdated = new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4480),
                            Email = "omo@gmail.com",
                            FirstName = "Omoye",
                            Gender = "Fale",
                            HomeTown = "Alaba",
                            LGAOfOrigin = "Ojo",
                            LastName = "Adeleke",
                            Occupation = "Treader",
                            PhoneNumber = 7034374532L,
                            ResidentialAdress = "Lekki Lagos",
                            StateOfOrigin = "Lagos"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4494),
                            DateOfBirth = "13/10/1990",
                            DateUpdated = new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4494),
                            Email = "musa@gmail.com",
                            FirstName = "Adams",
                            Gender = "Male",
                            HomeTown = "Wuse",
                            LGAOfOrigin = "Wuse",
                            LastName = "Musa",
                            Occupation = "Farmer",
                            PhoneNumber = 8093544532L,
                            ResidentialAdress = "Festac Lagos",
                            StateOfOrigin = "Abuja"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
