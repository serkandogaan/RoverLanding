using MongoDB.Driver;
using Repositories.Abstract;
using Rover.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class MongoGenericRepository<T> : IMongoGenericRepository<T> where T : BaseClass
    {
        protected readonly IMongoCollection<T> Collection;

        public MongoGenericRepository()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = mongoClient.GetDatabase("RoverDataBase");
            Collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
        }
        public void Add(T entity)
        {
            Collection.InsertOne(entity);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return Collection.AsQueryable().ToList();
        }

        public T GetByID(int id)
        {
            return (T)Collection.Find(x => x.ID == id).FirstOrDefault();
        }

        public T GetByName(string name)
        {
            return (T)Collection.Find(x => x.Name == name).FirstOrDefault();
        }

        public List<T> GetbyWhere(Expression<Func<T, bool>> filter)
        {
            return Collection.AsQueryable().Where(filter).ToList();
        }

        //public string GetRoverAreaNamebyID(int id)
        //{
        //    return Collection.AsQueryable().Where(x => x.ID == id).Select(x => x.Name).FirstOrDefault();
        //    throw new NotImplementedException();
        //}

        //public string GetRoverNamebyID(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(T entity)
        {
            Collection.FindOneAndReplace(x => x.Id == entity.Id, entity);
        }
    }
}
