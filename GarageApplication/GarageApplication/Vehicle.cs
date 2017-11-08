using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Vehicle
    {

        private int registration_number;
        public int Registration_Number
        {
            get { return registration_number; }
            set { Registration_Number = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int no_Of_Wheels;
        public int No_Of_Wheels
        {
            get { return no_Of_Wheels; }
            set { no_Of_Wheels = value; }
        }

        private string type_Of_Model;
       

        public string Type_Of_Model
        {
            get { return type_Of_Model; }
            set { type_Of_Model = value; }

        }

        public Vehicle()
        { }

        public Vehicle(int registration_number, string color, int no_Of_Wheels, string type_Of_Model)
        {
            Registration_Number = registration_number;
            Color = color;
            No_Of_Wheels = no_Of_Wheels;
            Type_Of_Model = type_Of_Model;


        }



        public virtual string PrintVehicle()
        {
            return "\n Register Number of the" + GetType().Name + "is--" + Registration_Number + "\n The color of this vehicle is--" + Color +
                   "\n And Its a" + No_Of_Wheels + " vehicle.." + "\n Its a " +Type_Of_Model + "model";
        }











    }
}





    }
}
