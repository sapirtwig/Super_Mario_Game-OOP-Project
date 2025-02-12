using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarioGameProject
{
    class SuperMario : Player
    {
        private PictureBox jumpingMarioPictureBox;

        public SuperMario(PictureBox pictureBox, PictureBox jumpPictureBox, int speed) : base(pictureBox, jumpPictureBox, speed)
        {
            this.jumpingMarioPictureBox = jumpPictureBox;
        }

        public override void IncreaseScore(int amount)
        {
            score += (amount * 2);
        }

    }
}
