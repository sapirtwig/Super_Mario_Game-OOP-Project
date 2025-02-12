using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarioGameProject
{
    class Player : Character
    {
        public int score;
        private PictureBox jumpingMarioPictureBox;
        private Point currentPosition;

        public Player(PictureBox pictureBox, PictureBox jumpPictureBox, int speed) : base(pictureBox, speed)
        {
            this.jumpingMarioPictureBox = jumpPictureBox;
            currentPosition = new Point(pictureBox.Left, pictureBox.Top);
        }

        public PictureBox GetJumpPictureBox()
        {
            return jumpingMarioPictureBox;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int newScore)
        {
            score = newScore;
        }

        public Point GetLocation()
        {
            return currentPosition;
        }

        public void SetLocation(Point newPosition)
        {
            currentPosition = newPosition;
        }

        public virtual void IncreaseScore(int amount)
        {
            score += amount;
        }

        public void jump(bool isjump)
        {
            if (isjump)
            {
                characterPictureBox.Visible = false;
                jumpingMarioPictureBox.Visible = true;
            }
            if (!isjump)
            {
                characterPictureBox.Visible = true;
                jumpingMarioPictureBox.Visible = false;
            }
            currentPosition = new Point(jumpingMarioPictureBox.Left, jumpingMarioPictureBox.Top); 
        }

        public void Movement(string what)
        {
            if (what == "left")
            {
                characterPictureBox.Left -= characterSpeed;
                jumpingMarioPictureBox.Left -= characterSpeed;
            }
            if (what == "right")
            {
                characterPictureBox.Left += characterSpeed;
                jumpingMarioPictureBox.Left += characterSpeed;
            }
            currentPosition = new Point(characterPictureBox.Left, characterPictureBox.Top); 
        }
    }
}
