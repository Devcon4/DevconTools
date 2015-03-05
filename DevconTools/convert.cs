/* Purpose: A miscellaneous group of conversion methods.
 * 
 * Special Notes: N/A.
 * 
 * Author: Devyn Cyphers; Devcon.
 */

using System;

namespace DevconTools {

    /// <summary>
    /// Covert.
    /// </summary>
    /// <remarks>Useful for misc. conversions.</remarks>
    public static class convert {

        /// <summary>
        /// FloatAToByteA.
        /// Converts a float[] to a byte[].
        /// </summary>
        /// <param name="floatArray1">Array to convert.</param>
        /// <returns>Returns Byte[].</returns>
        public static Byte[] FloatAToByteA(float[] floatArray1) {
            // create a byte array and copy the floats into it.
            var byteArray = new byte[floatArray1.Length * 4];
            Buffer.BlockCopy(floatArray1, 0, byteArray, 0, byteArray.Length);

            // create a second float array and copy the bytes into it.
            var floatArray2 = new float[byteArray.Length / 4];
            Buffer.BlockCopy(byteArray, 0, floatArray2, 0, byteArray.Length);

            return byteArray;
        }

        /// <summary>
        /// InfiniteToDecimal.
        /// Takes any number and scales it from 0 - 1.
        /// Note: Conversion may be unstable.
        /// </summary>
        /// <param name="number">Number to scale.</param>
        /// <returns>Returns number from 0 - 1.</returns>
        public static double InfiniteToDecimal(double number) {
            return Math.Pow(number, 2) / (1 + Math.Pow(number, 2));
        }

        /// <summary>
        /// DecimalToInfinite
        /// Takes a decimal and scales it from 0 - Infinite.
        /// </summary>
        /// <param name="number">Number to scale.</param>
        /// <returns>Returns number from 0 - Infinite.</returns>
        public static double DecimalToInfinite(double number) {
            return Math.Log(number / (1 - number), Math.E);
        }
    }
}