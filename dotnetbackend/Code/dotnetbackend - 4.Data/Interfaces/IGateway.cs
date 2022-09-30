using MongoDB.Driver;

namespace dotnetbackend - 4.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
