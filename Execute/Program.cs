using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using DevconTools;
using System.Timers;

namespace Execute {
    public class Program {
        private static System.IO.StreamWriter textStream = new System.IO.StreamWriter(
                                                           @"C:\Users\Devyn\Desktop\DataMT-3.txt");
        private static System.IO.StreamWriter xmlStream = new System.IO.StreamWriter(
                                                   @"C:\Users\Devyn\Desktop\XDataMT-3.xml");

        public static void print(dynamic input) { Console.WriteLine(input); }
        public static void readKey() { Console.ReadKey(); }
        public static bool bReadKey() { Console.ReadKey(); return true; }

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

        static void Main(string[] args) {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Bitmap noise = ifg.heightMap(10000, 10000, 1, 1, 1);
            timer.Stop();
            Console.WriteLine("Time: {0}", timer.Elapsed);
            //speedTests2(128, 128);
            print("Created Image----------");
            noise.Save(@"C:\Users\Devyn\Desktop\Data2D-14.png");
            print("Saved Image------------");
            readKey();

            //smoothNoiseMTTest();

        }

        static void speedTests1() {
            Stopwatch timer = new Stopwatch();
            float noise1D = 0, noise2D = 0;
            timer.Start();
            for (int i = 0; i < 100000; i++) {
                noise1D += pnng.smoothNoise1D(1, 1, 1, 1);
            }
            noise1D /= 100000;
            timer.Stop();
            Console.WriteLine("Noise1D: {0}, time: {1}", noise1D, timer.Elapsed);
            timer.Reset();
            timer.Start();
            for (int i = 0; i < 100000; i++) {
                noise2D += pnng.smoothNoise2D(1, 1, 1, 1, 1);
            }
            noise2D /= 100000;
            timer.Stop();
            Console.WriteLine("Noise2D: {0}, time: {1}", noise2D, timer.Elapsed);

        }

        static void speedTests2(int height, int width) {
            Stopwatch timer = new Stopwatch();
            Bitmap noiseLock = null;

            timer.Start();
            noiseLock = lockBitmap(height, width);
            timer.Stop();
            Console.WriteLine("NoiseLock Time: {0}", timer.Elapsed);
            timer.Reset();

            noiseLock.Save(@"C:\Users\Devyn\Desktop\Data2D-15.png", System.Drawing.Imaging.ImageFormat.Png);

            print("Image Saved------------");

            //timer.Start();
            //noiseSP = spBitmap(size, size);
            //timer.Stop();
            //Console.WriteLine("NoiseSP Time: {0}", timer.Elapsed);

            //noiseSP.Save(@"C:\Users\Devyn\Desktop\Data2D-5.png");

        }

        public static Bitmap spBitmap(int width, int height) {
            Bitmap value = new Bitmap(width, height);

            float lastNoise;
            Parallel.For(0, width, i => {
                for (int j = 0; j < height; j++) {
                    float noise = (((pnng.smoothNoise2D(i, j, 1, 1, 1) + 1) / 2) * 255);
                    lastNoise = noise;

                    Color clr = Color.FromArgb((int)noise, (int)noise, (int)noise);
                    value.SetPixel(i, j, clr);
                }
            });

            return value;
        }

        public unsafe static Bitmap lockBitmap(int width, int height) {
            Bitmap returnPic = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                returnPic.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                returnPic.PixelFormat);

            //int bytesPerPixel = 3;

            PixelData* pixelPtr = (PixelData*)(void*)bmpData.Scan0;

            for (int x = 0; x < height; x++) {
                for (int y = 0; y < width; y++) {

                    byte value = (byte)(((pnng.smoothNoise2D(x, y, 1, 1, 1) + 1) / 2) * 255);

                    *pixelPtr = new PixelData(value, value, value);

                    pixelPtr++;
                }
            }

            // Unlock the bits.
            returnPic.UnlockBits(bmpData);

            return returnPic;
        }

        static void smoothNoiseMTTest() {
            Text textC = new Text();
            System.Xml.Serialization.XmlSerializer xmlSserializer = new System.Xml.Serialization.XmlSerializer(textC.GetType());

            int height = 100;
            height -= 1;
            List<float> values = new List<float>();
            for (int i = 0; i < height; i++) {
                float num = pnng.smoothNoise1D(i, 1, 1, 1);
                values.Add(num);
            }
            for (int i = 0; i < values.Count - 1; i++) {
                for (float j = 0; j < 1; j += .1f) {
                    float value = (float)pnng.Cosine_Interpolation(values[i], values[i + 1], j);

                    textC.values.Add(value);
                    addToText(value.ToString());
                }
            }

            serializeXML(xmlSserializer, textC);
            closeTextStream();

        }

        public static void cosineTest() {
            int j = 0;
            List<float> values = new List<float>();
            for (int i = 0; true; i = DateTime.Now.Millisecond) {
                if (i < DateTime.Now.Millisecond) {
                    //float k = pnng.rawNoise1D(DateTime.Now.Millisecond, 100);
                    //values.Add(k);
                    j++;
                }

                if (j >= 100) {
                    break;
                }
            }
            for (int o = 0; o < values.Count - 1; o++) {
                for (float n = 0; n < 1; n += .1f) {
                    float num = (float)pnng.Cosine_Interpolation(values[o], values[o + 1], n);
                    //textC.values.Add(num);
                    print("num:" + num + " count:" + o);
                    addToText(num.ToString());
                }
            }


            closeTextStream();
        }

        //Old xml code. not functional.
        public static void xmlSerialization() {

            //System.IO.StreamWriter file = new System.IO.StreamWriter(
            //@"C:\Users\Home\Desktop\Data-4.xml");

            //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(textC.GetType());
            //x.Serialize(file, textC);
            //file.Close();
        }

        public static void serializeXML(System.Xml.Serialization.XmlSerializer xmlSerializer, Text textC) {
            xmlSerializer.Serialize(xmlStream, textC);
            xmlStream.Close();
        }

        public static void addToText(String text) {
            textStream.Write(text + "\n");
        }
        public static void closeTextStream() {
            textStream.Close();
        }
    }
}
