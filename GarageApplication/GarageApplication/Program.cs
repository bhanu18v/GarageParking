using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleUI gc = new VehicleUI();
            gc.createGarage();
            Vehicle vem = new Vehicle();
            vem.AddVehicle();
           vem.printVehicle();
            Console.ReadLine();
        }


       



    }
}
