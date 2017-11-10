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
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Boat(string regnum, string col, int now, string tof, int len) : base(regnum, col, now, tof)
        {
            
            Length = len;
        }

        public Boat()
        {
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The Length Of the Boat is" + Length;
        }

    }
}
