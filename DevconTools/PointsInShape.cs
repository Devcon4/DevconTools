using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevconTools {

    class PointsInShape {

        public static List<Float3> Rectangle(Float3 length, Float3 divisor, Float3 multiplier) {
            List<Float3> values = new List<Float3>();
            for (float i = -length.x / divisor.x; i < length.x / divisor.x; i++) {
                for (float j = -length.y / divisor.y; j < length.y / divisor.y; j++) {
                    for (float k = -length.z / divisor.y; k < length.z / divisor.y; k++) {
                        values.Add(new Float3(j * multiplier.x, k * multiplier.y, i * multiplier.z));
                    }
                }
            }
            return values;
        }

    }
}