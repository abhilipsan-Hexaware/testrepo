using MongoDB.Driver;

namespace dotnetbackend - 6.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
