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
            // var garage  = new GarageEx<T>();
            Console.WriteLine("Welcome! ,Enter maximum capacity of the Garage");
            int maxcapacity = int.Parse(Console.ReadLine());
            Garage<Vehicle> garageex;
            garageex = new Garage<Vehicle>(maxcapacity);
            var added = true;
            do
            {
                added = AddVehicle(garageex);
            }
            while (added);
            Console.WriteLine("==============");
            garageex.List();
           // Console.WriteLine(garage);
            Console.ReadLine();
        }

        private static bool AddVehicle(Garage<Vehicle> garageexm)
        {
            Console.WriteLine("Enter your registration number");
            string regnr = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(regnr)) return false;
            Console.WriteLine("Enter your vehicle color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter number of wheels of your vehicle");
            int wheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Model Type of your vehicle");
            string model = Console.ReadLine();

           Vehicle vehicle = new Vehicle(regnr, color, wheels, model);

              garageexm.Add(vehicle);
            
            return true;
        }




    }
}
