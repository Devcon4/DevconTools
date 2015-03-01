using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using DevconTools;

namespace DataViewer2 {

    public partial class Form1 : Form {

        private bool button2Toggled = false;
        private bool toggle2D = false;
        private bool toggleType = false;
        private float interval = 1, z = 0;
        private Graphics graphics1;
        private Brush brush1 = (Brush)Brushes.Black;
        private Point position;

        public Form1() {
            InitializeComponent();
            position = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics1 = pictureBox1.CreateGraphics();
            dataThread();
            pictureThread();
            timer1.Start();
            timer2.Start();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            chart1.Series["Data1"].Points.Clear();
            chart2.Series["Data1"].Points.Clear();
            chart3.Series["Data1"].Points.Clear();
        }

        private void NumUpDownChanged(object sender, EventArgs e) {
        }

        private void dataThread() {

            float point1 = (float)pnng.Noise(interval, 0, 0);

            double point2 = point1 + (pnng.Noise(interval * 2, 0, 0) / 2);
            point2 += pnng.Noise(interval * 4, 0, 0) / 4;
            point2 += pnng.Noise(interval * 16, 0, 0) / 8;
            point2 *= 16;
            point2 = Math.Floor(point2);

            float point3 = (float)point2;

            chart1.Series["Data1"].Points.AddY(point1);
            chart2.Series["Data1"].Points.AddY(point2);
            chart3.Series["Data1"].Points.AddY(point3);

            interval += (float)numericUpDown5.Value;

            if (chart1.Series["Data1"].Points.Count > numericUpDown1.Value) {
                chart1.Series["Data1"].Points.RemoveAt(0);
            }

            if (chart2.Series["Data1"].Points.Count > numericUpDown1.Value) {
                chart2.Series["Data1"].Points.RemoveAt(0);
            }

            if (chart3.Series["Data1"].Points.Count > numericUpDown1.Value) {
                chart3.Series["Data1"].Points.RemoveAt(0);
            }
        }

        private void pictureThread() {

                //pictureBox1.Image = ifg.QuickHeightMap(pictureBox1.Width, pictureBox1.Height, 6);
        }

        private void randomWalker() {

            float val = prng.MersenneTwister(position.X + position.Y);
            val++;
            val /= 2;

            Console.WriteLine(val);

            if (val >= 0 && val <= .25f) {
                position = new Point(position.X + 1, position.Y);
            } else if (val > .25f && val <= .5f) {
                position = new Point(position.X - 1, position.Y);
            } else if (val > .5f && val <= .75f) {
                position = new Point(position.X, position.Y + 1);
            } else if (val > .75f && val <= 1) {
                position = new Point(position.X, position.Y - 1);
            }

            graphics1.FillRectangle(brush1, position.X, position.Y, 1, 1);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (!button2Toggled) {
                dataThread();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (button2Toggled == false) {
                button2Toggled = true;
                button2.Text = "Start Graph";
            } else {
                button2Toggled = false;
                button2.Text = "Pause Graph";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }
        }

        private void timer2_Tick(object sender, EventArgs e) {

            pictureThread();

            if (toggleType){
                if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }
            } else {
                //pictureThread();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            pictureThread();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {

        }

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            toggle2D = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            toggleType = checkBox2.Checked;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e) {
            timer2.Interval = (int)numericUpDown6.Value;
        }


    }
}