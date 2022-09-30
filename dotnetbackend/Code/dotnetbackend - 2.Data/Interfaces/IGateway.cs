using MongoDB.Driver;

namespace dotnetbackend - 2.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
