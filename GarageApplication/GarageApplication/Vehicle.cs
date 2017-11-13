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
        public int WheelCount { get; set; }

        public Vehicle(string registrationNumber, string color, int wheelCount)
        {
            RegistrationNumber = registrationNumber.ToUpperInvariant();
            Color = color.ToLowerInvariant();
            WheelCount = wheelCount < 0 ? 0 : wheelCount;
        }

        public override string ToString()
        {
          
        
            var formatted = string.Format("Registration Number: {1}{0}{2}", System.Environment.NewLine, RegistrationNumber, Color);

            if (WheelCount > 0)
                formatted += $"\n{WheelCount} wheels";

            return formatted;
        }

    }
}
