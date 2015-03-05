/* Purpose: This class contains all Perlin Noise members.
 * 
 * Special Notes: N/A.
 * 
 * Author: Devyn Cyphers; Devcon.
 */

using System;

namespace DevconTools {

    ///<summary>
    ///Perlin Noise Number Generator</summary>
    ///<remarks>
    ///Perlin Noise is usefull to make natural looking "Randomness."</remarks>
    public static class pnng {

        // First implimentation of perlin noise.
        #region PerlinNoiseV1.0
        //Perlin Noise V. 1.0
        #region Tools

        // Linear_Interpolation: Basic Interpolation. 
        private static float linear_Interpolation(float a, float b, float x) {
            float value = a * (1 - x) + b * x;
            return value;
        }
        // Cosine_Interpolation: Better Interpolation.
        private static double Cosine_Interpolation(double a, double b, double x) {

            double value = (1 - Math.Cos(x * Math.PI)) / 2;
            return (a * (1 - value) + b * value);
        }

        // MersenneTwister wrapers.
        private static float noiseTool(float x) { return prng.MersenneTwister(x); }
        private static float noiseTool(float x, float y) { return prng.MersenneTwister(x + (y * 57)); }

        #endregion
        #region Perilin Noise Number Generators.

        /// <summary>
        /// [OBSOLETE]PerlinNoiseV1_0.
        /// Used to create basic perlin noise.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <returns>Returns nosie.</returns>
        public static float rawNoise(float x) {
            float value = 0;
            value = noiseTool(x) / 2 + noiseTool(x - 1) / 4 + noiseTool(x + 1) / 4;
            value /= 0x7fffffff;
            return value;
        }

        /// <summary>
        /// [OBSOLETE]PerlinNoiseV1_0.
        /// Used to create basic perlin noise.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <returns>Returns noise.</returns>
        public static float rawNoise(float x, float y) {
            float value = 0, corners = 0, sides = 0, center = 0;
            corners = (noiseTool(x - 1, y - 1) + noiseTool(x + 1, y - 1) + noiseTool(x - 1, y + 1) + noiseTool(x + 1, y + 1)) / 16;
            sides = (noiseTool(x - 1, y) + noiseTool(x + 1, y) + noiseTool(x, y - 1) + noiseTool(x, y + 1)) / 8;
            center = noiseTool(x, y) / 4;
            value = corners + sides + center;
            value /= 0x7fffffff;
            return value;
        }

        /// <summary>
        /// Used to create smoothed noise.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="amplitude">Amplitude of the noise.</param>
        /// <param name="octave">Octave of the noise.</param>
        /// <param name="frequency">Frequency of the noise.</param>
        /// <returns>Returns noise.</returns>
        public static float smoothNoise(float x, float amplitude, int octave, float frequency) {
            float value = 0;
            for (int i = 0; i < octave; i++) {
                value += rawNoise(x * frequency) / amplitude;
            }
            return value;
        }

        /// <summary>
        /// Used to create smoothed noise.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="amplitude">Amplitude of the noise.</param>
        /// <param name="octave">Octave of the noise.</param>
        /// <param name="frequency">Frequency of the noise.</param>
        /// <returns>Returns noise.</returns>
        public static float smoothNoise(float x, float y, float amplitude, int octave, float frequency) {
            float value = 0;
            for (int i = 0; i < octave; i++) {
                value += rawNoise(x * frequency, y * frequency) / amplitude;
            }
            return value;
        }

        #endregion
        #endregion

        // Second implimentation of perlin noise.
        #region PerlinNoiseV2.0

        /// <summary>
        /// PerlinNoiseV2_0.
        /// Noise using an improved algorithm.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="z">Z coordinate.</param>
        /// <returns>Returns noise.</returns>
        public static double Noise(double x, double y, double z) {
            int X = (int)Math.Floor(x) & 255,
                Y = (int)Math.Floor(y) & 255,
                Z = (int)Math.Floor(z) & 255;
            x -= Math.Floor(x);
            y -= Math.Floor(y);
            z -= Math.Floor(z);
            double u = fade(x),
                   v = fade(y),
                   w = fade(z);
            int A = p[X] + Y, AA = p[A] + Z, AB = p[A + 1] + Z,
                B = p[X + 1] + Y, BA = p[B] + Z, BB = p[B + 1] + Z;

            return lerp(w, lerp(v, lerp(u, grad(p[AA], x, y, z),
                                           grad(p[BA], x - 1, y, z)),
                                   lerp(u, grad(p[AB], x, y - 1, z),
                                           grad(p[BB], x - 1, y - 1, z))),
                           lerp(v, lerp(u, grad(p[AA + 1], x, y, z - 1),
                                           grad(p[BA + 1], x - 1, y, z - 1)),
                                   lerp(u, grad(p[AB + 1], x, y - 1, z - 1),
                                           grad(p[BB + 1], x - 1, y - 1, z - 1))));
        }

