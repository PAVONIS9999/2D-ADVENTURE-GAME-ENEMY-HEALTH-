using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _2D_ADVENTURE_GAME
{
    internal class GruntTile : EnemyTile
    {
        public GruntTile(Position position) : base(position, 10, 1) //passing grunts attack power and health to the base class
        {

        }

        public override char Display //overriden display property to give grunt enemy type a character
        {
            get
            {
                return '⩣';
            }

        }

        public override bool GetMove(out Tile tile) //overidden getmove method
        {
            int emptyCount = 0;
            int currentTile = 0;
            int TileChoice;

            
            for (int i = 0; i < vision.Length; i++) 
            {
                if (vision[i] is EmptyTile) // check to see if tile in visionarray is of type empty
                {
                    emptyCount++;
                }
            }
           
            if (emptyCount == 0) 
            {
                tile = null;
                return false;
            }

            Random num = new Random();
            TileChoice = num.Next(emptyCount); 

            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] is EmptyTile)
                {
                    if (currentTile == TileChoice)
                    {
                        tile = vision[i];
                        return true;
                    }
                    currentTile++;
                }
            }

            tile = null;
            return false;


        }

        public override CharacterTile[] GetTargets()
        {
            int heroCount = 0;
            int targetPosition; 


            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] is HeroTile)
                {
                    heroCount++;
                }
            }

            if (heroCount == 0)
            {
                return new CharacterTile[] { null };
            }

            CharacterTile[] targets = new CharacterTile[heroCount];
            targetPosition = 0;

            for (int i = 0; i < vision.Length; i++)
            {
                if (vision[i] is HeroTile hero)
                {
                    targets[targetPosition] = hero;
                    targetPosition = targetPosition + 1;
                }
            }

            return targets;
        }

    }
    
}
