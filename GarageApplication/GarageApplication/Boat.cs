using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Boat:Vehicle
    {
        private int length;
        public int Length;

        public Boat(int reg, string col, int now, string tof, int len) : base(reg, col, now, tof)
        {
            
            Length = len;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The Length Of the Boat is" + Length;
        }

    }
}
