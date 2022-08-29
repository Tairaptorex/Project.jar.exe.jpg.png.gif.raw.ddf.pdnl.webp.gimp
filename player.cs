using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Attempt4
{
    class player
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public int racc, lacc;
        public Image playerImage;//variable for the player's image

        public Rectangle playerRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public player()
        {
            x = 360;
            y = 760;
            racc = 0;
            lacc = 0;
            width = 50;
            height = 50;
            //planetImage contains the plane1.png image
            playerImage = Properties.Resources.HexFighter;
            playerRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void Drawplayer(Graphics g)
        {
            g.DrawImage(playerImage, playerRec);
        }








        public void transformplayer(string move)
        {
            x += lacc;
            playerRec.Location = new Point(x, y);


            if  (playerRec.Location.X > 840) { // is spaceship within 50 of right side
                x = -50;
                playerRec.Location = new Point(x, y);
            }

            if (playerRec.Location.X < -50)
            { // is spaceship within 50 of right side
                x = 840;
                playerRec.Location = new Point(x, y);
            }


        }

        public void Moveplayer(string move)
        {
            if (move == "right")
            {
                if (lacc < 20) { lacc += 1; }
            }

            if (move == "left")
            {
                if (lacc > -20) { lacc -= 1; } 
            }


            }
        }
    }
