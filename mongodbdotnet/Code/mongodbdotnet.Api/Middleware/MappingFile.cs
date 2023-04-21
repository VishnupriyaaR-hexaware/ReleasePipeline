using mongodbdotnet.BusinessEntities.Entities;
using mongodbdotnet.Contracts.DTO;
using AutoMapper;
namespace mongodbdotnet.Api.Middleware
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
