using MongoDB.Driver;

namespace mongodbdotnet.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
