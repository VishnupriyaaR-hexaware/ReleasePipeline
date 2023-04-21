using NSubstitute;
using dotnet.Test.Framework;
using dotnet.BusinessServices.Services;
using dotnet.Data.Interfaces;

namespace dotnet.Test.Business.UserServiceSpec
{
    public abstract class UsingUserServiceSpec : SpecFor<UserService>
    {
        protected IUserRepository _userRepository;

        public override void Context()
        {
            _userRepository = Substitute.For<IUserRepository>();
            subject = new UserService(_userRepository);

        }

    }
}