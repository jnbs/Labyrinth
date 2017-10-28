using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        int[][][] map = new int[16][][];
        PictureBox background = new System.Windows.Forms.PictureBox();
        PictureBox rangerBox = new PictureBox();
        PictureBox wumpusBox = new PictureBox();
        PictureBox arrowBox = new PictureBox();
        PictureBox hitBox = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = new int[16][];
                for (int j = 0; j < map.Length; j++)
                {
                    map[i][j] = new int[] { 0, 0, 0, 0, 0, 0, 0 };
                    //occupied by, sight, smell, breeze, wumpus, pit, torch, bonfire
                }
                //PictureBox newTile = new PictureBox();
                //CreateBitmapAtRuntime();
                initializeMap();
            }
        }

        public void initializeMap()
        {
            Point rangerInitial = new Point();
            rangerInitial.X = 50;
            rangerInitial.Y = 0;
            rangerBox.Size = new Size(25, 25);
            this.Controls.Add(rangerBox);
            rangerBox.Image = Image.FromFile("C:\\Users\\Kathrine Tso\\Source\\Repos\\Labyrinth\\Labyrinth\\Resources\\rangerSprite.bmp");
            rangerBox.Location = rangerInitial;

            Point wumpusInitial = new Point();
            wumpusInitial.X = 150;
            wumpusInitial.Y = 100;
            wumpusBox.Size = new Size(25, 25);
            this.Controls.Add(wumpusBox);
            wumpusBox.Image = Image.FromFile("C:\\Users\\Kathrine Tso\\Source\\Repos\\Labyrinth\\Labyrinth\\Resources\\wumpusSprite.bmp");
            wumpusBox.Location = wumpusInitial;

            background.Image = Image.FromFile("C:\\Users\\Kathrine Tso\\Source\\Repos\\Labyrinth\\Labyrinth\\Resources\\background.bmp");
            background.Size = new Size(400, 400);
            background.Location = new Point(50, 0);
            this.Controls.Add(background);
            background.SendToBack();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //import code here
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveRight(rangerBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveLeft(rangerBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveUp(rangerBox);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            moveDown(rangerBox);
        }

        private void shootButton_Click(object sender, EventArgs e)
        {
            arrowBox.Size = new Size(25, 25);
            this.Controls.Add(arrowBox);
            arrowBox.Image = Image.FromFile("C:\\Users\\Kathrine Tso\\Source\\Repos\\Labyrinth\\Labyrinth\\Resources\\arrowSprite.bmp");
            arrowBox.Location = rangerBox.Location;
            arrowBox.BringToFront();
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 300; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveRight(arrowBox);
            checkCollision(arrowBox, wumpusBox);
            checkRightWall(arrowBox);
        }

        private void moveLeft(PictureBox sprite)
        {
            Point currentLocation = sprite.Location;
            if (currentLocation.X > 50)
            {
                currentLocation.X -= 25;
                sprite.Location = currentLocation;
            }
        }

        private void moveRight(PictureBox sprite)
        {
            Point currentLocation = sprite.Location;
            if (currentLocation.X < 425)
            {
                currentLocation.X += 25;
                sprite.Location = currentLocation;
            }
        }

        private void moveUp(PictureBox sprite)
        {
            Point currentLocation = sprite.Location;
            if (currentLocation.Y > 0)
            {
                currentLocation.Y -= 25;
                sprite.Location = currentLocation;
            }
        }

        private void moveDown(PictureBox sprite)
        {
            Point currentLocation = sprite.Location;
            if (currentLocation.Y < 375)
            {
                currentLocation.Y += 25;
                sprite.Location = currentLocation;
            }
        }

        private void checkCollision(PictureBox sprite1, PictureBox sprite2)
        {
            if (sprite1.Location == sprite2.Location)
            {
                timer1.Stop();
                timer1.Dispose();
                hitBox.Size = new Size(25, 25);
                this.Controls.Add(hitBox);
                hitBox.Image = Image.FromFile("C:\\Users\\Kathrine Tso\\Source\\Repos\\Labyrinth\\Labyrinth\\Resources\\hitSprite.bmp");
                hitBox.Location = sprite1.Location;
                sprite1.Dispose();
                sprite2.Dispose();
                hitBox.BringToFront();
            }
        }

        private void checkRightWall(PictureBox sprite)
        {
            if (sprite.Location.X >= 425)
            {
                sprite.Dispose();
            }
        }
    }
}
