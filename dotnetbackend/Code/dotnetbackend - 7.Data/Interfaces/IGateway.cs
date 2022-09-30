using MongoDB.Driver;

namespace dotnetbackend - 7.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
