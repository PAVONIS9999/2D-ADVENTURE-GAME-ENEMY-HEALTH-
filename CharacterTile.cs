using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    
        abstract class CharacterTile : Tile //creating abstract class called charactertile that inherits from tile class
    {
        //variables
        private int hitPoints;
        private int maxHitPoints;
        private int attackPower;

        public Tile[] vision;
       

        public CharacterTile(Position position, int HitPoints, int AttackPower) : base(position) //inherting from base class
        {
            hitPoints = HitPoints;
            attackPower = AttackPower;
            maxHitPoints = HitPoints;
            vision = new Tile[4];

        }
        public void UpdateVision(Level level) // array for vision of hero 
        {
            vision[0] = level.ArrayTile[X - 1 ,Y ];
            vision[1] = level.ArrayTile[X , Y + 1];
            vision[2] = level.ArrayTile[X + 1, Y ];
            vision[3] = level.ArrayTile[X , Y - 1];







        }
        //returning
        public int HitPoints => hitPoints;
        public int MaxHitPoints => maxHitPoints;   
        public int AttackPower => attackPower;

        public Tile[] Vision => vision;
        
       

        public void TakeDamage(int damage) //take damage method
        {
            hitPoints -= damage;
            if (hitPoints < 0)
            {
                hitPoints = 0;
            }
        }
        public void attack (CharacterTile target) // attack damage for part 2
        {
              target.TakeDamage(this.attackPower);
        }

        public bool IsDead //checking if hero is dead
        {
            get { return hitPoints <= 0; }

        }


    }
    
}
