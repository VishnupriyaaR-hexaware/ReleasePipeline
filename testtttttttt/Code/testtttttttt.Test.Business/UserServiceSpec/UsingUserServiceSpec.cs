using NSubstitute;
using testtttttttt.Test.Framework;
using testtttttttt.BusinessServices.Services;
using testtttttttt.Data.Interfaces;

namespace testtttttttt.Test.Business.UserServiceSpec
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