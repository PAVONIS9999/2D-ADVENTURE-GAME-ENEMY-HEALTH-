using System.Drawing.Text;

namespace _2D_ADVENTURE_GAME
{
    public partial class Form1 : Form
    {
        private GameEngine gameengine;

        public Form1()
        {

            gameengine = new GameEngine(10);
            InitializeComponent();
            UpdateDisplays();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        public void UpdateDisplays() // assigns game engine to sting method to the level text
        {
            labelDisplay.Text = gameengine.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //up
        {
            gameengine.TriggerMovement(Level.Direction.Up);
            UpdateDisplays();
        }

        private void button2_Click(object sender, EventArgs e) // right
        {
            gameengine.TriggerMovement(Level.Direction.Right);
            UpdateDisplays();
        }

        private void button3_Click(object sender, EventArgs e) //down
        {
            gameengine.TriggerMovement(Level.Direction.Down);
            UpdateDisplays();
        }

        private void button4_Click(object sender, EventArgs e) //left
        {
            gameengine.TriggerMovement(Level.Direction.Left);
            UpdateDisplays();
        }
    }
}
