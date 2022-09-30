using MongoDB.Driver;

namespace dotnetbackend - 3.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
