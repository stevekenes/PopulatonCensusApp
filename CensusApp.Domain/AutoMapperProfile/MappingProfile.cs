using AutoMapper;
using CensusApp.Data.Entities;
using CensusApp.Domain.RequestModels;
using CensusApp.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CensusApp.Domain.AutoMapperProfile
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonResponse>();
            CreateMap<PersonRequest, Person>();
        }
    }
}
