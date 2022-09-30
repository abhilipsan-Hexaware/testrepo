using MongoDB.Driver;

namespace dotnetbackend - 8.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
