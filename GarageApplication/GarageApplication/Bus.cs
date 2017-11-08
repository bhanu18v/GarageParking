using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Bus:Vehicle
    {

        private int no_Of_Seats;
        public int No_Of_Seats
        {
            get { return no_Of_Seats; }
            set { No_Of_Seats = value; }
        }

        public Bus(int reg, string col, int now, string tof, int nos) : base(reg, col, now, tof)
        {
            No_Of_Seats = nos;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The Bus contains" + No_Of_Seats + "seats\n";
        }

    }
}
