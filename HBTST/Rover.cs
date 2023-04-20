using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBTST
{
    public class Rover
    {
        public int X;
        public int Y;
        public string Direction;

        public Rover(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
