using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{

    
    internal class WallTile : Tile // inherting tile class
    {
        public WallTile(Position Position) : base(Position) { }

        public override char Display //overiding display property in derivedd class(EmptyTile)
        {
            get
            {
                return '|'; // character for walltile
            }

        }


    }
}

    
           
        
        
     

      

       
    



    
