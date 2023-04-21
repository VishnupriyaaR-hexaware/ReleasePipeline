using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using mongodbdotnet.BusinessEntities.Entities;
using mongodbdotnet.Contracts.DTO;
using mongodbdotnet.BusinessServices.Services;

namespace mongodbdotnet.Test.Api.UserControllerSpec
{
    public class When_updating_user : UsingUserControllerSpec
    {
        private ActionResult<UserDto > _result;
        private User _user;
        private UserDto _userDto;

        public override void Context()
        {
            base.Context();

            _user = new User
            {
                UserId = 81,
                UserName = "UserName",
                UserAge = 13,
                UserPresent = "UserPresent"
            };

            _userDto = new UserDto{
                    UserId = 38,
                    UserName = "UserName",
                    UserAge = 97,
                    UserPresent = "UserPresent"
            };

            _userService.Update(_user.Id, _user).Returns(_user);
            _mapper.Map<UserDto>(_user).Returns(_userDto);
            
        }
        public override void Because()
        {
            _result = subject.Update(_user.Id, _user);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _userService.Received(1).Update(_user.Id, _user);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<UserDto>();

            var resultList = resultListObject as UserDto;

            resultList.ShouldBe(_userDto);
        }
    }
}