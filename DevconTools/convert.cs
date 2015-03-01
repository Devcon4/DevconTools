using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;

namespace DevconTools {
    //Conversions.
    public static class convert {

        public static Byte[] floatAToByteA(float[] floatArray1){
            // create a byte array and copy the floats into it...
            var byteArray = new byte[floatArray1.Length * 4];
            Buffer.BlockCopy(floatArray1, 0, byteArray, 0, byteArray.Length);

            // create a second float array and copy the bytes into it...
            var floatArray2 = new float[byteArray.Length / 4];
            Buffer.BlockCopy(byteArray, 0, floatArray2, 0, byteArray.Length);

            return byteArray;
        }

    }
}
