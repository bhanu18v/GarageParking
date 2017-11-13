using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Airplane:Vehicle
    {
        private int engineCount;
        public int EngineCount
        {
            get
            {
                return engineCount;
            }
            set
            {
                engineCount = value;
               
            }
        }

        public Airplane(string registrationNumber, string color, int wheelCount, int engineCount)
            : base(registrationNumber, color, wheelCount)
        {
            EngineCount = engineCount;
        }

        public override string ToString()
        {
            var formatted = string.Format("Airplane:{0}{1}{0}", System.Environment.NewLine, base.ToString());

            if (EngineCount > 0)
                formatted += $"{EngineCount} engines";

            return formatted;
        }



    }
}
