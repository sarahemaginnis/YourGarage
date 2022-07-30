using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Watercraft : IVehicle
    {
        int IVehicle.FuelCapacity { get; set; }
        string IVehicle.Color { get; set; }
        int IVehicle.PassengerOccupancy { get; set; }

        public void Driving()
        {

        }

        void IVehicle.Refueling()
        {

        }
    }
}
