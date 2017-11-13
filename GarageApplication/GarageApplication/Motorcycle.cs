using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Motorcycle:Vehicle
    {
        public float CylinderVolume { get; set; }

        public Motorcycle(string registrationNumber, string color, int wheelCount,float cylinderVolume)
            : base(registrationNumber, color, wheelCount)
        {
            CylinderVolume = cylinderVolume;
        }

        public override string ToString()
    {
            return string.Format("Motorcycle:{0}{1}{0}{2} cc", System.Environment.NewLine, base.ToString(), CylinderVolume); }
    }
}
