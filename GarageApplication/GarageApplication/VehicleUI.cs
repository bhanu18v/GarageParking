using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
   public class VehicleUI
    {

        public void createGarage()
        {
            Console.WriteLine("Welcome to Garage Management");
            Console.WriteLine("Enter your Garage Name:");
            string garagename = Console.ReadLine();
            Console.WriteLine("Enter the Capacity of your Garage");
            int capacity = int.Parse(Console.ReadLine());
            Garage<Vehicle> garelu = new Garage<Vehicle>(capacity);
            garelu.GarageName = garagename;
            Console.WriteLine("Garage Details are:");
            Console.WriteLine("======================");
            Console.WriteLine(garelu);
            Console.WriteLine("======================");
            Console.ReadLine();
        }






        public static void ControlVehicle(int id)
        {
            while (true)
            {

                Console.Write("\n****************************************************************\n");
                Console.WriteLine("\n Enter |1|--> To Display the list of all parked vehicles ");
                Console.WriteLine("\n Enter |2|--> To list all vehicle types currently parked in the garage ");
                Console.WriteLine("\n Enter |3|--> Park and Unpark specific vehicles");
                Console.WriteLine("\n Enter |4|--> To check the maximum capacity of the garage");
                Console.WriteLine("\n Enter |5|--> To Exit the Menu");
                Console.Write("\n*****************************************************************\n");
                string uinput = Console.ReadLine();
                string userinput = Console.ReadLine();
                int input = 0;
                if (!int.TryParse(userinput, out input))
                {
                    Console.WriteLine("Please enter valid input, number is expected!");
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine(" To Display the list of all parked vehicles ");
                      //  Garage<Vehicle> garage = new Garage<Vehicle>(20);
                        //    garage.addVehicle(new Vehicle { RegistrationNumber = "123", Color = "Red", Number_Of_Wheels = 4, ModelType = "Version001" });
                        Console.WriteLine("Vehicle added");
                        break;
                    case 2:
                        Console.WriteLine("To list all vehicle types currently parked in the garage");
                        break;
                    case 3:
                        Console.WriteLine("Park and Unpark specific vehicles");
                        return;
                    case 4:
                        Console.WriteLine("To check the maximum capacity of the garage");
                        break;
                    case 5:
                        Console.WriteLine("Good Bye!");
                        return;
                    case 6:
                        Console.WriteLine(" Enter vehicle details ");

                        
                         
                        //   Vehicle vehi = new Vehicle(regnr, color, wheels, model);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }


        }

            //public List<Vehicle> vehicles = new List<Vehicle>();
    //    private List<Employee> list = new List<Employee>();
        //public void AddVehicle(Vehicle vehicles)
        //{
        //    vehicles.Add(vehiccle);



        //}
       
    }

}


