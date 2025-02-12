using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MarioGameProject
{
    public class Character
    {
        protected PictureBox characterPictureBox;
        protected int characterSpeed;

        public Character(PictureBox pictureBox, int speed)
        {
            characterPictureBox = pictureBox;
            characterSpeed = speed;
        }

        public PictureBox GetPictureBox()
        {
            return characterPictureBox;
        }

        public int getSpeed()
        {
            return characterSpeed;
        }

    }
}
