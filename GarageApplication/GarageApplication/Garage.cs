using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
   
        class Garage<T> : IEnumerable<T> where T : Vehicle
        {
            public int ParkingNumber = 0;
            public int Id { get; set; }
            public string Name { get; set; }
            public List<T> Vehicles { get; set; }
            private int capacity;
            private string name;
            public int Capacity { get; set; }

            private static int parkingNumber = 0;


            public Garage(int maxCapacity)
            {
                this.Id = parkingNumber++;
                this.Name = name;
                this.Vehicles = new List<T>();
                this.Capacity = maxCapacity;
            }


            public override string ToString()
            {
                //return string.Format("{1, 30} {2, 3}", Id, Name, Vehicles.Count);
                return string.Format(Name, Vehicles.Count, Capacity);
            }


            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
    }
}
