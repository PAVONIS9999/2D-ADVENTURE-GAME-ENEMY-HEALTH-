using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _2D_ADVENTURE_GAME.Level;

namespace _2D_ADVENTURE_GAME
{
    internal class Level
    {
        //private fields for height and width values.
        private int height;
        private int width;
        //paralled or 2D array
        Tile[,] TileArray;


        //Properties to expose field values
        public int HeiGht
        {
            get { return height; }
        }
        public int WiDth
        {
            get { return width; }
        }
        public Tile[,] ArrayTile //property to expose tile array
        {
            get
            {
                return TileArray;
            }
        }
        //exposing
        public HeroTile Hero { get;}
        public ExitTile Exit { get; }

        public Level(int Height, int Width, HeroTile hero = null) //constructor
        {
            //initializing fields
            height = Height;
            width = Width;
            //initializing array using height and width values as the arrays dimensions
            TileArray = new Tile[width, height];
            InitialiseTiles();
            Position heroPos = GetRandomEmptyPosition();
            if (hero == null)
            {
                
              hero = CreateTile(TileType.Hero, heroPos) as HeroTile;
            }
            else
            {
               hero.X = heroPos.X;
               hero.Y = heroPos.Y;
                
            }
            TileArray[heroPos.X, heroPos.Y] = hero;
            Hero = hero;
            Hero.UpdateVision(this);
            Position exit = GetRandomEmptyPosition();
            ArrayTile[exit.X, exit.Y] = CreateTile(TileType.Exit, exit);

        }

        public enum TileType //enum for tile type 
        {
            Empty,
            Wall,
            Hero,
            Exit



        }

        private Tile CreateTile(TileType tileType, Position position)
        {
            Tile tile;

            switch (tileType)

            {
                default:
                case TileType.Empty:
                    tile = new EmptyTile(position);

                    break;
                case TileType.Wall:

                    tile = new WallTile(position); //creating walltile in position
                    break;
                  
                case TileType.Hero:
                 tile = new HeroTile(position); //creating Herotile in position
                    break;

                    case TileType.Exit:
                       tile = new ExitTile(position);//creating exittile in position
                    break;

               

            }
            TileArray[position.X, position.Y] = tile;
            return tile;

        }
       


        public void InitialiseTiles() // initializeTiles method
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
                    {
                        TileArray[i, j] = CreateTile(TileType.Wall, new Position(i,j));
                    }
                    else
                    {
                        TileArray[i, j] = CreateTile(TileType.Empty, new Position(i, j));
                    }


                }

            }




        }

        public override string ToString()
        {
            string longStr = "";
            for (int i = 0; i < TileArray.GetLength(0); i++)
            {
                for (int j = 0; j < TileArray.GetLength(1); j++)
                {




                    longStr += TileArray[i, j]?.Display ?? ' ';



                }
                longStr += "\n";
            }

            return longStr;

        }




        private Position GetRandomEmptyPosition() //method for empyty tiles
        {
            Random rand1 = new Random(); // random number
            int x, y;
            x = rand1.Next(0, width); // width of empty tiles
            y = rand1.Next(0, height); // height of empty tiles
            Tile FindTile = ArrayTile[x, y];
            while (FindTile is not EmptyTile)
            {
                x = rand1.Next(0, width); // width of empty tiles
                y = rand1.Next(0, height); // height of empty tiles
                FindTile = ArrayTile[x, y];
            }
            return new Position(x, y);
        }
        
            
            
     
                 
            
            

            

        

        public void SwopTiles(Tile tile1, Tile tile2) //method to swap tiles
        {
            if (tile1 == null || tile2 == null) return;
            Position pos = ArrayTile[tile1.X, tile1.Y].Position;

            ArrayTile[tile1.X, tile1.Y].Position = ArrayTile[tile2.X, tile2.Y].Position;
            ArrayTile[tile2.X, tile2.Y].Position = pos;
            
            Tile tempTile = ArrayTile[tile1.X, tile1.Y];
            ArrayTile[tile1.X, tile1.Y] = ArrayTile[tile2.X, tile2.Y];
            ArrayTile[tile2.X, tile2.Y] = tempTile;
        }
       
        public enum Direction // direction enum
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            None = 4
        }
    }
}

