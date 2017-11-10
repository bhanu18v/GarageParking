using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
  public  class Vehicle
    {
        //private string registrationNumber;
        //private string color;
        //private int no_Of_Wheels;
        //private string modelType;
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int No_Of_Wheels { get; set; }
        public string ModelType { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string registrationNumber,string color,int no_Of_Wheels,string modelType)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            No_Of_Wheels = no_Of_Wheels;
            ModelType = modelType;

        }
        List<Vehicle> vehicles = new List<Vehicle>();
        public void printVehicle()
        {           
            foreach (var item in vehicles)
            {
                Console.WriteLine("Displaying all the vehicles in our garage" + item);
            }
        }
    public void AddVehicle()
        {
            Console.WriteLine("\n Enter your registration number");
            string regnr = Console.ReadLine();

            Console.WriteLine("Enter your vehicle color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter number of wheels of your vehicle");
            int wheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Model Type of your vehicle");
            string model = Console.ReadLine();

            Vehicle vehi = new Vehicle(regnr, color, wheels, model);
      
            vehicles.Add(vehi);

       }
        //public string printVehicle()
        //{
        //    return "RegistrationNumber: " + this.RegistrationNumber + ", Color: " + Color + ", Number of Wheels" + No_Of_Wheels + ", Model Type " + ModelType;
        //}

        public override string ToString()
        {
            return "RegistrationNumber: " + RegistrationNumber + ", Color: " + Color + ", Number of Wheels: " + No_Of_Wheels + ", Model Type: " + ModelType;
        }

    }
}
