using MongoDB.Driver;

namespace dotnetbackend - 5.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
