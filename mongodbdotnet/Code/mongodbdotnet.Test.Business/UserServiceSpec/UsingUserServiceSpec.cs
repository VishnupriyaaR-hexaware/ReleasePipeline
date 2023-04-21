using NSubstitute;
using mongodbdotnet.Test.Framework;
using mongodbdotnet.BusinessServices.Services;
using mongodbdotnet.Data.Interfaces;

namespace mongodbdotnet.Test.Business.UserServiceSpec
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