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

        int spriteX = 0;
        int spriteY = 0;

        public Form1()
        {
            InitializeComponent();
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
            moveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveUp();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            moveDown();
        }

        private void moveLeft()
        {
            if (spriteX > 0)
            {
                Point currentLocation = sprite1.Location;
                currentLocation.X -= 25;
                sprite1.Location = currentLocation;
                spriteX--;
            }
        }

        private void moveRight()
        {
            if (spriteX < 15)
            {
                Point currentLocation = sprite1.Location;
                currentLocation.X += 25;
                sprite1.Location = currentLocation;
                spriteX++;
            }
        }

        private void moveUp()
        {
            if (spriteY > 0)
            {
                Point currentLocation = sprite1.Location;
                currentLocation.Y -= 25;
                sprite1.Location = currentLocation;
                spriteY--;
            }
        }

        private void moveDown()
        {
            if (spriteY < 15)
            {
                Point currentLocation = sprite1.Location;
                currentLocation.Y += 25;
                sprite1.Location = currentLocation;
                spriteY++;
            }
        }


    }
}
