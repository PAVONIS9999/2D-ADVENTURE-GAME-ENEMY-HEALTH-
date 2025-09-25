using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class Position
    {
        //Private Field Declaration for x and y coordinates
        

        public Position(int X, int Y) //constructor with 2 parameters
        {
            this.X = X;
            this.Y = Y;

        }
        //properties for x and y coordinates

        public int X
        { get; set; }

        public int Y
        { get; set; }
           
      
    }
}
