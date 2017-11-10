using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
  public  class Vehicle
    {
       
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int No_Of_Wheels { get; set; }
        public string ModelType { get; set; }
        public Vehicle()
        {

        }

        public Vehicle(string regnum, string color, int no_Of_Wheels, string modelType)
        {
            RegistrationNumber = regnum;
            Color = color;
            No_Of_Wheels = no_Of_Wheels;
            ModelType = modelType;

        }

        public virtual string PrintVehicle()
        {
            return "RegistrationNumber: " + RegistrationNumber + ", Color: " + Color+", Number of Wheels"+ No_Of_Wheels+", Model Type "+ ModelType;
        }

    }
}
