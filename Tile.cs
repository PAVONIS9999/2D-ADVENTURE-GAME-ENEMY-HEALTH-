using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    abstract class Tile
    {

        //properties to expose x and y values
        public Position Position { get; set; }
        public int X
        {
            get { return Position.X; }   
            set { Position.X = value; }
                
        }

        public int Y
        {
            get { return Position.Y; }
            set { Position.Y = value; }

        }

        public Tile(Position Position) //constructor that accepts a position parameter type
        {
            this.Position = Position;

        }
        //abstract property
        public abstract char Display
        { get; }
       
    }
}
