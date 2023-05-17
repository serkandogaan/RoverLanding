using HBTST.Entity.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList;
using System.Collections.Generic;
using System.Linq;


namespace HBTST.DataAccess
{

    public class RoverDAL
    {
        
        public static IMongoClient mongoClient = new MongoClient();
        public static IMongoDatabase mongoDatabase = mongoClient.GetDatabase("RoverDataBase");
        public IMongoCollection<Entity.Concrete.Rover> mongoCollection = mongoDatabase.GetCollection<Entity.Concrete.Rover>("Rover");

        List<Entity.Concrete.Rover> roverList = new List<Entity.Concrete.Rover>();
        public RoverDAL()
        {
          
        }    
        public bool Add(Entity.Concrete.Rover rover)
        {
            if (rover == null)
            {
                return false;
            }
            mongoCollection.InsertOne(rover);
            return true;
        }
        public bool Delete(string id)
        {
            mongoCollection.DeleteOne(x => x.Id == ObjectId.Parse(id));
            return true;
        }

        public IPagedList<Entity.Concrete.Rover> PagedRoverList(int pageNumber = 1)
        {
            IPagedList<Entity.Concrete.Rover> list = mongoCollection.AsQueryable().OrderBy(x => x.Name).ToPagedList(pageNumber, 10);
            return list;
        }
        public List<Entity.Concrete.Rover> Gets()
        {
            List<Entity.Concrete.Rover> list = mongoCollection.AsQueryable().ToList();
            return list;
        }      
        public int ListCount()
        {
            return roverList.Count() + 1;
        }
        public bool CheckListRover(int x, int y)
        {
            foreach (var listRover in Gets())
            {
                if (listRover.X == x && listRover.Y == y)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRoverArea(int x, int y, Entity.Concrete.Rover rover)
        {
            if (x < rover.X || y < rover.Y)
            {
                return false;
            }
            return true;
        }
    }
}