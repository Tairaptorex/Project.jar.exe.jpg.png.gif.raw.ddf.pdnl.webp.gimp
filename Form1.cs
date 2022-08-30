using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt4
{
    public partial class Gamespace : Form
    {
        Graphics g; //declare a graphics object called g
        player player = new player(); //create the object, the player
        Enemy[] enemy = new Enemy[9];
        Random yspeed = new Random();
        public Random xspeed = new Random();
        public Random ting = new Random();
        int lives = 10;



        bool left, right;
        string move;

        public Gamespace()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, GamePanel, new object[] { true });
            for (int i = 0; i < 9; i++)
            {
                int x = 35 + (i * 100);
                enemy[i] = new Enemy(x);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Gamespace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }

        }

        private void Gamespace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }

        }

        private void playertimer_Tick(object sender, EventArgs e)
        {
            GamePanel.Invalidate();
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.Moveplayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.Moveplayer(move);
            }
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                movetimer.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }


        private void movetimer_Tick(object sender, EventArgs e)
        {
            GamePanel.Invalidate();
            
                player.transformplayer(move);

            for (int i = 0; i < 9; i++)
            {
                enemy[i].MoveEnemy();

                if (player.playerRec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    CheckLives();
                }





                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (enemy[i].y >= GamePanel.Height)
                {
                    enemy[i].y = -30;
                }

                if (enemy[i].x <= -20)
                {
                    enemy[i].x = 800;
                }

                if (enemy[i].x >= GamePanel.Width)
                {
                    enemy[i].x = -20;
                }

            }




        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Random fling = new Random();


            if (fling.Next(1,100) == 1) {
                for (int i = 0; i < 9; i++)
                {
                    int rand = ting.Next(-1, 1);
                    enemy[i].MoveEnemyX(rand);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            player.Drawplayer(g);



            for (int i = 0; i < 9; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(10, 30);
                enemy[i].y += rndmspeed;
                enemy[i].DrawEnemy(g);
            }


        }
    }
}
