﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{



   public class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private int count;
        public string GarageName { get; set; }
        private int capacity;
        public int Count { get; set; }

        public int Capacity { get; set; }

        public Garage(int maxCapacity)
        {
            Capacity=maxCapacity;
        }

        public List<Vehicle> vechiclelist = new List<Vehicle>();

        
        public void Add(Vehicle vehicle)
        {
            vechiclelist.Add(vehicle);
        }

        public void List()
        {
            foreach (var vehicle in vechiclelist)
            {

                Console.WriteLine(vehicle);
            }

        }

        public override string ToString()
        {
            return "GarageName: " + GarageName + ", Capacity: " + Capacity;
        }

        public void Listof(T input)
        {
            if (count < capacity)
            {

            }
        }













        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }






        //public override string ToString()
        //{
        //    var output = "";

        //    foreach (var vehicle in vechiclelist)
        //    {
        //        output += vehicle + "\n";

        //    }
        //    return output;

        //}

        //    private static int parkingNumber = 0;


        //    public Garage(int maxCapacity)
        //    {
        //        this.Id = parkingNumber++;
        //        this.Name = name;
        //        this.Vehicle = new List<T>();
        //        this.Capacity = maxCapacity;
        //    }


        //public override string ToString()
        //{
        //    //return string.Format("{1, 30} {2, 3}", Id, Name, Vehicles.Count);
        //    return string.Format(Name, Vehicle.Count, Capacity);
        //}
    }
}
