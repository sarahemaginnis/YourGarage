using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Boeing747 : Aircraft
    {
        public bool HasTVs { get; set; }
        public bool CargoPlane { get; set; }

        public bool WesIsPilot { get; set; }

        public Boeing747(int fuelCapacity, string color, int passengerOccupancy, bool cargoPlane, bool wesIsPilot)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            CargoPlane = cargoPlane;
            WesIsPilot = wesIsPilot;
        }
    }
}
