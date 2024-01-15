using AutoMapper;
using Domain.Models;
using Shared.DTOs.SecurityDTOs;

namespace WebApiFoundations.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
