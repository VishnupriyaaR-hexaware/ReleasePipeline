using dotnetmrabug.BusinessEntities.Entities;
using dotnetmrabug.Contracts.DTO;
using AutoMapper;
namespace dotnetmrabug.Api.Middleware
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
