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

        private static System.IO.StreamWriter textStream = new System.IO.StreamWriter(
                                                           @"C:\Users\Home\Desktop\DataIMP-1.txt");

        public static void print(dynamic input) { Console.WriteLine(input); }
        public static void readKey() { Console.ReadKey(); }
        public static bool bReadKey() { Console.ReadKey(); return true; }


        static void Main(string[] args) {
            smoothNoiseIMPROVEDTest();
            
        }

        static void smoothNoiseIMPROVEDTest() {
            int height = 25;
            
            for (int i = 0; i < height; i++) {
                float num = pnng.smoothNoise1D(i, 1, 1, 1);
                string text = " X:" + i + " num:" + num.ToString();
                addToText(text);

            }

            closeTextStream();

        }

        static void cosineTest(){
            Text textC = new Text();
            int j = 0;
            List<float> values = new List<float>();
            for (int i = 0; true; i=DateTime.Now.Millisecond ) {
                if (i<DateTime.Now.Millisecond) {
                    float k = pnng.rawNoise1D(DateTime.Now.Millisecond);
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

        public static void addToText(String text) {
            textStream.Write(text);
        }
        public static void closeTextStream() {
            textStream.Close();
        }
    }
}
