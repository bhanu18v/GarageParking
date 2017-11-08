using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class MotorCycle:Vehicle
    {
        private float cylinder_volume;
        public float Cylinder_Volume
        {
            get { return cylinder_volume; }
            set { cylinder_volume = value; }
        }

        public MotorCycle(int reg, string col, int now, string tof, float cyv) : base(reg, col, now, tof)
        {
            Cylinder_Volume = cyv;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The cylinder volume of the" + GetType().Name + "is" + Cylinder_Volume;
        }


    }
}
