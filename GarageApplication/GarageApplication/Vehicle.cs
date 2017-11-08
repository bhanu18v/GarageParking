using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
  public  class Vehicle
    {
        private string registrationNumber;
        private string color;
        private int no_Of_Wheels;
        private string modelType;
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int No_Of_Wheels { get; set; }
        public string ModelType { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string registrationNumber, string color, int no_Of_Wheels, string modelType)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            No_Of_Wheels = no_Of_Wheels;
            ModelType = modelType;

        }

    }
}
