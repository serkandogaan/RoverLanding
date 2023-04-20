using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBTST
{
    public class Rover
    {
        public int ID;
        public int X;
        public int Y;
        public string Direction;

        public Rover(int id, int x, int y, string direction)
        {
            ID = id;
            X = x;
            Y = y;
            Direction = direction;
        }
        public bool Move(string move)
        {
            if (move != "M" && move != "L" && move != "R")
            {
                return false;
            }

            if (move == "M")
            {
                if (Direction.ToUpper() == "N")
                {
                    Y += 1;
                }
                else if (Direction.ToUpper() == "S")
                {
                    Y -= 1;
                }
                else if (Direction.ToUpper() == "E")
                {
                    X += 1;
                }
                else if (Direction.ToUpper() == "W")
                {
                    X -= 1;
                }
                
            }
            else if (move == "L")
            {
                TurnLeft();
            }
            else if (move == "R")
            {
                TurnRight();
            }
            return true;
        }
        private void TurnLeft()
        {

            if (Direction.ToUpper() == "N")
            {
                Direction = "W";
            }
            else if (Direction.ToUpper() == "W")
            {
                Direction = "S";
            }
            else if (Direction.ToUpper() == "S")
            {
                Direction = "E";
            }
            else if (Direction.ToUpper() == "E")
            {
                Direction = "N";
            }
        }
        private void TurnRight()
        {
            if (Direction.ToUpper() == "N")
            {
                Direction = "E";
            }
            else if (Direction.ToUpper() == "E")
            {
                Direction = "S";
            }
            else if (Direction.ToUpper() == "S")
            {
                Direction = "W";
            }
            else if (Direction.ToUpper() == "W")
            {
                Direction = "N";
            }
        }

        public bool LandingArea(RoverArea roverArea)
        {
            if (roverArea.X < X && roverArea.Y < Y)
            {
                return false;
            }
            return true;

        }

        public string GetLocation()
        {
            return X + " " + Y + " " + Direction;
        }

        public bool CheckOtherRover(Rover rover)
        {
            if (rover.X == X && rover.Y == Y )
            {
                return false;
            }
            return true;
        }
    }
}
