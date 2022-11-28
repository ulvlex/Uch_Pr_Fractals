using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdBlock
{
    public partial class Fractals : Form
    {
        public Fractals()
        {
            InitializeComponent();
        }
        int x, y;
        int w;
        int h;
        private void Fractals_Load(object sender, EventArgs e)
        {
            label1.Text = DataBank.Level.ToString();
            label3.Text = "N/A";
            label4.Text = "N/A";
        }

        private void PaintFract(object sender, PaintEventArgs e)
        {
            switch (DataBank.Level)
            {
                case 0:
                    w = pictureBox1.ClientSize.Width/2;
                    h = pictureBox1.ClientSize.Height/2;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.Clear(Color.White);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.TranslateTransform(-w, -h);
                    break;
                case 1: 
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 4;
                    h = pictureBox1.ClientSize.Height / 2;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.6, (float)0.6);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)1.5, (float)1.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3*pictureBox1.ClientSize.Width / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.6, (float)0.6);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)1.5, (float)1.5);
                    e.Graphics.TranslateTransform(-w, -h);                 
                    
                    break;
                case 2:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 2;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    break;

                case 3:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 4;
                    h = pictureBox1.ClientSize.Height / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2, (float)2);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2, (float)2);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = pictureBox1.ClientSize.Width / 4;
                    h = 3*pictureBox1.ClientSize.Height / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2, (float)2);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 4;
                    h = 3 * pictureBox1.ClientSize.Height / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(3, e);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    e.Graphics.TranslateTransform(-w, -h);


                    break;

                case 4:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3*pictureBox1.ClientSize.Height / 4;

                    w = pictureBox1.ClientSize.Width / 4;
                  
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(3, e);
                    e.Graphics.ScaleTransform((float)2, (float)2);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 4;
                   
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)0.5, (float)0.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    break;
               
                case 5:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 4;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3 * pictureBox1.ClientSize.Height / 4;
                    w = pictureBox1.ClientSize.Width / 6;
                   
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(5, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(6, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    break;

                case 6:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(5, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(6, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    
                    h = 5 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 2;
                   
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(7, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    break;

                case 7:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(5, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(6, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 5 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 4;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(7, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3*pictureBox1.ClientSize.Width / 4;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(8, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    break;

                case 8:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 6;
                    h = pictureBox1.ClientSize.Height / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(5, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(6, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 5 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(7, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(8, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    
                    w = 5 * pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(9, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    break;

                case 9:
                    e.Graphics.Clear(Color.White);

                    w = pictureBox1.ClientSize.Width / 8;
                    h = pictureBox1.ClientSize.Height / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.33, (float)0.33);
                    DataBank.newTree.PrintFractal(0, e);
                    e.Graphics.ScaleTransform((float)3, (float)3);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 8;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.33, (float)0.33);
                    DataBank.newTree.PrintFractal(1, e);
                    e.Graphics.ScaleTransform((float)3, (float)3);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 8;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.33, (float)0.33);
                    DataBank.newTree.PrintFractal(2, e);
                    e.Graphics.ScaleTransform((float)3, (float)3);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 7 * pictureBox1.ClientSize.Width / 8;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.33, (float)0.33);
                    DataBank.newTree.PrintFractal(3, e);
                    e.Graphics.ScaleTransform((float)3, (float)3);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 3 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(4, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(5, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;
                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(6, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    h = 5 * pictureBox1.ClientSize.Height / 6;
                    w = pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(7, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 3 * pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(8, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);

                    w = 5 * pictureBox1.ClientSize.Width / 6;

                    e.Graphics.TranslateTransform(w, h);
                    e.Graphics.ScaleTransform((float)0.4, (float)0.4);
                    DataBank.newTree.PrintFractal(9, e);
                    e.Graphics.ScaleTransform((float)2.5, (float)2.5);
                    e.Graphics.TranslateTransform(-w, -h);
                    break;

            }
        }




        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            x = Convert.ToInt32(e.X) - w / 2; // координата по оси X
            y = Convert.ToInt32(e.Y) - h / 2; // координата по оси Y
            label3.Text = x.ToString();
            label4.Text = y.ToString();

        }
    }
}
