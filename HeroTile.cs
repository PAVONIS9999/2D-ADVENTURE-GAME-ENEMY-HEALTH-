using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class HeroTile : CharacterTile //inherting tile 
    {
        public HeroTile(Position position) : base(position, 40, 5)
        {
        }
        public override char Display // overriding
        {
            get
            {
                if (IsDead)

                    return 'X';
                else return '▼';
            }
        }

      
    }
}
