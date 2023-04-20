using NSubstitute;
using testtttttttt.Test.Framework;
using testtttttttt.Api.Controllers;
using testtttttttt.BusinessServices.Interfaces;
using AutoMapper;
using testtttttttt.BusinessEntities.Entities;
using testtttttttt.Contracts.DTO;


namespace testtttttttt.Test.Api.UserControllerSpec
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
