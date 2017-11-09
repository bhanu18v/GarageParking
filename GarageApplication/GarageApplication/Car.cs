using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Car:Vehicle
    {
        private string fuel_type;
        public string Fuel_Type
        {
            get { return fuel_type; }
            set { Fuel_Type = value; }
        }

        public Car(string reg, string col, int now, string tof, string fut) : base(reg, col, now, tof)
        {
            Fuel_Type = fut;
        }

        //public override string PrintVehicle()
        //{
        //    return base.PrintVehicle() + "\n Its a " + Fuel_Type + GetType().Name;
        //}



    }
}
