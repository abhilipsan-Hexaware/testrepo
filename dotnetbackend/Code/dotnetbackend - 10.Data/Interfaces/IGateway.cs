using MongoDB.Driver;

namespace dotnetbackend - 10.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
