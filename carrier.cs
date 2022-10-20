using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Attempt4
{
    class carrier
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image carrierImage;//variable for the planet's image
        public Random thing = new Random();
        public Rectangle carrierRec;//variable for a rectangle to place our image in
        public int query, lives;
        public carrier(int spacing)
        {
            x = spacing;
            y = -30;
            lives = 10;
            width = 40;
            height = 40;
            //enemyImage contains the CorpFighter.png image
            carrierImage = Properties.Resources.CorpScore;
            carrierRec = new Rectangle(x, y, width, height);
        }

        public void BulletHit()
        {
            lives--;
            if (lives <= 0)
            {
                y = -30;
                lives = 10;
            }
        }

        public void DrawCarrier(Graphics g)
        {
            carrierRec = new Rectangle(x, y, width, height); //MOVING THE CARRIER to new coordonates
            g.DrawImage(carrierImage, carrierRec);
        }

        public void MoveCarrier()
        {
            carrierRec.Location = new Point(x, y);
        }

        public void MoveCarrierX(int rand)
        {
            if (rand == 0)
            {
                carrierRec.Location = new Point(x += 5, y);
            }
            else
            {
                carrierRec.Location = new Point(x -= 5, y);
            }

        }



    }
}

