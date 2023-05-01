using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBTST.Entity.Concrete
{
    public class Rover
    {
        public int ID;
        public int X;
        public int Y;
        public string Direction;
        public string Name;

        public Rover(int x, int y, string direction, string name)
        {      
            X = x;
            Y = y;
            Direction = direction;
            Name = name;
            
        }
        public Rover(int id, int x, int y, string direction, string name)
            : this(x, y, direction,name)
        {
            ID = id;
        }
        public bool Move(string move)
        {
            if (move != "M" && move != "L" && move != "R")
            {
                return false;
            }

            if (move == "M")
            {
                if (Direction == "N")
                {
                    Y += 1;
                }
                else if (Direction == "S")
                {
                    Y -= 1;
                }
                else if (Direction == "E")
                {
                    X += 1;
                }
                else if (Direction == "W")
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

            if (Direction == "N")
            {
                Direction = "W";
            }
            else if (Direction == "W")
            {
                Direction = "S";
            }
            else if (Direction == "S")
            {
                Direction = "E";
            }
            else if (Direction == "E")
            {
                Direction = "N";
            }
        }
        private void TurnRight()
        {
            if (Direction == "N")
            {
                Direction = "E";
            }
            else if (Direction == "E")
            {
                Direction = "S";
            }
            else if (Direction == "S")
            {
                Direction = "W";
            }
            else if (Direction == "W")
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

        public bool LandingArea(int x, int y)
        {
            if (x < X || y < Y)
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
            if (rover.X == X && rover.Y == Y)
            {
                return false;
            }

            return true;
        }

        public bool CanIMove(int i, params Rover[] rover)
        {
            if (rover[i].X == X && rover[i].Y - 1 == Y && Direction == "N")
            {
                return false;
            }
            else if (rover[i].X - 1 == X && rover[i].Y == Y && Direction == "E")
            {
                return false;
            }
            else if (rover[i].X + 1 == X && rover[i].Y == Y && Direction == "W")
            {
                return false;
            }
            else if (rover[i].X == X && rover[i].Y + 1 == Y && Direction == "S")
            {
                return false;
            }
            return true;
        }
    }
}
