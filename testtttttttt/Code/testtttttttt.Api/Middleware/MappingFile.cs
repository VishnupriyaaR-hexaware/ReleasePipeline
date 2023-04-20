using testtttttttt.BusinessEntities.Entities;
using testtttttttt.Contracts.DTO;
using AutoMapper;
namespace testtttttttt.Api.Middleware
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
