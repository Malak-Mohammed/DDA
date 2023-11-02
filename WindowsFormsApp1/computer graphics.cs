using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int xx1, xx2, yy1, yy2;
        float dx, dy, step,xinc,yinc,x,y;

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void y1_TextChanged(object sender, EventArgs e)
        {
            string var = y1.Text;
            yy1 = int.Parse(var);
        }

        private void x2_TextChanged(object sender, EventArgs e)
        {
            string var = x2.Text;
            xx2 = int.Parse(var);
        }

        private void y2_TextChanged(object sender, EventArgs e)
        {
            string var = y2.Text;
            yy2 = int.Parse(var);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       private void pb_(Object sender, PaintEventArgs e)
        {
            Bitmap myBitmap = new Bitmap(256, 256);

            // Draw myBitmap to the screen.
            e.Graphics.DrawImage(myBitmap, 0, 0, myBitmap.Width,
   myBitmap.Height);
           // dataGridView1.Rows.Add(x, y, (int)Math.Round(x), (int)Math.Round(y));
            myBitmap.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
            while ((int)Math.Round(x) != xx2)
            {
                x += xinc;
                y += yinc;
                dataGridView1.Rows.Add(x, y, (int)Math.Round(x), (int)Math.Round(y));
                int xx = (int)Math.Round(x), yy = (int)Math.Round(y);
                myBitmap.SetPixel(xx, yy, Color.Black);
            }


            // Draw myBitmap to the screen again.
            e.Graphics.DrawImage(myBitmap, myBitmap.Width, 0,
                myBitmap.Width, myBitmap.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dx = xx2 - xx1;
            dy= yy2 - yy1;
            if (Math.Abs(dx) > Math.Abs(dy)) step = dx;
            else step=dy;
            xinc = dx / step; yinc=dy/step;
            x = xx1;
            y = yy1;
            pb.Refresh();

        }
       
        private void x1_TextChanged(object sender, EventArgs e)
        {
            string var = x1.Text;
            xx1 = int.Parse(var);
        }
    }
}
