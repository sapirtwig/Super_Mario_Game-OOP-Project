using System;
using System.Windows.Forms;


namespace MarioGameProject
{
    public class Enemy
    {
        private PictureBox enemyPictureBox;
        private int speed;

        public Enemy(PictureBox pictureBox, int speed)
        {
            enemyPictureBox = pictureBox;
            this.speed = speed;
        }

        public PictureBox GetPictureBox()
        {
            return enemyPictureBox;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void Movement(string what)
        {
            if (what == "left")
            {
                enemyPictureBox.Left -= speed; 
            }
            if (what == "right")
            {
                enemyPictureBox.Left += speed;
            }
        }
    }
}

