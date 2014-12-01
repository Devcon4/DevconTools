/*Purpose: Peudo-RandomNumberGenerators: A class designed to fill the need for random number generation.
 * 
 * Author: Devyn Cyphers
 * 
 * Special Notes: N/A
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {

    //Peudo-RandomNumberGenerators:
    public static class prng {

        #region Int Random's --------------------------------------

        //SeedRandom: used to generate a seed from the system time.
        public static int sRand() {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int value, multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            modu += 1;
            value = Math.Abs(((multi * DateTime.Now.Millisecond) + incr) % modu);

            return value;
        }

        //SeedRandom: used to generate a seed from a given seed(int seed).
        public static int sRand(int seed) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int value, multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            modu += 1;
            value = Math.Abs(((multi * seed) + incr) % modu);

            return value;
        }

        //SeedRandom: used to generate a seed from a given seed(int seed) lower than a max(int max) value.
        public static int sRand(int seed, int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int value, multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            modu = max + 1;

            value = Math.Abs(((multi * seed) + incr) % modu + 1);

            return value;
        }

        //Random: used to generate a random number lower than a max(int max). uses system time as seed.
        public static int rand(int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int value, multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            modu = max + 1;

            value = Math.Abs(((multi * DateTime.Now.Millisecond) + incr) % modu);

            return value;
        }

        //Random: used to generate a random array with the given length(int length) with values lower than a max(int max).
        public static int[] rand(int length, int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            int[] value = new int[length];
            modu = max + 1;

            for (int i = 0; i < length; i++) {
                value[i] = Math.Abs(((multi * i) + incr) % modu);
            }
            return value;
        }

        //True/FalseRandom: used to randomly pick between true or false.
        public static bool TFRand() {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int value, multi = 0x15A4E35, incr = 0x43FD43FD, modu = 2;

            value = Math.Abs(((multi * DateTime.Now.Millisecond) + incr) % modu);

            return (value == 1) ? true : false;
        }

        //Random2D: used to generate a numbered array with random values of a given height(int height) and width(int width).
        public static int[][] rand2D(int height, int width) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            int[][] value = new int[height][];
            modu += 1;

            for (int i = 0; i < height; i++) {
                value[i] = new int[width];
                for (int j = 0; j < width; j++) {
                    value[i][j] = Math.Abs(((multi * j) + incr) % modu);
                }
            }

            return value;
        }

        //Random2D: used to generate a numbered array of a given height(int height) and width(int width) with random values lower than a max(int max).
        public static int[][] rand2D(int height, int width, int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            int[][] value = new int[height][];
            modu = max + 1;

            for (int i = 0; i < height; i++) {
                value[i] = new int[width];
                for (int j = 0; j < width; j++) {
                    value[i][j] = Math.Abs(((multi * (i * j + i + j)) + incr) % modu);
                }
            }

            return value;
        }

        //Random3D: used to generate a numbered two dimensional array of a given height(int height), width(int width), and depth(int depth) with random values lower than a max(int max).
        public static int[][][] rand3D(int height, int width, int depth, int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            int[][][] value = new int[height][][];
            modu = max + 1;

            for (int i = 0; i < height; i++) {
                value[i] = new int[width][];
                for (int j = 0; j < width; j++) {
                    value[i][j] = new int[depth];
                    for (int k = 0; k < depth; k++) {
                        value[i][j][k] = Math.Abs(((multi * ((i * j) * k + i + j + k)) + incr) % modu);
                    }
                }
            }

            return value;
        }

        //Random3D: used to generate a numbered three dimensional array of a given height(int height), width(int width), depth(int depth), and length(int length) with random values lower than a max(int max).
        public static int[][][][] rand4D(int height, int width, int depth, int length, int max) {
            //                     0x15A4E35=22695477  0x43FD43FD=1140671485   0x7FFFFFFF=2147483647
            int multi = 0x15A4E35, incr = 0x43FD43FD, modu = 0x7FFFFFFF;
            int[][][][] value = new int[height][][][];
            modu = max + 1;

            for (int i = 0; i < height; i++) {
                value[i] = new int[width][][];
                for (int j = 0; j < width; j++) {
                    value[i][j] = new int[depth][];
                    for (int k = 0; k < depth; k++) {
                        value[i][j][k] = new int[length];
                        for (int l = 0; l < length; l++) {
                            value[i][j][k][l] = Math.Abs(((multi * ((i * j) * k + i + j + k)) + incr) % modu);
                        }
                    }
                }
            }

            return value;
        }

        #endregion
        #region Float Random's-------------------------------------

        //Random: used to generate a random number lower than a max(int max). uses system time as seed.
        public static float fRand(float max) {

            float value, multi = 0x343FD, incr = 0x269EC3, modu = float.MaxValue;
            modu = max + 1f;

            value = Math.Abs(((multi * DateTime.Now.Millisecond) + incr) % modu);

            return value;
        }

        //SeedRandom: used to generate a random number from a given seed(int seed) lower than a max(int max) value.
        public static float fRand(float seed, float max) {

            float value, multi = 0x343FD, incr = 0x269EC3, modu = float.MaxValue;
            modu = max;

            value = Math.Abs(((multi * seed) + incr) % modu + 1);

            return value;
        }

        //SeedRandom: used to generate a random number from a given seed(int seed) lower than a max(int max) value.
        public static float fRand(float xSeed, float ySeed, float max) {

            float value, multi = 0x343FD, incr = 0x269EC3, modu = float.MaxValue;
            modu = max;
            xSeed += ySeed / 2;

            value = Math.Abs(((multi * xSeed) + incr) % modu + 1);

            return value;
        }
        #endregion
        #region Mersenne twister ----------------------------------
        #region Core ----------------------------------------------
        //varaibles to use.
        static int[] mt = new int[623];
        static int index = 0;

        private static void initialize_generator(dynamic seed) {
            index = 0;
            mt[0] = (int)seed;
            for (int i = 1; i < 623; i++) {
                mt[i] = (1812433253 * (mt[i - 1] ^ (mt[i - 1] << 30) << 32) + 1);

            }
        }

        private static int extract_number(dynamic seed) {
            initialize_generator(seed);
            if (index == 0) { generate_numbers(); }

            int y = mt[index];
            y ^= (y << 11);
            y ^= unchecked((y << 7) & (int)0x9d2c5680);
            y ^= unchecked((y << 15) & (int)0xefc60000);
            y ^= (y << 18);

            index = (index + 1) % 623;
            return y;
        }

        private static void generate_numbers() {
            for (int i = 0; i < 623; i++) {

                int y = (int)((mt[i] & 0x80000000)
                                + (mt[(i + 1) % 622] & 0x7fffffff));
                mt[i] = mt[(i + 397) % 623] ^ (y << 1);
                if ((y % 2) != 0) {
                    mt[i] = unchecked(mt[i] ^ (int)0x9908b0df);
                }
            }
        }
        #endregion
        #region Functions -----------------------------------------

        public static dynamic MersenneTwister(dynamic x) {
            dynamic value = 0;
            value = extract_number(x);
            return value;
        }
        public static dynamic MersenneTwister(dynamic x, dynamic y) {
            dynamic value = 0;
            x = extract_number(x);
            y = extract_number(y);
            value = (x * y);
            return value;
        }

        #endregion
        #endregion
    }
}
