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
        carrier[] carrier = new carrier[9];
        Random yspeed = new Random();
        public Random xspeed = new Random();
        public Random ting = new Random();
        int lives = 5;
        int playerspeed = 1;
        List<Missile> missiles = new List<Missile>();
        int playerscore = 0;
        public int scorefsx = 0;
        bool assist;


        bool left, right, pacc;
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

            for (int i = 0; i < 3; i++)
            {
                int x = 163 + (i * 163);
                carrier[i] = new carrier(x);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(player.playerRec));
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            truescore.Text = "";
            scoreadd.Visible = false;

            movetimer.Enabled = false;
            timer1.Enabled = false;
            playertimer.Enabled = false;
            shooting.Enabled = false;
            shoottimer.Enabled = false;
            playbtn.Visible = true;
            helpbtn.Visible = false;
            assist = false;
        }

        private void Gamespace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Down) { pacc = true;
                shoottimer.Interval = 100;
            }

        }

        private void Gamespace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Down) { pacc = false;
                shoottimer.Interval = 10;
            }

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
                playertimer.Enabled = false;
                shooting.Enabled = false;
                shoottimer.Enabled = false;
                playbtn.Visible = true;
                int score = playerscore + scorefsx;
                scorelbl.Text = "Your final score was: " + score;
                helpbtn.Visible = true;
            }
        }


        private void movetimer_Tick(object sender, EventArgs e)
        {
            GamePanel.Invalidate();

            if (assist == true)
            {
                movetimer.Interval = 20;
                movetimer.Interval = 20;
                timer1.Interval = 20;
                shoottimer.Interval = 1;
            }
            else
            {
                movetimer.Interval = 1;
                playertimer.Interval = 80;
                timer1.Interval = 100;
            }



                if (pacc == true)
            {
                if (playerspeed < 10) { playerspeed++; }
            }
            else
            {
                if (playerspeed > 0) { playerspeed--; }
            }

            if (scorefsx > 0)
            {
                scoreadd.Visible = true;
                scorefsx --;
                playerscore ++;
            }
            else
            {
                scoreadd.Visible = false;
            }

            scoreadd.Text = scorefsx.ToString();
            truescore.Text = playerscore.ToString();

            player.transformplayer(move);

            for (int i = 0; i < 9; i++)
            {
                enemy[i].MoveEnemy();



                if (player.playerRec.IntersectsWith(enemy[i].enemyRec))
                {


                    if (assist == true)
                    {
                        enemy[i].y -= 30;
                    }
                    else
                    {




                        //reset planet[i] back to top of panel
                        enemy[i].y = 30; // set  y value of planetRec
                        lives -= 1;// lose a life
                        CheckLives();
                    }
                }






                enemy[i].y -= playerspeed; // set  y value of planetRec
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



            for (int i = 0; i < 3; i++)
            {
                carrier[i].MoveCarrier();

                if (player.playerRec.IntersectsWith(carrier[i].carrierRec))
                {


                    if (assist == true)
                    {
                        carrier[i].y -= 30;
                    }
                    else
                    {
                        //reset planet[i] back to top of panel
                        carrier[i].y = 30; // set  y value of planetRec
                        lives -= 1;// lose a life
                        CheckLives();
                    }
                }

                carrier[i].y -= playerspeed; // set  y value of planetRec
                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (carrier[i].y >= GamePanel.Height)
                {
                    carrier[i].y = -30;
                }

                if (carrier[i].x <= -20)
                {
                    carrier[i].x = 800;
                }

                if (carrier[i].x >= GamePanel.Width)
                {
                    carrier[i].x = -20;
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

        private void shooting_Tick(object sender, EventArgs e)
        {

        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            movetimer.Enabled = true;
            timer1.Enabled = true;
            playertimer.Enabled = true;
            shooting.Enabled = true;
            shoottimer.Enabled = true;
            playbtn.Visible = false;
            helpbtn.Visible = false;
            assist = false;
            playerscore = 0;
            scorefsx = 0;
            lives = 5;
            scorelbl.Text = "";
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            movetimer.Enabled = true;
            timer1.Enabled = true;
            playertimer.Enabled = true;
            shooting.Enabled = true;
            shoottimer.Enabled = true;
            playbtn.Visible = false;
            helpbtn.Visible = false;
            assist = true;
            playerscore = 0;
            scorefsx = 0;
            lives = 2000000;
            scorelbl.Text = "";
        }

        private void shoottimer_Tick(object sender, EventArgs e)
        {
            missiles.Add(new Missile(player.playerRec));

            this.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            player.Drawplayer(g);


            foreach (Missile m in missiles.ToList())
            {
                m.draw(g);
                for (int i = 0; i < 9; i++)
                {
                    if (enemy[i].enemyRec.IntersectsWith(m.missileRec))
                    {
                        enemy[i].BulletHit();
                        missiles.Remove(m);
                        enemy[i].y -= 100;


                        if (assist == true)
                        {
                            scorefsx += 300000;
                        }
                        else
                        {
                            scorefsx += 5;
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (carrier[i].carrierRec.IntersectsWith(m.missileRec))
                    {
                        carrier[i].BulletHit();
                        missiles.Remove(m);
                        carrier[i].y -= 100;

                        if (assist == true)
                        {
                            scorefsx += 300000;
                        }
                        else
                        {
                            scorefsx += 20;
                        }
                    }
                }
            }




            for (int i = 0; i < 9; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                if (assist == true)
                {
                    int rndmspeed = yspeed.Next(1, 2);
                    enemy[i].y += rndmspeed;
                    enemy[i].DrawEnemy(g);
                }
                else
                {
                    int rndmspeed = yspeed.Next(8, 12);
                    enemy[i].y += rndmspeed;
                    enemy[i].DrawEnemy(g);
                }

            }

            for (int i = 0; i < 3; i++)
            {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    if (assist == true)
                    {
                    int rndmspeed = yspeed.Next(1, 2);
                    carrier[i].y += rndmspeed;
                    carrier[i].DrawCarrier(g);
                }
                    else
                    {
                        int rndmspeed = yspeed.Next(5, 10);
                        carrier[i].y += rndmspeed;
                        carrier[i].DrawCarrier(g);
                    }

            }


        }
    }
}
