using MongoDB.Driver;

namespace dotnetbackend - 1.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
