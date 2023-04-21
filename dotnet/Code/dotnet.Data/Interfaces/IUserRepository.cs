using dotnet.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.Data.Interfaces
{
    public interface IUserRepository : IGetAll<User>,IGet<User,string>, ISave<User>, IUpdate<User, string>, IDelete<string>
    {
    }
}
