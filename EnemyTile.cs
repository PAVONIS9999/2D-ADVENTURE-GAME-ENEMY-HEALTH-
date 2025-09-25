using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    abstract class EnemyTile : CharacterTile
    {
        public EnemyTile(Position position ,int HitPoints, int AttackPower) : base(position, HitPoints,AttackPower)
        {
        
        }

        public abstract bool GetMove(out Tile tile); // method to indicate tile enemy will move to

        public abstract CharacterTile[] GetTargets(); 

    }
}
