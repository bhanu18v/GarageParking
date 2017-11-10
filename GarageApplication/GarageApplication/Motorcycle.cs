using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Motorcycle:Vehicle
    {
        private int cylindervol;

        public int Cylindervol
        {
             get {return  cylindervol; }
             set { value = cylindervol ; }
        }

        public Motorcycle(string regnum, string col, int now, string tof, int cylinvol) : base(regnum, col, now, tof)
        {

            Cylindervol = cylinvol;
        }

        public Motorcycle()
        {
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The Cylinder Volume of the MotorCycle is:" + Cylindervol;
        }




    }
}
