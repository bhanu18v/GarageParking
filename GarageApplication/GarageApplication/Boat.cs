using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Boat:Vehicle
    {
        private float length;
        public float Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public Boat(string registrationPlate, string color, int wheelCount, float length)
            : base(registrationPlate, color,wheelCount)
        {
            Length = length;
        }

        public override string ToString()
        {
            return string.Format("Boat :{0}{1}{0}{2} ft", System.Environment.NewLine, base.ToString(), Length);
        }

    }
}
