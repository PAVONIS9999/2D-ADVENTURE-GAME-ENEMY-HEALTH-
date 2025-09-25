using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ADVENTURE_GAME
{
    internal class GameEngine
    {
        //variables
        private Level Level;
        private HeroTile TempHero;
        private GameState State = GameState.InProgress;
        private int NumberOfLevels;


        public int MIN_SIZE = 10;
        public int MAX_SIZE = 20;
        private int currentLevelNumber = 1;

        public GameEngine(int levels) // construvtor which initializes number of levels field
        {

            NumberOfLevels = levels;
            Random rnd = new Random();


            Level = new Level(rnd.Next(MIN_SIZE, MAX_SIZE + 1), rnd.Next(MIN_SIZE, MAX_SIZE + 1), 4);//genrating a random numbers between max and min value to create a level

        }

        public override string ToString()
        {
            if (State == GameState.Complete) //checking if game is complete
            {
                MessageBox.Show("CONGRATULATIONS ON BEATING THE LEVEL");// displaying message if game is complete
            }
            else if (State == GameState.InProgress) //checking if game is still in progress
            {
                return Level.ToString();
            }
            return Level.ToString();
        }
        public bool MoveHero(Level.Direction direction) //method to move hero
        {
            HeroTile hero = Level.Hero;
            if (hero == null) {
                return false;

            }
            Tile targetTile = hero.Vision[(int)direction];
            if (targetTile is ExitTile) 
            {
                if (currentLevelNumber >= NumberOfLevels)
                {
                    State = GameState.Complete; 
                    return false;
                }
                else 
                {

                    NextLevel();
                    return true;
                }
            }
            if (targetTile is EmptyTile)
            {
                Level.SwopTiles(hero, targetTile);
                hero.UpdateVision(Level);
                return true;
            }
            return false;
        }
    
    public void TriggerMovement(Level.Direction direction) //method to move hero when a button is clciked
        {
            // Calling movehero
            MoveHero(direction);
        }
        public enum GameState // state of game
        {
            InProgress,
            Complete,
            GameOver
        }
        public void NextLevel() // create new level
        {
            currentLevelNumber++; //increase level
            TempHero = Level.Hero;
            Random rand = new Random(); //randomise
      
            Level = new Level(rand.Next(MIN_SIZE, MAX_SIZE + 1), rand.Next(MIN_SIZE, MAX_SIZE + 1),4, TempHero); 

           
        }
    }
}
