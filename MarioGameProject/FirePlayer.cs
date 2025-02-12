using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarioGameProject
{
    class FireMario : Player
    {
        private PictureBox jumpingMarioPictureBox;

        public FireMario(PictureBox pictureBox, PictureBox jumpPictureBox, int speed) : base(pictureBox, jumpPictureBox, speed)
        {
            this.jumpingMarioPictureBox = jumpPictureBox;
        }
    }
}
