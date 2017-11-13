using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Bus:Vehicle
    {

        public int Seats { get; set; }

        public Bus(string registrationPlate, string color,int wheelCount, int numberOfSeats)
            : base(registrationPlate, color, wheelCount)
        {
            Seats = numberOfSeats;
        }


        public override string ToString()
        {
            var seats = Seats > 1 ? "seats" : "seat";
            return string.Format("Bus :{0}{1}{2} {3}",
                "\n",
                base.ToString(), Seats, seats);
        }

    }
}
