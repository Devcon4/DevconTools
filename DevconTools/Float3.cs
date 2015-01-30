using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {
    public struct Float3 {
        public float x, y, z;

        public Float3(float X, float Y, float Z) {
            x = X;
            y = Y;
            z = Z;
        }

        //Addition.
        public static Float3 operator +(float value, Float3 floatA) { return new Float3(floatA.x + value, floatA.y + value, floatA.z + value); }
        public static Float3 operator +(Float3 floatA, Float3 floatB) { return new Float3(floatA.x + floatB.x, floatA.y + floatB.y, floatA.z + floatB.z); }

        //Subtraction.
        public static Float3 operator -(float value, Float3 floatA) { return new Float3(floatA.x - value, floatA.y - value, floatA.z - value); }
        public static Float3 operator -(Float3 floatA, Float3 floatB) { return new Float3(floatA.x - floatB.x, floatA.y - floatB.y, floatA.z - floatB.z); }

        //Multiplication.
        public static Float3 operator *(float value, Float3 floatA) { return new Float3(floatA.x * value, floatA.y * value, floatA.z * value); }
        public static Float3 operator *(Float3 floatA, Float3 floatB) { return new Float3(floatA.x * floatB.x, floatA.y * floatB.y, floatA.z * floatB.z); }

        //Division.
        public static Float3 operator /(float value, Float3 floatA) { return new Float3(floatA.x / value, floatA.y / value, floatA.z / value); }
        public static Float3 operator /(Float3 floatA, Float3 floatB) { return new Float3(floatA.x / floatB.x, floatA.y / floatB.y, floatA.z / floatB.z); }

        //Not Equal.
        //public static bool operator !=(Float3 floatA, Float3 floatB) { return !floatA.Equals(floatB); }

        //Equal.
        //public static bool operator ==(Float3 floatA, Float3 floatB) { return floatA.Equals(floatB); }

        //Variables.
        public float sqrMagnitude { get { return (x * x + y * y + z * z); } }
        public float magnitude { get { return (float)Math.Sqrt(sqrMagnitude); } }
        public Float3 normalized { get { return new Float3(x / magnitude, y / magnitude, z / magnitude); } }
        
        //Functions.
        public static float dotProduct(Float3 floatA, Float3 floatB) { return (floatA.x * floatB.x + floatA.y * floatB.y + floatA.z * floatB.z); }
    }
}
