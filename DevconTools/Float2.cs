using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {
    public struct Float2 {
        public float x, y;

        public Float2(float X, float Y) {
            x = X;
            y = Y;
        }

        //Addition.
        public static Float2 operator +(float value, Float2 floatA) { return new Float2(floatA.x + value, floatA.y + value); }
        public static Float2 operator +(Float2 floatA, Float2 floatB) { return new Float2(floatA.x + floatB.x, floatA.y + floatB.y); }

        //Subtraction.
        public static Float2 operator -(float value, Float2 floatA) { return new Float2(floatA.x - value, floatA.y - value); }
        public static Float2 operator -(Float2 floatA, Float2 floatB) { return new Float2(floatA.x - floatB.x, floatA.y - floatB.y); }

        //Multiplication.
        public static Float2 operator *(float value, Float2 floatA) { return new Float2(floatA.x * value, floatA.y * value); }
        public static Float2 operator *(Float2 floatA, Float2 floatB) { return new Float2(floatA.x * floatB.x, floatA.y * floatB.y); }

        //Division.
        public static Float2 operator /(float value, Float2 floatA) { return new Float2(floatA.x / value, floatA.y / value); }
        public static Float2 operator /(Float2 floatA, Float2 floatB) { return new Float2(floatA.x / floatB.x, floatA.y / floatB.y); }

        //Not Equal.
        //public static bool operator !=(Float2 floatA, Float2 floatB) { return !floatA.Equals(floatB); }

        //Equal.
        //public static bool operator ==(Float2 floatA, Float2 floatB) { return floatA.Equals(floatB); }

        //Variables.
        public float sqrMagnitude { get { return (x * x + y * y); } }
        public float magnitude { get { return (float)Math.Sqrt(sqrMagnitude); } }
        public Float2 normalized { get { return new Float2(x / magnitude, y / magnitude); } }

        //Functions.
        public static float dotProduct(Float2 floatA, Float2 floatB) { return (floatA.x * floatB.x + floatA.y * floatB.y); }
    }
}
