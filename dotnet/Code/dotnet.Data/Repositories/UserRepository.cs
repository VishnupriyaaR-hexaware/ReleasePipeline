using dotnet.Data.Interfaces;
using dotnet.BusinessEntities.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Bindings;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IGateway _gateway;
        private readonly string _collectionName = "User";

        public UserRepository(IGateway gateway)
        {
            _gateway = gateway;
        }
        public IEnumerable<User> GetAll()
        {
            var result = _gateway.GetMongoDB().GetCollection<User>(_collectionName)
                            .Find(new BsonDocument())
                            .ToList();
            return result;
        }

        public User Get(string id)
        {
            var result = _gateway.GetMongoDB().GetCollection<User>(_collectionName)
                            .Find(x => x.Id == id).Single();
            return result;
        }

        public bool Save(User entity)
        {
            _gateway.GetMongoDB().GetCollection<User>(_collectionName)
                .InsertOne(entity);
            return true;
        }

        public User Update(string id, User entity)
        {
            var update = Builders<User>.Update
                .Set(e => e.UserId, entity.UserId )
                .Set(e => e.UserName, entity.UserName )
                .Set(e => e.UserAge, entity.UserAge )
                .Set(e => e.UserPresent, entity.UserPresent );

            var result = _gateway.GetMongoDB().GetCollection<User>(_collectionName)
                .FindOneAndUpdate(e => e.Id == id, update);
            return result;
        }

        public bool Delete(string id)
        {
            var result = _gateway.GetMongoDB().GetCollection<User>(_collectionName)
                         .FindOneAndDelete(e => e.Id == id);
            if(result==null) return false;             
            return true;
        }
    }
}
