using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class NissanLeaf : ICar
    {
        public bool PushToStart { get; set; }
        public bool IsElectric { get; set; }
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public NissanLeaf(int fuelCapacity, string color, int passengerOccupancy, bool pushToStart)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            PushToStart = pushToStart;
        }

        public void Refueling()
        {

        }

        public void Driving()
        {
        }

        public void Braking()
        {
        }
    }
}
