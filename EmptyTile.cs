using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class EmptyTile : Tile
    {
        //constructor accepting position parameter and passing it on to base class
        public EmptyTile(Position position) : base(position)
        {
        }

        public override char Display //overiding display property in derivedd class(EmptyTile)
        {
            get
            {
                return '.';
            }
        
        }
    }
}
