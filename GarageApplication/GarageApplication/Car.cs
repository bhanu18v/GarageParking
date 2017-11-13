using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Car:Vehicle
    {
        public string Fuel { get; set; }

        public Car(string registrationPlate, string color, int wheelCount,string fuelType)
            : base(registrationPlate, color, wheelCount)
        {
            Fuel = fuelType;
        }

        public override string ToString()
        {
            return string.Format("Car:{0}{1}{0}Engine runs on {2}", System.Environment.NewLine, base.ToString(), Fuel);
        }



    }
}
