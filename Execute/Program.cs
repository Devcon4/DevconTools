using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DevconTools;

namespace Execute {
    public static class Program {

        public static void print(dynamic input) { Console.WriteLine(input); }
        public static void readKey() { Console.ReadKey(); }
        public static bool bReadKey() { Console.ReadKey(); return true; }


        static void Main(string[] args) {
            Random r = new Random();
            int width = 100;
            int height = 100;
            byte[] pixelValues = new byte[width * height*2];
            for (int i = 0; i < pixelValues.Length; ++i) {
                //Just create random pixel values, don't care about
                //being greyscale values for example
                pixelValues[i] = (byte)r.Next(0, 256);
            }

            //ifg.CreateBitmapFromBytes(pixelValues, width, height, "Data2D-1");

            Text textC = new Text();
            int j = 0;
            List<float> values = new List<float>();
            for (int i = 0; true; i=DateTime.Now.Millisecond ) {
                if (i<DateTime.Now.Millisecond) {
                    float k = pnng.Noise1D(DateTime.Now.Millisecond);
                    values.Add(k);
                    j++;
                }

                if (j >= 100) {
                    break;
                }   
            }
            for(int o=0; o<values.Count-1; o++){
                for (float n = 0; n < 1; n += .1f) {
                    float num = (float)pnng.Cosine_Interpolation(values[o], values[o + 1], n);
                    textC.values.Add(num);
                    print("num:"+num+" count:"+o);

                }
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(
                                          @"C:\Users\Home\Desktop\Data-4.xml");

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(textC.GetType());
            x.Serialize(file, textC);
            file.Close();
        }
    }
}
