using HBTST.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;


namespace HBTST.DataAccess
{
    public class RoverDAL
    {
        List<Rover> roverList = new List<Rover> { new Rover(1, 5, 6, "N", "Rover1"), new Rover(2, 3, 3, "W", "Rover2") };
        public RoverDAL()
        {
            Add(new Rover(4, 5, 5, "N", "Serkan"));
            Add(new Rover(4, 8, 9, "N", "Furkan"));
        }
        public bool Add(Rover rover)
        {
            foreach (var item in roverList)
            {
                if (item.ID == rover.ID)
                {
                    return false;
                }
            }


            int lastRoverID = roverList.Last().ID;
            rover.ID = lastRoverID + 1;
            roverList.Add(rover);
            return true;
        }
        public bool Delete(int id)
        {
            List<Rover> roverListWithoutDeletedRover = new List<Rover>();
            //int index = roverList.FindIndex(x => x.ID == id);         
            //roverList.RemoveAt(index);
            //return true;

            //foreach (var item in Gets())
            //{
            //    if (item.ID == id)
            //    {
            //        roverList.Remove(item);
            //        return true;
            //    }
            //}
            //return true;

            //roverList.RemoveAll(x => x.ID == id);

            foreach (var item in Gets())
            {
                if (item.ID != id)
                {
                    roverListWithoutDeletedRover.Add(item);
                }
            }
            roverList = roverListWithoutDeletedRover;
            return true;
        }
        public List<Rover> Gets()
        {
            return roverList;
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

        public bool CheckRoverArea(int x, int y, Rover rover)
        {
            if (x < rover.X || y < rover.Y)
            {
                return false;
            }
            return true;
        }
    }
}