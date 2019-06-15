﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CensusApp.Data.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First Name Should be minimum of 3 and maximum of 25 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Last Name Should be minimum of 3 and maximum of 25 characters")]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Adress Should be minimum of 3 and maximum of 25 characters")]
        public string ResidentialAdress { get; set; }


        [Required]
        public string HomeTown { get; set; }

        [Required]
        public string LGAOfOrigin { get; set; }

        [Required]
        public string StateOfOrigin { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
