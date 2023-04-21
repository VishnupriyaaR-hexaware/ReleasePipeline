using NSubstitute;
using mongodbdotnet.Test.Framework;
using mongodbdotnet.Api.Controllers;
using mongodbdotnet.BusinessServices.Interfaces;
using AutoMapper;
using mongodbdotnet.BusinessEntities.Entities;
using mongodbdotnet.Contracts.DTO;


namespace mongodbdotnet.Test.Api.UserControllerSpec
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
