
namespace MarioGameProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.cupa = new System.Windows.Forms.PictureBox();
            this.Goomba = new System.Windows.Forms.PictureBox();
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.Coin11 = new System.Windows.Forms.PictureBox();
            this.Coin12 = new System.Windows.Forms.PictureBox();
            this.Coin13 = new System.Windows.Forms.PictureBox();
            this.Coin10 = new System.Windows.Forms.PictureBox();
            this.Coin9 = new System.Windows.Forms.PictureBox();
            this.Coin8 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin7 = new System.Windows.Forms.PictureBox();
            this.Coin6 = new System.Windows.Forms.PictureBox();
            this.Coin5 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.fireMarioJump = new System.Windows.Forms.PictureBox();
            this.superMarioJump = new System.Windows.Forms.PictureBox();
            this.baseMarioJump = new System.Windows.Forms.PictureBox();
            this.fireMario = new System.Windows.Forms.PictureBox();
            this.superMario = new System.Windows.Forms.PictureBox();
            this.baseMario = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.goldBrick = new System.Windows.Forms.PictureBox();
            this.goldBrick2 = new System.Windows.Forms.PictureBox();
            this.goldBrick3 = new System.Windows.Forms.PictureBox();
            this.goldBrick1 = new System.Windows.Forms.PictureBox();
            this.Bricks = new System.Windows.Forms.PictureBox();
            this.Pipe = new System.Windows.Forms.PictureBox();
            this.Pipe2 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireMarioJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarioJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMarioJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bricks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // cupa
            // 
            this.cupa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cupa.Image = global::MarioGameProject.Properties.Resources.cupa_png;
            this.cupa.Location = new System.Drawing.Point(970, 533);
            this.cupa.Name = "cupa";
            this.cupa.Size = new System.Drawing.Size(39, 34);
            this.cupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cupa.TabIndex = 43;
            this.cupa.TabStop = false;
            this.cupa.Tag = "Cupa";
            // 
            // Goomba
            // 
            this.Goomba.Image = global::MarioGameProject.Properties.Resources.Goomba2;
            this.Goomba.Location = new System.Drawing.Point(1330, 533);
            this.Goomba.Name = "Goomba";
            this.Goomba.Size = new System.Drawing.Size(32, 32);
            this.Goomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Goomba.TabIndex = 42;
            this.Goomba.TabStop = false;
            this.Goomba.Tag = "Goomba";
            // 
            // Platform1
            // 
            this.Platform1.BackgroundImage = global::MarioGameProject.Properties.Resources.marioFloor;
            this.Platform1.Location = new System.Drawing.Point(1114, 567);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(335, 69);
            this.Platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform1.TabIndex = 41;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Door.Image = ((System.Drawing.Image)(resources.GetObject("Door.Image")));
            this.Door.Location = new System.Drawing.Point(1370, 487);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(50, 85);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 40;
            this.Door.TabStop = false;
            this.Door.Tag = "Door";
            // 
            // Coin11
            // 
            this.Coin11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin11.Image = ((System.Drawing.Image)(resources.GetObject("Coin11.Image")));
            this.Coin11.Location = new System.Drawing.Point(939, 509);
            this.Coin11.Name = "Coin11";
            this.Coin11.Size = new System.Drawing.Size(25, 25);
            this.Coin11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin11.TabIndex = 39;
            this.Coin11.TabStop = false;
            this.Coin11.Tag = "Coin";
            // 
            // Coin12
            // 
            this.Coin12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin12.Image = ((System.Drawing.Image)(resources.GetObject("Coin12.Image")));
            this.Coin12.Location = new System.Drawing.Point(1299, 540);
            this.Coin12.Name = "Coin12";
            this.Coin12.Size = new System.Drawing.Size(25, 25);
            this.Coin12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin12.TabIndex = 38;
            this.Coin12.TabStop = false;
            this.Coin12.Tag = "Coin";
            // 
            // Coin13
            // 
            this.Coin13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin13.Image = ((System.Drawing.Image)(resources.GetObject("Coin13.Image")));
            this.Coin13.Location = new System.Drawing.Point(1268, 540);
            this.Coin13.Name = "Coin13";
            this.Coin13.Size = new System.Drawing.Size(25, 25);
            this.Coin13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin13.TabIndex = 37;
            this.Coin13.TabStop = false;
            this.Coin13.Tag = "Coin";
            // 
            // Coin10
            // 
            this.Coin10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin10.Image = ((System.Drawing.Image)(resources.GetObject("Coin10.Image")));
            this.Coin10.Location = new System.Drawing.Point(959, 540);
            this.Coin10.Name = "Coin10";
            this.Coin10.Size = new System.Drawing.Size(25, 25);
            this.Coin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin10.TabIndex = 36;
            this.Coin10.TabStop = false;
            this.Coin10.Tag = "Coin";
            // 
            // Coin9
            // 
            this.Coin9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin9.Image = ((System.Drawing.Image)(resources.GetObject("Coin9.Image")));
            this.Coin9.Location = new System.Drawing.Point(928, 540);
            this.Coin9.Name = "Coin9";
            this.Coin9.Size = new System.Drawing.Size(25, 25);
            this.Coin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin9.TabIndex = 35;
            this.Coin9.TabStop = false;
            this.Coin9.Tag = "Coin";
            // 
            // Coin8
            // 
            this.Coin8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin8.Image = ((System.Drawing.Image)(resources.GetObject("Coin8.Image")));
            this.Coin8.Location = new System.Drawing.Point(664, 417);
            this.Coin8.Name = "Coin8";
            this.Coin8.Size = new System.Drawing.Size(25, 25);
            this.Coin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin8.TabIndex = 34;
            this.Coin8.TabStop = false;
            this.Coin8.Tag = "Coin";
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(224, 536);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(25, 25);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 30;
            this.Coin1.TabStop = false;
            this.Coin1.Tag = "Coin";
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(306, 536);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(25, 25);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 29;
            this.Coin3.TabStop = false;
            this.Coin3.Tag = "Coin";
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(265, 536);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(25, 25);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 28;
            this.Coin2.TabStop = false;
            this.Coin2.Tag = "Coin";
            // 
            // Coin7
            // 
            this.Coin7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin7.Image = ((System.Drawing.Image)(resources.GetObject("Coin7.Image")));
            this.Coin7.Location = new System.Drawing.Point(630, 417);
            this.Coin7.Name = "Coin7";
            this.Coin7.Size = new System.Drawing.Size(25, 25);
            this.Coin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin7.TabIndex = 24;
            this.Coin7.TabStop = false;
            this.Coin7.Tag = "Coin";
            // 
            // Coin6
            // 
            this.Coin6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin6.Image = ((System.Drawing.Image)(resources.GetObject("Coin6.Image")));
            this.Coin6.Location = new System.Drawing.Point(594, 417);
            this.Coin6.Name = "Coin6";
            this.Coin6.Size = new System.Drawing.Size(25, 25);
            this.Coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin6.TabIndex = 23;
            this.Coin6.TabStop = false;
            this.Coin6.Tag = "Coin";
            // 
            // Coin5
            // 
            this.Coin5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin5.Image = ((System.Drawing.Image)(resources.GetObject("Coin5.Image")));
            this.Coin5.Location = new System.Drawing.Point(558, 417);
            this.Coin5.Name = "Coin5";
            this.Coin5.Size = new System.Drawing.Size(25, 25);
            this.Coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin5.TabIndex = 22;
            this.Coin5.TabStop = false;
            this.Coin5.Tag = "Coin";
            // 
            // Coin4
            // 
            this.Coin4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin4.Image = ((System.Drawing.Image)(resources.GetObject("Coin4.Image")));
            this.Coin4.Location = new System.Drawing.Point(518, 417);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(25, 25);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin4.TabIndex = 21;
            this.Coin4.TabStop = false;
            this.Coin4.Tag = "Coin";
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Coin.Image = ((System.Drawing.Image)(resources.GetObject("Coin.Image")));
            this.Coin.Location = new System.Drawing.Point(364, 417);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(25, 25);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 20;
            this.Coin.TabStop = false;
            this.Coin.Tag = "Coin";
            // 
            // fireMarioJump
            // 
            this.fireMarioJump.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fireMarioJump.Image = global::MarioGameProject.Properties.Resources.MarioJump21;
            this.fireMarioJump.Location = new System.Drawing.Point(12, 501);
            this.fireMarioJump.Name = "fireMarioJump";
            this.fireMarioJump.Size = new System.Drawing.Size(44, 66);
            this.fireMarioJump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireMarioJump.TabIndex = 19;
            this.fireMarioJump.TabStop = false;
            this.fireMarioJump.Tag = "fireMarioJump";
            this.fireMarioJump.Visible = false;
            // 
            // superMarioJump
            // 
            this.superMarioJump.BackColor = System.Drawing.Color.LightSkyBlue;
            this.superMarioJump.Image = global::MarioGameProject.Properties.Resources.MarioJump11;
            this.superMarioJump.Location = new System.Drawing.Point(12, 499);
            this.superMarioJump.Name = "superMarioJump";
            this.superMarioJump.Size = new System.Drawing.Size(44, 66);
            this.superMarioJump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.superMarioJump.TabIndex = 18;
            this.superMarioJump.TabStop = false;
            this.superMarioJump.Tag = "superMarioJump";
            this.superMarioJump.Visible = false;
            // 
            // baseMarioJump
            // 
            this.baseMarioJump.BackColor = System.Drawing.Color.LightSkyBlue;
            this.baseMarioJump.Image = global::MarioGameProject.Properties.Resources.MarioJump3;
            this.baseMarioJump.Location = new System.Drawing.Point(12, 523);
            this.baseMarioJump.Name = "baseMarioJump";
            this.baseMarioJump.Size = new System.Drawing.Size(44, 44);
            this.baseMarioJump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baseMarioJump.TabIndex = 17;
            this.baseMarioJump.TabStop = false;
            this.baseMarioJump.Tag = "baseMarioJump";
            this.baseMarioJump.Visible = false;
            // 
            // fireMario
            // 
            this.fireMario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fireMario.Image = global::MarioGameProject.Properties.Resources.MarioIdle21;
            this.fireMario.Location = new System.Drawing.Point(12, 509);
            this.fireMario.Name = "fireMario";
            this.fireMario.Size = new System.Drawing.Size(44, 58);
            this.fireMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireMario.TabIndex = 16;
            this.fireMario.TabStop = false;
            this.fireMario.Tag = "fireMario";
            this.fireMario.Visible = false;
            // 
            // superMario
            // 
            this.superMario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.superMario.Image = global::MarioGameProject.Properties.Resources.MarioIdle11;
            this.superMario.Location = new System.Drawing.Point(12, 507);
            this.superMario.Name = "superMario";
            this.superMario.Size = new System.Drawing.Size(44, 58);
            this.superMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.superMario.TabIndex = 15;
            this.superMario.TabStop = false;
            this.superMario.Tag = "superMario";
            this.superMario.Visible = false;
            // 
            // baseMario
            // 
            this.baseMario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.baseMario.Image = global::MarioGameProject.Properties.Resources.MarioIdle3;
            this.baseMario.Location = new System.Drawing.Point(12, 521);
            this.baseMario.Name = "baseMario";
            this.baseMario.Size = new System.Drawing.Size(44, 44);
            this.baseMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baseMario.TabIndex = 14;
            this.baseMario.TabStop = false;
            this.baseMario.Tag = "baseMario";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtScore.Image = global::MarioGameProject.Properties.Resources.txtBackround;
            this.txtScore.Location = new System.Drawing.Point(24, 34);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(93, 25);
            this.txtScore.TabIndex = 13;
            this.txtScore.Tag = "Score";
            this.txtScore.Text = "Score: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = global::MarioGameProject.Properties.Resources.txtBackround;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "MARIO";
            // 
            // Platform
            // 
            this.Platform.Image = global::MarioGameProject.Properties.Resources.marioFloor;
            this.Platform.Location = new System.Drawing.Point(-3, 567);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(1020, 70);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 8;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            // 
            // goldBrick
            // 
            this.goldBrick.Image = global::MarioGameProject.Properties.Resources.marioGift;
            this.goldBrick.Location = new System.Drawing.Point(364, 448);
            this.goldBrick.Name = "goldBrick";
            this.goldBrick.Size = new System.Drawing.Size(35, 28);
            this.goldBrick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldBrick.TabIndex = 7;
            this.goldBrick.TabStop = false;
            this.goldBrick.Tag = "goldBrick";
            // 
            // goldBrick2
            // 
            this.goldBrick2.Image = global::MarioGameProject.Properties.Resources.marioGift;
            this.goldBrick2.Location = new System.Drawing.Point(584, 336);
            this.goldBrick2.Name = "goldBrick2";
            this.goldBrick2.Size = new System.Drawing.Size(35, 28);
            this.goldBrick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldBrick2.TabIndex = 6;
            this.goldBrick2.TabStop = false;
            this.goldBrick2.Tag = "goldBrick";
            // 
            // goldBrick3
            // 
            this.goldBrick3.Image = global::MarioGameProject.Properties.Resources.marioGift;
            this.goldBrick3.Location = new System.Drawing.Point(620, 448);
            this.goldBrick3.Name = "goldBrick3";
            this.goldBrick3.Size = new System.Drawing.Size(35, 28);
            this.goldBrick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldBrick3.TabIndex = 5;
            this.goldBrick3.TabStop = false;
            this.goldBrick3.Tag = "goldBrick";
            // 
            // goldBrick1
            // 
            this.goldBrick1.Image = global::MarioGameProject.Properties.Resources.marioGift;
            this.goldBrick1.Location = new System.Drawing.Point(548, 448);
            this.goldBrick1.Name = "goldBrick1";
            this.goldBrick1.Size = new System.Drawing.Size(35, 28);
            this.goldBrick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldBrick1.TabIndex = 4;
            this.goldBrick1.TabStop = false;
            this.goldBrick1.Tag = "goldBrick";
            // 
            // Bricks
            // 
            this.Bricks.Image = global::MarioGameProject.Properties.Resources.marioPlatform;
            this.Bricks.Location = new System.Drawing.Point(509, 448);
            this.Bricks.Name = "Bricks";
            this.Bricks.Size = new System.Drawing.Size(180, 30);
            this.Bricks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bricks.TabIndex = 3;
            this.Bricks.TabStop = false;
            this.Bricks.Tag = "Bricks";
            // 
            // Pipe
            // 
            this.Pipe.Image = global::MarioGameProject.Properties.Resources.mariopipeS;
            this.Pipe.Location = new System.Drawing.Point(804, 507);
            this.Pipe.Name = "Pipe";
            this.Pipe.Size = new System.Drawing.Size(75, 58);
            this.Pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pipe.TabIndex = 2;
            this.Pipe.TabStop = false;
            this.Pipe.Tag = "Pipe";
            // 
            // Pipe2
            // 
            this.Pipe2.Image = global::MarioGameProject.Properties.Resources.mariopipeL;
            this.Pipe2.Location = new System.Drawing.Point(1171, 476);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(73, 89);
            this.Pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pipe2.TabIndex = 1;
            this.Pipe2.TabStop = false;
            this.Pipe2.Tag = "Pipe";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(-3, 9);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1467, 628);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 631);
            this.Controls.Add(this.cupa);
            this.Controls.Add(this.Goomba);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Coin11);
            this.Controls.Add(this.Coin12);
            this.Controls.Add(this.Coin13);
            this.Controls.Add(this.Coin10);
            this.Controls.Add(this.Coin9);
            this.Controls.Add(this.Coin8);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin7);
            this.Controls.Add(this.Coin6);
            this.Controls.Add(this.Coin5);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.fireMarioJump);
            this.Controls.Add(this.superMarioJump);
            this.Controls.Add(this.baseMarioJump);
            this.Controls.Add(this.fireMario);
            this.Controls.Add(this.superMario);
            this.Controls.Add(this.baseMario);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.goldBrick);
            this.Controls.Add(this.goldBrick2);
            this.Controls.Add(this.goldBrick3);
            this.Controls.Add(this.goldBrick1);
            this.Controls.Add(this.Bricks);
            this.Controls.Add(this.Pipe);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.cupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireMarioJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarioJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMarioJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldBrick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bricks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox Pipe2;
        private System.Windows.Forms.PictureBox Pipe;
        private System.Windows.Forms.PictureBox Bricks;
        private System.Windows.Forms.PictureBox goldBrick1;
        private System.Windows.Forms.PictureBox goldBrick3;
        private System.Windows.Forms.PictureBox goldBrick2;
        private System.Windows.Forms.PictureBox goldBrick;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox baseMario;
        private System.Windows.Forms.PictureBox superMario;
        private System.Windows.Forms.PictureBox fireMario;
        private System.Windows.Forms.PictureBox baseMarioJump;
        private System.Windows.Forms.PictureBox superMarioJump;
        private System.Windows.Forms.PictureBox fireMarioJump;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.PictureBox Coin5;
        private System.Windows.Forms.PictureBox Coin6;
        private System.Windows.Forms.PictureBox Coin7;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.PictureBox Coin8;
        private System.Windows.Forms.PictureBox Coin9;
        private System.Windows.Forms.PictureBox Coin10;
        private System.Windows.Forms.PictureBox Coin13;
        private System.Windows.Forms.PictureBox Coin12;
        private System.Windows.Forms.PictureBox Coin11;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox Goomba;
        private System.Windows.Forms.PictureBox cupa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

