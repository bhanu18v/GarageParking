using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public struct VehicleProperties
    {
        public string RegistrationNumber;
        public string Color;
        public int WheelCount;

        public VehicleProperties(string registrationNumber, string color,
                                 int wheelCount)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            WheelCount = wheelCount;

        }  
    }
    class Program
    {
        public static Garage<Vehicle> garage = new Garage<Vehicle>(0);

        public static void Main(string[] args)
        {
            var exit = false;
            do
            {
                exit = MainMenu();
            } while (exit != true);
        }

        public  static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("---- GARAGE - MAIN MENU ----");
            Console.WriteLine(
                "1. Create a new Garage "
                + "\n2. Park a vehicle in the garage"
                + "\n3. Unpark a parked vehicle"
                + "\n4. List the vehicles parked in the garage"
                + "\n0. Exit this garage\n");
            int input = 0;
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                string userinput = Console.ReadLine();

                if (!int.TryParse(userinput, out input))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                }
                else break;
            }
            Console.Clear();

            var exit = false;
            switch (input)
            {
                case 1:
                    OpenGarage();
                    break;
                case 2:
                    ParkVehicleMenu();
                    break;
                case 3:
                    UnparkVehicle();
                    break;
               case 4:
                    ListVehiclesMenu();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
            return exit;
        }

        public static void OpenGarage()
        {
            Console.WriteLine("---- CREATE NEW GARAGE ----");

            int capacity = 0;
            while (true)
            {
                Console.WriteLine("Enter the number of parking slots:");
                string userinput = Console.ReadLine();
                if (!int.TryParse(userinput, out capacity))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                }
                else break;
            }
            garage = new Garage<Vehicle>(capacity);
        }

        public static void ParkVehicleMenu()
        {
            Console.WriteLine("---- PARK VEHICLE INTO GARAGE ----");
            ShowGarageSlotInfo();

            if (!garage.IsFull())
            {

                Console.WriteLine(
                    "1. Park an Airplane"
                    + "\n2. Park a Motorcycle"
                    + "\n3. Park a Car"
                    + "\n4. Park a Bus"
                    + "\n5. Park a Boat"
                    + "\n0. Return to main menu\n");
                int input;
                while (true)
                {
                    Console.WriteLine("Enter your choice:");
                    string userinput = Console.ReadLine();


                    if (!int.TryParse(userinput, out input))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else break;
                }

                Console.Clear();

                switch (input)
                {
                    case 1:
                        ParkAirplane();
                        break;
                    case 2:
                        ParkMotorcycle();
                        break;
                    case 3:
                        ParkCar();
                        break;
                    case 4:
                        ParkBus();
                        break;
                    case 5:
                        ParkBoat();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Not a valid choice");
                        break;
                }
            }
        }

        public static void ShowGarageSlotInfo()
        {
            if (garage.Capacity > 0)
            {
                var availableSlots = garage.Capacity - garage.Count;
                Console.WriteLine($"{availableSlots}/{garage.Capacity} parking slots available");
                {
                    if (availableSlots == 0)
                        Console.WriteLine("The garage is full. Come back later or unpark a vehicle");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Garage is empty,Please create a new Garage!");
                Console.ReadLine();
            }

        }

        public static VehicleProperties VehicleProperties()
        {
            Console.WriteLine("Enter registration Number: ");
            string registrationNumber = Console.ReadLine();

            Console.WriteLine("Enter Color: ");
            string color = Console.ReadLine();
            int wheelCount;
            while (true)
            {
                Console.WriteLine("Enter the number of wheels: ");
                string userinput = Console.ReadLine();


                if (!int.TryParse(userinput, out wheelCount))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }

            var properties = new VehicleProperties(registrationNumber,
                                                   color, wheelCount);
            return properties;
        }

        public static void ParkAirplane()
        {
            Console.WriteLine("---- PARK AIRPLANE ----");
            var properties = VehicleProperties();
            int engineCount;
            while (true)
            {
                Console.WriteLine("Enter the number of engines: ");
                string userinput = Console.ReadLine();


                if (!int.TryParse(userinput, out engineCount))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }

            if (engineCount < 0)
                engineCount = 0;

            var airplane = new Airplane(properties.RegistrationNumber,
                                        properties.Color,
                                        properties.WheelCount,
                                        engineCount);
            garage.Add(airplane);
        }

        public static void ParkMotorcycle()
        {
            Console.WriteLine("---- PARK MOTORCYCLE ----");
            var properties = VehicleProperties();
            float engineCC;
            while (true)
            {
                Console.WriteLine("Enter the engine cylinder volume (cc): ");
                string userinput = Console.ReadLine();


                if (!float.TryParse(userinput, out engineCC))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }

            var motorcycle = new Motorcycle(properties.RegistrationNumber,
                                          properties.Color, properties.WheelCount, engineCC);
            garage.Add(motorcycle);
        }

        private static void ParkCar()
        {
            Console.WriteLine("---- PARK CAR ----");
            var properties = VehicleProperties();

            Console.WriteLine("Enter Fuel Type: ");
            string fuelType = Console.ReadLine();

            var car = new Car(properties.RegistrationNumber,
                                         properties.Color, properties.WheelCount,
                                         fuelType);
            garage.Add(car);
        }

        public static void ParkBus()
        {
            Console.WriteLine("---- PARK BUS ----");

            var properties = VehicleProperties();
            int seats;
            while (true)
            {
                Console.WriteLine("Enter the number of seats: ");
                string userinput = Console.ReadLine();


                if (!int.TryParse(userinput, out seats))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }
            var bus = new Bus(properties.RegistrationNumber, properties.Color, properties.WheelCount, seats);
            garage.Add(bus);
        }

        public static void ParkBoat()
        {
            Console.WriteLine("-- PARK BOAT --" + Environment.NewLine);

            var properties = VehicleProperties();
            float length;
            while (true)
            {
                Console.WriteLine("Enter the length in feet:  ");
                string userinput = Console.ReadLine();


                if (!float.TryParse(userinput, out length))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }
            var boat = new Boat(properties.RegistrationNumber, properties.Color, properties.WheelCount,
                                length);
            garage.Add(boat);
        }

        public static void UnparkVehicle()
        {
            Console.WriteLine("---- UNPARK VEHICLE |----" + Environment.NewLine);

            if (garage.Count > 0)
            {

                Console.WriteLine("Enter registration Number: ");
                string registrationNumber = Console.ReadLine();

                var result = garage.SearchMatchingVehicle(registrationNumber);

                if (result != null)
                {
                    if (garage.Remove(result) != null)
                        Console.WriteLine($"Successfully unparked vehicle{Environment.NewLine}{Environment.NewLine}{result}");

                }
                else
                    Console.WriteLine("No matching vehicle found in garage.");
            }
            else
                Console.WriteLine("The garage is empty.");

            Console.ReadLine();
        }

        public  static void ListVehiclesMenu()
        {
            Console.WriteLine("---- LIST VEHICLES ----");

            Console.WriteLine("1. List all vehicles parked in the garage"
                + "\n2. List all different vehicle types and their quantity"
                + "\n0. Return to main menu\n");
            int input;
            while (true)
            {
                Console.WriteLine("Your choice: ");
                string userinput = Console.ReadLine();

                if (!int.TryParse(userinput, out input))
                {
                    Console.WriteLine("Invalid input!");
                }
                else break;
            }
            Console.Clear();

            switch (input)
            {
                case 1:
                  ListAllParkedVechicles();
                    break;
                case 2:
                    ListAllParkedVechicles(groupByType: true);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    Console.ReadLine();
                    break;
            }
        }
            public static void ListAllParkedVechicles(bool groupByType = false)
            {
                if (garage.Count > 0)
                {
                    if (groupByType)
                        Console.WriteLine(garage.ListVehicleTypes());
                    else
                        Console.WriteLine(garage.ListAllParkedVehicles());
                }
                else
                    Console.WriteLine("The garage is empty");
                Console.ReadLine();
            }
    }
}
