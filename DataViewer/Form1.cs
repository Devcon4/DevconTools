using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevconTools;
namespace DataViewer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            Random r = new Random();
            int width = 100;
            int height = 100;
            byte[] pixelValues = makeNoise();

            Bitmap pic = ifg.CreateBitmapFromBytes(pixelValues, width, height, "Data2D-1");
            if (Graphic1.Image != null) Graphic1.Image.Dispose();
            Graphic1.Image = pic;
            

        }

        public byte[] makeNoise(){
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
            byte[] byteValues = new byte[values.Count];
            for(int o=0; o<values.Count-1; o++){
                for (float n = 0; n < 1; n += .1f) {
                    float num = (float)pnng.Cosine_Interpolation(values[o], values[o + 1], n);
                    byteValues[o] = (byte)num;

                }
            }
            return byteValues;
        }
    }
}