        /// <summary>
        /// PerlinNoiseV2_0.
        /// Noise using an improved algorithm.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <returns>Returns noise.</returns>
        public static double Noise(double x, double y) {
            int X = (int)Math.Floor(x) & 255,
                Y = (int)Math.Floor(y) & 255;
            x -= Math.Floor(x);
            y -= Math.Floor(y);
            double u = fade(x),
                   v = fade(y);
            int A = p[X] + Y, AA = p[A], AB = p[A + 1],
                B = p[X + 1] + Y, BA = p[B], BB = p[B + 1];

            return lerp(v, lerp(u, grad(p[AA], x, y),
                                   grad(p[BA], x - 1, y)),
                           lerp(u, grad(p[AB], x, y - 1),
                                   grad(p[BB], x - 1, y - 1)));
        }

        /// <summary>
        /// PerlinNoiseV2_0.
        /// Noise using an improved algorithm.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <returns>Returns noise.</returns>
        public static double Noise(double x) {
            int X = (int)Math.Floor(x) & 255;
            x -= Math.Floor(x);
            double u = fade(x);

            return lerp(u, grad(p[X], x),
                           grad(p[X + 1], x - 1));
        }

        // Extrapolation f(t) = 6t^5 - 15t^4 + 10t^3
        private static double fade(double t) { return t * t * t * (t * (t * 6 - 15) + 10); }

        // Dot product of two points.
        private static double lerp(double t, double a, double b) { return a + t * (b - a); }

        // Calculates gradient vector.
        private static double grad(int hash, double x, double y, double z) {
            int h = hash & 15;
            double u = h < 8 ? x : y,
                   v = h < 4 ? y : h == 12 || h == 14 ? x : z;
            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
        }

        // Calculates gradient vector.
        private static double grad(int hash, double x, double y) {
            int h = hash & 15;
            double u = h < 8 ? x : y,
                v = h < 4 ? x / 2 : h > 12 ? y / 2 : x;
            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
        }

        // Calculates gradient vector.
        private static double grad(int hash, double x) {
            int h = hash & 15;
            double u = h < 8 ? x : -x,
                   v = h < 4 ? x / 2 : -x / 2;
            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
        }

        // precompiled array.
        private static int[] p = new int[512], permutation = { 151,160,137,91,90,15,
            131,13,201,95,96,53,194,233,7,225,140,36,103,30,69,142,8,99,37,240,21,10,23,
            190, 6,148,247,120,234,75,0,26,197,62,94,252,219,203,117,35,11,32,57,177,33,
            88,237,149,56,87,174,20,125,136,171,168, 68,175,74,165,71,134,139,48,27,166,
            77,146,158,231,83,111,229,122,60,211,133,230,220,105,92,41,55,46,245,40,244,
            102,143,54, 65,25,63,161, 1,216,80,73,209,76,132,187,208, 89,18,169,200,196,
            135,130,116,188,159,86,164,100,109,198,173,186, 3,64,52,217,226,250,124,123,
            5,202,38,147,118,126,255,82,85,212,207,206,59,227,47,16,58,17,182,189,28,42,
            223,183,170,213,119,248,152, 2,44,154,163, 70,221,153,101,155,167, 43,172,9,
            129,22,39,253, 19,98,108,110,79,113,224,232,178,185, 112,104,218,246,97,228,
            251,34,242,193,238,210,144,12,191,179,162,241, 81,51,145,235,249,14,239,107,
            49,192,214, 31,181,199,106,157,184, 84,204,176,115,121,50,45,127, 4,150,254,
            138,236,205,93,222,114,67,29,24,72,243,141,128,195,78,66,215,61,156,180
        };
        static pnng() { for (int i = 0; i < 256; i++) { p[256 + i] = p[i] = permutation[i]; } }
        #endregion
    }
}