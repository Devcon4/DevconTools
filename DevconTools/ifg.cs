using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
//using System.Threading.Tasks;
using System.Threading;

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

        public unsafe static Bitmap HeightMap(int width, int height) {
            Bitmap returnPic = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                returnPic.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                returnPic.PixelFormat);

            PixelData* pixelPtr = (PixelData*)(void*)bmpData.Scan0;

            for (int x = 0; x < height; x++) {
                for (int y = 0; y < width; y++) {

                    double value = pnng.Noise(x, y, 0);

                    value = ((value + 1) / 2) * 255;

                    byte bValue = (byte)value;

                    *pixelPtr = new PixelData(bValue, bValue, bValue);

                    pixelPtr++;
                }
            }

            // Unlock the bits.
            returnPic.UnlockBits(bmpData);

            return returnPic;
        }


        /*public unsafe static Bitmap QuickHeightMap(int width, int height, float depth) {
            Bitmap returnPic = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            BitmapData bitmapData = returnPic.LockBits(new Rectangle(0, 0, returnPic.Width, returnPic.Height), ImageLockMode.WriteOnly, returnPic.PixelFormat);

            int BytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(returnPic.PixelFormat) / 8;
            int heightInPixels = bitmapData.Height;
            int WidthInBytes = bitmapData.Width * BytesPerPixel;
            int ticks = Environment.TickCount;
            byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

            Parallel.For(0, heightInPixels, y => {
                byte* CurrentLine = PtrFirstPixel + (y * bitmapData.Stride);
                for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel) {
                    double value = 0;
                    value = pnng.Noise(x, y , .5f)*10;
                    value += pnng.Noise((x * 4), (y * 4), .5f) / 2;

                    value = ((value + 1) / 2) * 255;

                    byte bValue = (byte)value;

                    CurrentLine[x] = bValue;
                    CurrentLine[x + 1] = bValue;
                    CurrentLine[x + 2] = bValue;

                }
            });
            returnPic.UnlockBits(bitmapData);
            return returnPic;
        }*/
    }
}