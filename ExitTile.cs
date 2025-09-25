using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class ExitTile : Tile
    {
        public ExitTile(Position Position) : base(Position)
        {

        }
        public override char Display //overiding display property in derivedd class(ExitTile)
        {
            get
            {
                return '▤';
            }

        }
    }
}
