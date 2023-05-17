using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Entity.Concrete
{
    public class RoverHistory : BaseClass
    {
        public int RoverID { get; set; }
        public int RoverAreaID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string StartingPosition { get; set; }
        public string EndingPosition { get; set; }
        public string Command { get; set; }

        public RoverHistory(int id, int roverID, int roverAreaID, DateTime dateTime, string startingPosition, string endingPosition, string command)
        {
            ID = id;
            RoverID = roverID;
            RoverAreaID = roverAreaID;
            CreatedDate = dateTime;
            StartingPosition = startingPosition;
            EndingPosition = endingPosition;
            Command = command;
        }       

        public RoverHistory(int id, int roverID, int roverAreaID, DateTime dateTime, string startingPosition, string command)
        {
            ID = id;
            RoverID = roverID;
            RoverAreaID = roverAreaID;
            CreatedDate = dateTime;
            StartingPosition = startingPosition;
            Command = command;
        }
    }
}