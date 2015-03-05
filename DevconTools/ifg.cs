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

                    double value = pnng.Noise(x, y, DateTime.Now.Millisecond / 10);


                    value = convert.InfiniteToDecimal(value);
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


        public unsafe static Bitmap QuickHeightMap(int width, int height, float depth) {
            Bitmap returnPic = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            BitmapData bitmapData = returnPic.LockBits(new Rectangle(0, 0, returnPic.Width, returnPic.Height), ImageLockMode.WriteOnly, returnPic.PixelFormat);

            int BytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(returnPic.PixelFormat) / 8;
            int heightInPixels = bitmapData.Height;
            int WidthInBytes = bitmapData.Width * BytesPerPixel;
            int ticks = Environment.TickCount;
            byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

            //value = pnng.Noise((((x / 3) * freq) / 100), ((y * freq) / 100)) / amp;

            float freq = .02f, amp = .1f;

            for (int y = 1; y < heightInPixels + 1; y++) {
                byte* CurrentLine = PtrFirstPixel + (y * bitmapData.Stride);
                for (int x = 1; x < WidthInBytes + 1; x = x + BytesPerPixel) {
                    double value = 0;
                    value = pnng.Noise((((x / 3) * freq)), (y * freq), (depth)*freq) / amp;
                    //value += pnng.Noise((((x / 3) * (freq * 4))), ((y * (freq * 4)))) / (amp / 4);
                    //value += pnng.Noise((((x / 3) * (freq * 8))), ((y * (freq * 8)))) / (amp / 8);

                    //value = convert.InfiniteToDecimal(value);

                    value = ((value + 1) / 2) * 255;

                    //byte bValue = (byte)value;

                    CurrentLine[x] = (byte)(value);
                    CurrentLine[x + 1] = (byte)(value / 4);
                    CurrentLine[x + 2] = (byte)(value / 2);

                }
            }
            returnPic.UnlockBits(bitmapData);
            return returnPic;
        }
    }
}