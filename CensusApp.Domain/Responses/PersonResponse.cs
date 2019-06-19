using System;
using System.Collections.Generic;
using System.Text;

namespace CensusApp.Domain.Responses
{
    public class PersonResponse
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }   
        public string Gender { get; set; }    
        public string DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public string ResidentialAdress { get; set; }
        public string HomeTown { get; set; }
        public string LGAOfOrigin { get; set; }
        public string StateOfOrigin { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
