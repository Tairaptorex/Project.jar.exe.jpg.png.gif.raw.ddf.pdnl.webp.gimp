using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Attempt4
{
    class Enemy
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage;//variable for the planet's image
        public Random ting = new Random();
        public Rectangle enemyRec;//variable for a rectangle to place our image in
        public int query,lives;
        public Enemy(int spacing)
        {
            x = spacing;
            y = -30;
            lives = 10;
            width = 40;
            height = 40;
            //enemyImage contains the CorpFighter.png image
            enemyImage = Properties.Resources.CorpFighter;
            enemyRec = new Rectangle(x, y, width, height);
        }

        public void BulletHit() //subtract lives from enemy facet
        {
            lives--;
            if (lives <= 0)
            {
                y = -30;
                lives = 10;
            }
        }

        public void DrawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

        public void MoveEnemy()
        {
            enemyRec.Location = new Point(x, y); //self explanitory
        }

        public void MoveEnemyX(int rand)
        {
            if (rand == 0)
            {    
                    enemyRec.Location = new Point(x += 5, y);
            }
            else
            {
                enemyRec.Location = new Point(x -= 5, y);
            }

        }



    }
}
