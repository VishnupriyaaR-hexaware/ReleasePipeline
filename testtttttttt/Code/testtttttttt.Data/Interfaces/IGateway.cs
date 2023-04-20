using MongoDB.Driver;

namespace testtttttttt.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
