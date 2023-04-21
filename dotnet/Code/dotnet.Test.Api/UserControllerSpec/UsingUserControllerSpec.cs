using NSubstitute;
using dotnet.Test.Framework;
using dotnet.Api.Controllers;
using dotnet.BusinessServices.Interfaces;
using AutoMapper;
using dotnet.BusinessEntities.Entities;
using dotnet.Contracts.DTO;


namespace dotnet.Test.Api.UserControllerSpec
{
    public abstract class UsingUserControllerSpec : SpecFor<UserController>
    {
        protected IUserService _userService;
        protected IMapper _mapper;

        public override void Context()
        {
            _userService = Substitute.For<IUserService>();
            _mapper = Substitute.For<IMapper>();
            subject = new UserController(_userService,_mapper);

        }

    }
}
