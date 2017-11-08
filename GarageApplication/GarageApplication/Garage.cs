using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
   
        public class Garage<T> : IEnumerable<T> where T : Vehicle
        {
            private List<Vehicle> vehicle;



            private int parkingnumber = 0;
            private string name;

            private int id;

            private int capacity;

            public int Parkingnumber = 0;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {

                    name = value;
                }
            }

            public int Id
            {
                get { return id; }
                set { value = id; }

            }

            public int Capacity
            {

                get
                {

                    return capacity;
                }
                set
                {

                    capacity = value;

                }

            }

            public Garage(int maxCapacity)
            {
                this.Id = parkingnumber++;
                this.Name = name;
                this.Capacity = maxCapacity;
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }











            //     public string AddVehicle(Vehicle ve)
            //     {
            //         try
            //         {

            //             vehicle.Add(ve);
            //             return "\n Vehicle Added";
            //         }
            //         catch (Exception ex)
            //         {

            //             return "Exception Caught" + ex;
            //         }

            //     }











































        }




    }
}
