using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public Vehicle[] vehicles;

        public int Capacity { get; }
        public int Count { get; private set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
        }

        public bool Add(T vehicle)
        {
            if (Count >= Capacity) return false;

            for (int i = 0; i < Capacity; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    Count++;
                    return true;
                }
            }

            return false;
        }

        public T Remove(T vehicle)
        {
            if (vehicle == null) return null;

            for (int i = 0; i < Capacity; i++)
            {
                if (vehicle.Equals(vehicles[i]))
                {
                    vehicles[i] = null;
                    Count--;
                    return vehicle;
                }
            }
            return null;
        }

        public bool IsFull() => Count == Capacity;

        public string ListAllParkedVehicles()
        {
            var printedList = $"Listing all {Count} parked vehicles {Environment.NewLine}";

            foreach (var vehicle in vehicles.Where(v => v != null))
                printedList += Environment.NewLine + vehicle.ToString() + Environment.NewLine;

            return printedList;
        }

        public string ListVehicleTypes()
        {
            var types = vehicles
                .Where(v => v != null)
                .GroupBy(v => v.GetType().Name)
                .Select(v => new
            {
                    Count = v.Count(),
                    Vehicle = v.Key
                })
                .OrderBy(x => x.Vehicle)
                .OrderByDescending(x => x.Count);

            var printedList = $"{Count} vehicles is stored in the garage {Environment.NewLine}{Environment.NewLine}";

            foreach (var type in types)
            {
                string s = "";
                if (type.Count > 1)
                {
                    if (type.Vehicle == "Bus") s = "es";
                    else s = "s";
                }
                printedList += $"{type.Count} {type.Vehicle}{s} {Environment.NewLine}";
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









            return printedList;
        }

        public Vehicle SearchMatchingVehicle(string registrationNumber)
        {
            var match = vehicles
                .Where(v => v != null)
                .Where(v => v.RegistrationNumber.Equals(registrationNumber.ToUpperInvariant()))
                .FirstOrDefault();

            return match;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles.Where(v => v != null))
                yield return (T)vehicle;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
 }
