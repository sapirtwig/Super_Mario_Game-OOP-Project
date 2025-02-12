using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace MarioGameProject
{
    public partial class Form1 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int playerSpeed = 10;
        int backgroundSpeed = 8;
        private int currentScore = 0;

        private Player mario;
        private SuperMario SuperMarioPlayer;
        private FireMario FireMarioPlayer;
        private List<Enemy> enemyManager = new List<Enemy>();


    public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            mario = new Player(baseMario, baseMarioJump, playerSpeed);
            SuperMarioPlayer = new SuperMario(superMario, superMarioJump, playerSpeed);
            FireMarioPlayer = new FireMario(fireMario, fireMarioJump, playerSpeed);
  
            enemyManager.Add(new Enemy(Goomba, 3));
            enemyManager.Add(new Enemy(cupa, 4));
    
        }

        public void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + mario.GetScore();
            currentScore = mario.GetScore();
            mario.GetPictureBox().Top += jumpSpeed;
            mario.GetJumpPictureBox().Top += jumpSpeed;

            foreach (Enemy enemy in enemyManager)
            {
                enemy.Movement("left");
            }


            if (mario.GetScore() >= 80)
            {
                mario.GetPictureBox().Visible = false;
                mario.GetJumpPictureBox().Visible = false;

                SuperMarioPlayer.GetPictureBox().Visible = true;
                SuperMarioPlayer.GetJumpPictureBox().Visible = true;
                SuperMarioPlayer.SetScore(mario.GetScore());
                SuperMarioPlayer.SetLocation(mario.GetLocation());
                mario = SuperMarioPlayer;
            }
            if (mario.GetScore() >= 120)
            {
                mario.GetPictureBox().Visible = false;
                mario.GetJumpPictureBox().Visible = false;

                FireMarioPlayer.GetPictureBox().Visible = true;
                FireMarioPlayer.GetJumpPictureBox().Visible = true;
                FireMarioPlayer.SetScore(mario.GetScore());
                mario = FireMarioPlayer;
            }

            if (goLeft == true && mario.GetPictureBox().Left > 60)
            {
                mario.Movement("left");
            }
            if (goRight == true && (mario.GetPictureBox().Left + (mario.GetPictureBox().Width + 60) < this.ClientSize.Width))
            {
                mario.Movement("right");
            }

            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }
            if (goRight == true && background.Left > -850)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if(jumping == true && force < 0)
            {
                jumping = false;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Platform" || x is PictureBox && (string)x.Tag == "Pipe" || x is PictureBox && (string)x.Tag == "Bricks" || x is PictureBox && (string)x.Tag == "goldBrick")
                {
                    if ((mario.GetPictureBox().Bounds.IntersectsWith(x.Bounds) && jumping == false) || (mario.GetJumpPictureBox().Bounds.IntersectsWith(x.Bounds) && jumping == false))
                    {
                        force = 8;
                        mario.GetPictureBox().Top = x.Top - mario.GetPictureBox().Height;
                        mario.GetJumpPictureBox().Top = x.Top - mario.GetJumpPictureBox().Height;
                        goRight = false;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "Coin" && x.Visible == true)
                {
                    if (mario.GetPictureBox().Bounds.IntersectsWith(x.Bounds) || mario.GetJumpPictureBox().Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                        mario.IncreaseScore(10);
                    }
                    x.BringToFront();
                }

            }

            if (mario.GetPictureBox().Bounds.IntersectsWith(Door.Bounds))
            {
                GameOver("Well done Mario! Your Jurney is completed!");
            }

            if (mario.GetPictureBox().Bounds.IntersectsWith(Goomba.Bounds) || mario.GetPictureBox().Bounds.IntersectsWith(cupa.Bounds))
            {
                GameOver("You died");
            }

            if (mario.GetPictureBox().Top + mario.GetPictureBox().Height > this.ClientSize.Height)
             {
                GameOver("Oh NO! Mario Died!");
             }

        }

        private void RestartGame(bool isSave)
        {
            Form1 newWindow = new Form1();
            if(isSave)
                newWindow.SetScore(currentScore);

            newWindow.Show();
            this.Hide();
        }

        public void SetScore(int score)
        {
            mario.SetScore(score);
        }

        public void GameOver(string gameText)
        {
            Gametimer.Stop();
            DialogResult diag_res = MessageBox.Show("Do you want to save the game?", "Game ended by user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag_res == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                    {
                        formatter.Serialize(stream, mario.GetScore());
                    }
                }
                RestartGame(true);
                LoadFromXML();

            }
            if (diag_res == DialogResult.No)
            {
                MessageBox.Show(gameText + Environment.NewLine + "Click OK to play again");
                RestartGame(false);
            }
              
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
                mario.jump(true);
            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
                mario.jump(false);
            }
        }


        private int LoadFromXML()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                int temp = (int)binaryFormatter.Deserialize(stream);
                mario.SetScore(temp);
            }

            return mario.GetScore();
        }


        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        public void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if( x is PictureBox && (string)x.Tag == "Coin" || x is PictureBox && (string)x.Tag == "Platform" || x is PictureBox && (string)x.Tag == "goldBrick" || x is PictureBox && (string)x.Tag == "Bricks" || x is PictureBox && (string)x.Tag == "Pipe" || x is PictureBox && (string)x.Tag == "Door" || x is PictureBox && (string)x.Tag == "Goomba")
                {
                    if(direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }
    }
}
