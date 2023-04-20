using MongoDB.Driver;

namespace dotnetmrabug.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
