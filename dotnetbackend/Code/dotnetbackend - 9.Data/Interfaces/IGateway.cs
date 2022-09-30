using MongoDB.Driver;

namespace dotnetbackend - 9.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
