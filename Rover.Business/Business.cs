using System;
using System.Collections.Generic;
using System.Linq;
using HBTST.Entity.Concrete;

namespace Rover.Business
{
    public class Business
    {

        public List<Entity.Concrete.Rover> roverList = new List<Entity.Concrete.Rover>();
        public void Add(Entity.Concrete.Rover rover)
        {
            roverList.Add(rover);
        }     

        public bool Move(Entity.Concrete.Rover rovers, string move)
        {
            if (move != "M" && move != "L" && move != "R")
            {
                return false;
            }

            if (move == "M")
            {
                if (rovers.Direction == "N")
                {
                    rovers.Y += 1;
                }
                else if (rovers.Direction == "S")
                {
                    rovers.Y -= 1;
                }
                else if (rovers.Direction == "E")
                {
                    rovers.X += 1;
                }
                else if (rovers.Direction == "W")
                {
                    rovers.X -= 1;
                }

            }

            else if (move == "L")
            {
                TurnLeft(rovers);
            }
            else if (move == "R")
            {
                TurnRight(rovers);
            }
            return true;
        }

        private void TurnLeft(Entity.Concrete.Rover rovers)
        {

            if (rovers.Direction == "N")
            {
                rovers.Direction = "W";
            }
            else if (rovers.Direction == "W")
            {
                rovers.Direction = "S";
            }
            else if (rovers.Direction == "S")
            {
                rovers.Direction = "E";
            }
            else if (rovers.Direction == "E")
            {
                rovers.Direction = "N";
            }
        }
        private void TurnRight(Entity.Concrete.Rover rovers)
        {
            if (rovers.Direction == "N")
            {
                rovers.Direction = "E";
            }
            else if (rovers.Direction == "E")
            {
                rovers.Direction = "S";
            }
            else if (rovers.Direction == "S")
            {
                rovers.Direction = "W";
            }
            else if (rovers.Direction == "W")
            {
                rovers.Direction = "N";
            }
        }

        public int SetRoverID()
        {
            return roverList.Count() + 1;
        }

        public bool CheckRoversLandingArea(RoverArea roverArea, Entity.Concrete.Rover rovers)
        {
            if (roverArea.X < rovers.X && roverArea.Y < rovers.Y)
            {
                return false;
            }
            return true;

        }
        public bool CheckOtherRover(Entity.Concrete.Rover rovers)
        {
            foreach (var otherRovers in roverList)
            {
                if (rovers.X == otherRovers.X && rovers.Y == otherRovers.Y)
                {
                    return false;
                }             
            }
            return true;
        }

        public bool CheckRoverMove(Entity.Concrete.Rover rovers)
        {
            bool Write()
            {
                Console.WriteLine("Önümde Rover var, haraket edemem");
                return false;
            }

            foreach (var otherRovers in roverList)
            {

                if (rovers.X == otherRovers.X && rovers.Y + 1 == otherRovers.Y)
                {
                    Write();
                }
                else if (rovers.X == otherRovers.X && rovers.Y - 1 == otherRovers.Y)
                {
                    Write();
                }
                else if (rovers.X - 1 == otherRovers.X && rovers.Y == otherRovers.Y)
                {
                    Write();
                }
                else if (rovers.X + 1 == otherRovers.X && otherRovers.Y == rovers.Y)
                {
                    Write();
                }

            }
            return true;
        }
        public void ListRovers()
        {
            
            foreach (var rovers in roverList)
            {
                Console.WriteLine("Rover ID : " + rovers.ID + " Rover X : " + rovers.X + " Rover Y : " + rovers.Y + " Rover Yön : " + rovers.Direction.ToUpper());
            }

        }

    }
}
