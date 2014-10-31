using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {

    public static class pnng {

        #region Tools

//      Linear_Interpolation: Basic Interpolation. 
        public static float linear_Interpolation(float a, float b, float x) {
            float value = a * (1 - x) + b * x;
            return value;
        }
//      Cosine_Interpolation: Better Interpolation.
        public static double Cosine_Interpolation(double a, double b, double x) {

            double value = (1 - Math.Cos(x * Math.PI)) / 2;
            return (a * (1 - value) + b * value);
        }

        public static float noiseTool(int x) { return prng.fNoiseRandIMPROVED(x); }
        public static float noiseTool(int x, int y) { return prng.fNoiseRandIMPROVED( x, y); }

        #endregion
        #region Perilin Noise Number Generators.

        public static float rawNoise1D(int x) {
            float value = 0;
            value = noiseTool(x) / 2 + noiseTool(x - 1) / 4 + noiseTool(x + 1) / 4;
            return value;
        }

        public static float rawNoise2D(int x, int y) {
            float value = 0, corners = 0, sides = 0, center = 0;
            corners = ( noiseTool(x-1, y-1) + noiseTool(x+1, y-1) + noiseTool(x-1, y+1) + noiseTool(x+1, y+1) ) / 16;
            sides   = ( noiseTool(x-1, y) + noiseTool(x+1, y) + noiseTool(x, y-1) + noiseTool(x, y+1) ) /  8;
            center = noiseTool(x, y) / 4;
            value = corners + sides + center;
            return value;
        }

        public static float smoothNoise1D(int x, float persistence, int octave, int frequency) {
            float value = 0, amplitude;

            for (int i = 0; i < octave; i++) {
                frequency = (int)Math.Pow(frequency, i);
                amplitude = (float)Math.Pow(persistence, i);
                value += rawNoise1D(x * frequency) * amplitude;
            }
            return value;
        }

        public static float smoothNoise2D(int x, int y, float persistence, int octave, int frequency) {
            float value = 0, amplitude;

            for(int i=0; i<octave; i++){
                frequency = (int)Math.Pow(frequency, i);
                amplitude = (float)Math.Pow(persistence, i);
                value = value + rawNoise2D(x*frequency, y*frequency)*amplitude;
            }
            return value;
        }

        #endregion
    }
}
