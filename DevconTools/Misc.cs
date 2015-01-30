using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {
    class Misc {

        public static Float3 ClosestAngle(Float3 direction, Float3[] angles) {
            Float3 value = new Float3();
            float closestAngl = 1 / 0f;
            foreach (Float3 vec3 in angles) {
                float testingAngl = Math.Abs((vec3 - direction).sqrMagnitude);
                if (testingAngl < closestAngl) {
                    closestAngl = testingAngl;
                    value = vec3;
                }
            }

            return value;
        }

        public static Float3 Ceiling(Float3 position, int places) {
            Float3 value = new Float3();
            float x = position.x, y = position.y, z = position.z;

            if (x > 0) { x = (float)Math.Ceiling(x); } else { x = (float)Math.Floor(x); }
            if (y > 0) { y = (float)Math.Ceiling(y); } else { y = (float)Math.Floor(y); }
            if (z > 0) { z = (float)Math.Ceiling(z); } else { z = (float)Math.Floor(z); }

            x = (float)Math.Round(x / places, 0, MidpointRounding.AwayFromZero) * places;
            y = (float)Math.Round(y / places, 0, MidpointRounding.AwayFromZero) * places;
            z = (float)Math.Round(z / places, 0, MidpointRounding.AwayFromZero) * places;

            value = new Float3(x, y, z);
            return value;
        }

    }
}
