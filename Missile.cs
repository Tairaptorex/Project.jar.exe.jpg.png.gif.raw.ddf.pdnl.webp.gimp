using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Attempt4
{
    class Missile
    {
        public int x, y, width, height;
        public Image missile;//variable for the missile's image
        public Rectangle missileRec;//variable for a rectangle to place our image in

        public Missile(Rectangle playerRec)
        {
            x = playerRec.X + 23; // move missile to middle of spaceship
            y = playerRec.Y + 20;
            width = 4;
            height = 16;
            missile = Properties.Resources.bullet;
            missileRec = new Rectangle(x, y, width, height);
        }

        public void draw(Graphics g)
        {
            y -= 10;//speed of missile
            missileRec = new Rectangle(x, y, width, height);
            g.DrawImage(missile, missileRec);
        }
    }


}
