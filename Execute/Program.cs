using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DevconTools;

namespace Execute {
    public class Program {
        private static System.IO.StreamWriter textStream = new System.IO.StreamWriter(
                                                           @"C:\Users\Devyn\Desktop\DataMT-2.txt");
        private static System.IO.StreamWriter xmlStream = new System.IO.StreamWriter(
                                                   @"C:\Users\Devyn\Desktop\XDataMT-2.xml");

        public static void print(dynamic input) { Console.WriteLine(input); }
        public static void readKey() { Console.ReadKey(); }
        public static bool bReadKey() { Console.ReadKey(); return true; }


        static void Main(string[] args) {

            //smoothNoiseMTTest();
            
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
            for (int i = 0; i < values.Count-1; i++ ) {
                for (float j = 0; j < 1; j += .1f) {
                    float value = (float)pnng.Cosine_Interpolation(values[i], values[i + 1], j);

                    textC.values.Add(value);
                    addToText(value.ToString());
                }
            }

            serializeXML(xmlSserializer, textC);
            closeTextStream();

        }

        public static void cosineTest(){
            int j = 0;
            List<float> values = new List<float>();
            for (int i = 0; true; i=DateTime.Now.Millisecond ) {
                if (i<DateTime.Now.Millisecond) {
                    //float k = pnng.rawNoise1D(DateTime.Now.Millisecond, 100);
                    //values.Add(k);
                    j++;
                }

                if (j >= 100) {
                    break;
                }   
            }
            for(int o=0; o<values.Count-1; o++){
                for (float n = 0; n < 1; n += .1f) {
                    float num = (float)pnng.Cosine_Interpolation(values[o], values[o + 1], n);
                    //textC.values.Add(num);
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

        public static void serializeXML(System.Xml.Serialization.XmlSerializer xmlSerializer, Text textC) {
            xmlSerializer.Serialize(xmlStream, textC);
            xmlStream.Close();
        }

        public static void addToText(String text) {
            textStream.Write(text+"\n");
        }
        public static void closeTextStream() {
            textStream.Close();
        }
    }
}
