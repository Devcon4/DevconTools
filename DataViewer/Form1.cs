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
                                          @"C:\Users\Home\Desktop\Data2D-23.txt");
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
            int width = Graphic1.Width;
            int height = Graphic1.Height;
            Bitmap pic = spBitmap(width, height);
            if (Graphic1.Image != null) Graphic1.Image.Dispose();
            Graphic1.Image = pic;
            pic.Save(@"C:\Users\Home\Desktop\DataNew2D-5.png");
            updateGraphics();
        }

        public Bitmap spBitmap(int width, int height) {
            Bitmap value = new Bitmap(width, height);

            float lastNoise;
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    float noise = ((((float)pnng.Noise(i, j, 0) + 1) / 2) * 255);
                    lastNoise = noise;

                    Color clr = Color.FromArgb((int)noise, (int)noise, (int)noise);
                    value.SetPixel(i, j, clr);
                }
            }

            return value;
        }

        public Bitmap noisyBitmap(int width, int height) {
            Bitmap returnPic = new Bitmap(width, height);

            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                returnPic.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                returnPic.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            int bytes = bmpData.Stride * height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            int rgbLength = 0;
            for (int i = 0; i < bmpData.Stride; i++) {
                for (int j = 0; j < height; j++) {
                    //float noise = 100;
                    float noise = ((pnng.smoothNoise(i+interval, j+interval, 1, 1, 1)+1)/2)*256;
                    //addToText("x:"+i+" y:"+j+" noise:"+noise);
                    rgbValues[rgbLength] = (byte)noise;
                    rgbLength++;
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