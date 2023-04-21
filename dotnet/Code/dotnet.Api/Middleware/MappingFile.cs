using dotnet.BusinessEntities.Entities;
using dotnet.Contracts.DTO;
using AutoMapper;
namespace dotnet.Api.Middleware
{
public class MappingFile : Profile
{
    public MappingFile()
    {
        // Mapping variables
		CreateMap<User , UserDto>(); 
    }
  }
}
