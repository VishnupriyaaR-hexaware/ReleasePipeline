using NSubstitute;
using dotnetmrabug.Test.Framework;
using dotnetmrabug.BusinessServices.Services;
using dotnetmrabug.Data.Interfaces;

namespace dotnetmrabug.Test.Business.UserServiceSpec
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