using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using dotnetmrabug.BusinessEntities.Entities;
using dotnetmrabug.Contracts.DTO;

namespace dotnetmrabug.Test.Api.UserControllerSpec
{
    public class When_getting_all_user : UsingUserControllerSpec
    {
        private ActionResult<IEnumerable<UserDto>> _result;

        private IEnumerable<User> _all_user;
        private User _user;

        private IEnumerable<UserDto>  _all_userDto;
        private UserDto _userDto;
    

        public override void Context()
        {
            base.Context();

            _user = new User{
                UserId = 35,
                UserName = "UserName",
                UserAge = 48,
                UserPresent = "UserPresent"
            };

            _userDto = new UserDto{
                    UserId = 38,
                    UserName = "UserName",
                    UserAge = 19,
                    UserPresent = "UserPresent"
                };

            _all_user = new List<User> { _user};
            _userService.GetAll().Returns(_all_user);
            _all_userDto  = new List<UserDto> {_userDto};
            _mapper.Map<IEnumerable<UserDto>>(_all_user).Returns( _all_userDto);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _userService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<UserDto>>();

            List<UserDto> resultList = resultListObject as List<UserDto>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_userDto);
        }
    }
}