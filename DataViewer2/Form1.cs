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
using System.Windows.Forms;
using DevconTools;

namespace DataViewer2 {

    public partial class Form1 : Form {

        private bool button2Toggled = false;
        private bool toggle2D = false;
        private bool toggleType = false;
        private float interval = 0;
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

            float point1 = pnng.smoothNoise(interval, (float)numericUpDown2.Value, (int)numericUpDown3.Value, (float)numericUpDown4.Value);
            float point2 = pnng.smoothNoise(interval, 1, 1, 1);
            float point3 = pnng.smoothNoise(interval, (float)numericUpDown2.Value, (int)numericUpDown3.Value, (float)numericUpDown4.Value);

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

            if (toggle2D && toggleType) {
                pictureBox1.Image = ifg.quickHeightMap(pictureBox1.Width, pictureBox1.Height, (float)numericUpDown2.Value, (int)numericUpDown3.Value, (float)numericUpDown4.Value);
            } else if (toggle2D && !toggleType) {
                graphics1.FillRectangle(brush1, 10, 10, 1, 1);
            }
        }

        private void randomWalker() {

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


    }
}