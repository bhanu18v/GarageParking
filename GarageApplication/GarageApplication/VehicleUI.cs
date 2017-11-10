using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class VehicleUI
    {
        public void ControlVehicles()
        {
            while (true)
            {
                int id;
                Console.Write("\n****************************************************************\n");
                Console.WriteLine("\n Enter |1|--> To Create Garage with list of vehicles");
                Console.WriteLine("\n Enter |2|--> To list all vehicle types currently parked in the garage ");
                Console.WriteLine("\n Enter |3|--> Park and Unpark specific vehicles");
                Console.WriteLine("\n Enter |4|--> To check the maximum capacity of the garage");
                Console.WriteLine("\n Enter |0|--> To Exit the Menu");
                Console.Write("\n*****************************************************************\n");
                string uinput = Console.ReadLine();
                int userinput;
                //int input = 0;
                if (!int.TryParse(uinput, out userinput))
                {
                    Console.WriteLine("Please enter valid input, number is expected!");
                }

                switch (userinput)
                {
                    case 1:
                        Console.WriteLine(" \n ******* Displaying the list of all parked vehicles in the Garage with Garage details *******");
                        Console.WriteLine("\n Vehicle added");
                        AddVehicle();

                        break;
                    case 2:
                        Console.WriteLine("\n  ******* listing all vehicle types currently parked in the garage *******");
                        break;
                    case 3:
                        Console.WriteLine("\n  *******Park and Unpark specific vehicles *******");
                        ParkorUnPark();
                        break;
                    case 4:
                        Console.WriteLine("\n ******* Maximum capacity of the garage *******");
                        Maxcapacityofgarage();
                        break;
                    case 0:
                        Console.WriteLine("\n  ******* !Bye Bye! *******");
                        return;
                   
                     default:
                        Console.WriteLine("\n Invalid Input!");
                        break;
                }
            }
        }


        public void AddVehicle()
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
            Garage<Vehicle> garageex = new Garage<Vehicle>(capacity);

            //var added = true;
            //do
            //{
            //    added = AddVehicle(garageex);
            //}
            //while (added);
            Console.WriteLine("==============");
            garageex.List();
            Garage<Vehicle> garageexm;
            garageexm = new Garage<Vehicle>(12);
            Console.WriteLine("Enter your registration number");
            string registrationNumber = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(registrationNumber)) 
            Console.WriteLine("Enter your vehicle color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter number of wheels of your vehicle");
            int no_Of_Wheels = int.Parse(Console.ReadLine());
            Console.WriteLine("Model Type of your vehicle");
            string modelType = Console.ReadLine();

            Vehicle vehicle = new Vehicle(registrationNumber, color, no_Of_Wheels, modelType);

            garageexm.Add(vehicle);

        }
    
                public void Maxcapacityofgarage()
        {
            Console.WriteLine("Welcome! ,Enter maximum capacity of the Garage");

            int maxcapacity = int.Parse(Console.ReadLine());
            Garage<Vehicle> garageex;
            garageex = new Garage<Vehicle>(maxcapacity);
            //var added = true;
            //do
            //{
            //    added = AddVehicle();
            //}
            //while (added);
            Console.WriteLine("==============");
            garageex.List();
            // Console.WriteLine(garage);
            Console.ReadLine();

        }


        public void ParkorUnPark()
        {

            while (true)
            {
                Console.WriteLine("*****Welcome to Park/UnPark a car*****");
                Console.WriteLine("\n To Park a vehicle Enter |1|..\n To Unpark a vehicle Enter |2|..\n To Exit Enter |0|");

                char input = ' '; 
                try
                {
                    input = Console.ReadLine()[0]; 
                }
                catch (IndexOutOfRangeException) 
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '1':
                        Console.WriteLine("For Parking the Vehicles \n");
                        Console.WriteLine("1:To Enter Aeroplane \n");
                        Console.WriteLine("2:To Enter Motorcycle \n");
                        Console.WriteLine("3:To Enter Car \n");
                        Console.WriteLine("4:To Enter Bus \n");
                        Console.WriteLine("5:To Enter Boat \n");
                        Console.WriteLine("0:To go back to Main Menu \n");
                        string userinput = Console.ReadLine();
                        switch (userinput)
                        {
                            case "1":


                                Console.WriteLine("You are adding Aeroplane..\n");
                                Airplane airplane = new Airplane();

                                Console.WriteLine("Enter the Registration Number of the Aeroplane \n");
                                var airRegnum = Console.ReadLine();
                                airplane.RegistrationNumber = airRegnum;

                                Console.WriteLine("Enter color of the Airplane \n");
                                var airColor = Console.ReadLine();
                                airplane.Color = airColor;

                                Console.WriteLine("Enter Number of Wheels for the Airplane \n");
                                var airWheels = int.Parse(Console.ReadLine());
                                airplane.No_Of_Wheels = airWheels;

                                Console.WriteLine("Enter Type of the Model \n");
                                var airModel = Console.ReadLine();
                                airplane.ModelType = airModel;


                                Console.WriteLine("Number of Engines for Airplane \n");
                                var airEngines = int.Parse(Console.ReadLine());
                                airplane.NoOfEngines = airEngines;
                                break;




                            case "2":

                                Console.WriteLine("You are adding Motorcycle..\n");
                                Motorcycle motorcycle = new Motorcycle();

                                Console.WriteLine("Enter the Registration Number of the MotorCycle \n");
                                var regmotorcycle = Console.ReadLine();
                                motorcycle.RegistrationNumber = regmotorcycle;

                                Console.WriteLine("Enter color of the MotorCycle \n");
                                var colmotorcycle = Console.ReadLine();
                                motorcycle.Color = colmotorcycle;

                                Console.WriteLine("Enter Number of Wheels for the MotorCycle \n");
                                var motorwheels = int.Parse(Console.ReadLine());
                                motorcycle.No_Of_Wheels = motorwheels;

                                Console.WriteLine("Enter Type of the Model for MotorCycle \n");
                                var motormodel = Console.ReadLine();
                                motorcycle.ModelType = motormodel;

                                Console.WriteLine("Enter Cylinder Volume of MotorCycle \n");
                                var motorCylinderVolume = int.Parse(Console.ReadLine());
                                motorcycle.Cylindervol = motorCylinderVolume;

                                break;

                            case "3":
                                Console.WriteLine("You are adding car..\n");
                                Car car = new Car();

                                Console.WriteLine("Enter the Registration Number of the Car \n");
                                var regCar = Console.ReadLine();
                                car.RegistrationNumber = regCar;

                                Console.WriteLine("Enter color of the Car \n");
                                var carCol = Console.ReadLine();
                                car.Color = carCol;

                                Console.WriteLine("Enter Number of Wheels for the Car \n");
                                var carwheels = int.Parse(Console.ReadLine());
                                car.No_Of_Wheels = carwheels;

                                Console.WriteLine("Enter Type of the Car \n");
                                var typecar = Console.ReadLine();
                                car.ModelType = typecar;

                                Console.WriteLine("Enter Fuel Type of the Car \n");
                                var fueltypecar = Console.ReadLine();
                                car.Fuel_Type = fueltypecar;

                                break;

                            case "4":
                                Console.WriteLine("You are adding Bus..\n");
                                Bus bus = new Bus();

                                Console.WriteLine("Enter the Registration Number of the Bus \n");
                                var regBus = Console.ReadLine();
                                bus.RegistrationNumber = regBus;

                                Console.WriteLine("Enter color of the Bus \n");
                                var busCol = Console.ReadLine();
                                bus.Color = busCol;

                                Console.WriteLine("Enter Number of Wheels for the Bus \n");
                                var buswheels = int.Parse(Console.ReadLine());
                                bus.No_Of_Wheels = buswheels;

                                Console.WriteLine("Enter Type of the Bus \n");
                                var typebus = Console.ReadLine();
                                bus.ModelType = typebus;

                                Console.WriteLine("Enter Number of Seats in the  Bus \n");
                                var noofSeatsbus = int.Parse(Console.ReadLine());
                                bus.No_Of_Seats = noofSeatsbus;
                                break;

                            case "5":
                                Console.WriteLine("You are adding Boat..\n");
                               Boat boat = new Boat();

                                Console.WriteLine("Enter the Registration Number of the Boat \n");
                                var regBoat = Console.ReadLine();
                                boat.RegistrationNumber = regBoat;

                                Console.WriteLine("Enter color of the Boat  \n");
                                var boatCol = Console.ReadLine();
                                boat.Color = boatCol;

                                Console.WriteLine("Enter Number of Wheels for the Boat  \n");
                                var boatwheels = int.Parse(Console.ReadLine());
                                boat.No_Of_Wheels = boatwheels;

                                Console.WriteLine("Enter Type of the Boat  \n");
                                var typeboat= Console.ReadLine();
                                boat.ModelType = typeboat;

                                Console.WriteLine("Enter Length of the Boat \n");
                                var lenboat = int.Parse(Console.ReadLine());
                                boat.Length = lenboat;

                                break;


                            case "0": return;

                        }
                        break;

                    case '2': Console.WriteLine("To Unpark vehicles");
                        break;


                    case '0': return;

                            default:
                                Console.WriteLine("\n Please enter some valid input (+,-,0)");
                                break;

                }
                }

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




