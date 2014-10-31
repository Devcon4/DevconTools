using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevconTools;
using System.Timers;
namespace DataViewer {
    public partial class MainForm : Form {
        System.IO.StreamWriter textStream = new System.IO.StreamWriter(
                                          @"C:\Users\Home\Desktop\Data2D-1.txt");
        public int interval = 0;
        public MainForm() {
            InitializeComponent();
            Draw();
            //System.Timers.Timer oTimer = new System.Timers.Timer(10);
            //oTimer.Elapsed += new ElapsedEventHandler(update);

            //oTimer.AutoReset = true;
            //oTimer.Enabled = true;

            //System.Threading.Thread.Sleep(5);
        }

        private void update(object source, ElapsedEventArgs e) {

            interval += 1;
            Draw();
        }

        public void Draw() {

            Random r = new Random();
            int width = Graphic1.Width;
            int height = Graphic1.Height;
            Bitmap pic = null;
            pic = noisyBitmap(width, height);
            if (Graphic1.Image != null) Graphic1.Image.Dispose();
            Graphic1.Image = pic;
            //pic.Save(@"C:\Users\Home\Desktop\Data2D-1.png");
            updateGraphics();
        }

        public Bitmap noisyBitmap(int width, int height) {
            Bitmap returnPic = new Bitmap(width, height);

            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                returnPic.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                returnPic.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            int bytes = Math.Abs(bmpData.Stride) * returnPic.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    float noise = pnng.smoothNoise2D(i, j, 1, 1, 1);
                    addToText("x:"+i+" y:"+j+" noise:"+noise);
                    rgbValues[i + j] = (byte)noise;
                }
            }

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            returnPic.UnlockBits(bmpData);

            //closeTextStream();
            return returnPic;
        }

        delegate void GraphicsCallback();
        private void updateGraphics() {
            if (this.Graphic1.InvokeRequired) {
                GraphicsCallback d = new GraphicsCallback(updateGraphics);
                this.Invoke(d);
            } else {
                Graphic1.Update();
            }
        }

        public void addToText(String text) {
            textStream.Write(text);
        }
        public void closeTextStream() {
            textStream.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            interval += 10;
            Draw();
        }
    }
}