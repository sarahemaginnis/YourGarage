using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Boeing747 : IAircraft
    {
        public bool HasTVs { get; set; }
        public bool CargoPlane { get; set; }

        public bool WesIsPilot { get; set; }
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public Boeing747(int fuelCapacity, string color, int passengerOccupancy, bool cargoPlane, bool wesIsPilot)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            CargoPlane = cargoPlane;
            WesIsPilot = wesIsPilot;
        }
        public void Flying()
        {
            Console.WriteLine("Yay! You're flying!");
        }

        public void Refueling()
        {

        }

        public void Landing()
        {
        }
    }
}
