using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class JetSki : IWatercraft
    {
        public bool IsBroken { get; set; }
        public int Cylinders { get; set; }
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public JetSki(int fuelCapacity, string color, int passengerOccupancy, bool isBroken,int cylinders)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            IsBroken = isBroken;
            Cylinders = cylinders;
        }

        void IVehicle.Refueling()
        {
        }

        void IWatercraft.Driving()
        {
        }
    }
}
