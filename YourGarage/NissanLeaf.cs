using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class NissanLeaf : Car
    {
        public bool PushToStart { get; set; }

        public NissanLeaf(int fuelCapacity, string color, int passengerOccupancy, bool pushToStart)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            PushToStart = pushToStart;
        }
    }
}
