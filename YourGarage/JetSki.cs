using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class JetSki : Watercraft
    {
        public bool IsBroken { get; set; }
        public int Cylinders { get; set; }

        public JetSki(int fuelCapacity, string color, int passengerOccupancy, bool isBroken,int cylinders)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            IsBroken = isBroken;
            Cylinders = cylinders;
        }
    }
}
