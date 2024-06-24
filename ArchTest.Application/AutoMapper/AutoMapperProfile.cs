using ArchTest.Application.DTOs;
using ArchTest.Domain.Entities;
using AutoMapper;

namespace ArchTest.Application.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
    }
}
