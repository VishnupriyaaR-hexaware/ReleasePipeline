using MongoDB.Driver;

namespace Dotnetest.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
