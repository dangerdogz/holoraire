///////////////////////////
// By Farooq Azam     ////
// www.farooqazam.net ////
/////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw_Rectangle
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        public Form1()
        {
            InitializeComponent();
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // "e.X" and "e.Y" are used to get MousePositionX and MousePositionY
            rect = new Rectangle(e.X, e.Y, 0, 0);
            this.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // This makes sure that the left mouse button is pressed.
            if (e.Button == MouseButtons.Left)
            {
                // Draws the rectangle as the mouse moves
                rect = new Rectangle(rect.Left, rect.Top, e.X - rect.Left, e.Y - rect.Top);
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Replace "Color.Red" with any color and repalce "2" with any size you like.
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
