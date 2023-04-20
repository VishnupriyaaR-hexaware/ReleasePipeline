using NSubstitute;
using dotnetmrabug.Test.Framework;
using dotnetmrabug.Api.Controllers;
using dotnetmrabug.BusinessServices.Interfaces;
using AutoMapper;
using dotnetmrabug.BusinessEntities.Entities;
using dotnetmrabug.Contracts.DTO;


namespace dotnetmrabug.Test.Api.UserControllerSpec
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
