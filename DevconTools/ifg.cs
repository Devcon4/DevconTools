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
    //Image File Generator: Used to  create images.
    public static class ifg {

        public struct PixelData {

            public byte B;
            public byte G;
            public byte R;

            public PixelData(byte r, byte g, byte b) {
                R = r;
                G = g;
                B = b;
            }
        }

        public unsafe static Bitmap heightMap(int width, int height, float amplitude, int octive, int frequency) {
            Bitmap returnPic = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                returnPic.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                returnPic.PixelFormat);
            
            PixelData* pixelPtr = (PixelData*)(void*)bmpData.Scan0;

            for (int x = 0; x < height; x++) {
                for (int y = 0; y < width; y++) {

                    byte value = (byte)(((pnng.smoothNoise2D(x, y, amplitude, octive, frequency) + 1) / 2) * 255);
                    *pixelPtr = new PixelData(value, value, value);

                    pixelPtr++;
                }
            }

            // Unlock the bits.
            returnPic.UnlockBits(bmpData);

            return returnPic;
        }
    }
}
