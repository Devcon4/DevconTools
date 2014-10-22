using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DevconTools {
    //Image File Generator: Used simply create images.
    public static class ifg {

        public static Bitmap CreateBitmapFromBytes(byte[] pixelValues, int width, int height, string fileName) {
            //Create an image that will hold the image data
            Bitmap pic = new Bitmap(width, height, PixelFormat.Format16bppGrayScale);

            //Get a reference to the images pixel data
            Rectangle dimension = new Rectangle(0, 0, pic.Width, pic.Height);
            BitmapData picData = pic.LockBits(dimension, ImageLockMode.ReadWrite, pic.PixelFormat);
            IntPtr pixelStartAddress = picData.Scan0;

            //Copy the pixel data into the bitmap structure
            Marshal.Copy(pixelValues, 0, pixelStartAddress, pixelValues.Length);

            pic.UnlockBits(picData);
            return pic;
            
            //pic.Save(@"C:\Users\Home\Desktop\Data2D.png", ImageFormat.Png);
        }
    }
}
