using dotnetbackend.Data.Interfaces;
using dotnetbackend.Entities.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Bindings;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetbackend.Data.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private IGateway _gateway;
        private string _collectionName = "Document";

        public DocumentRepository(IGateway gateway)
        {
            _gateway = gateway;
        }
        public IEnumerable<Document> GetAll()
        {
            var result = _gateway.GetMongoDB().GetCollection<Document>(_collectionName)
                            .Find(new BsonDocument())
                            .ToList();
            return result;
        }

        public bool Save(Document entity)
        {
            _gateway.GetMongoDB().GetCollection<Document>(_collectionName)
                .InsertOne(entity);
            return true;
        }

        public Document Update(string id, Document entity)
        {
            var update = Builders<Document>.Update
                .Set(e => e.Name, entity.Name )
                .Set(e => e.FileType, entity.FileType );

            var result = _gateway.GetMongoDB().GetCollection<Document>(_collectionName)
                .FindOneAndUpdate(e => e.Id == id, update);
            return result;
        }

        public bool Delete(string id)
        {
            var result = _gateway.GetMongoDB().GetCollection<Document>(_collectionName)
                         .DeleteOne(e => e.Id == id);
            return result.IsAcknowledged;
        }
    }
}
