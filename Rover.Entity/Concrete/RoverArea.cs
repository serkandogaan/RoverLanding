using MongoDB.Bson;
using Rover.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBTST.Entity.Concrete
{
    public class RoverArea : BaseClass
    {
        //public ObjectId Id { get; set; }
        //public int ID;
        public int X { get; set; }
        public int Y { get; set; }
        //public string Name { get; set; }
        public RoverArea(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
