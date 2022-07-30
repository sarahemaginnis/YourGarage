using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Car : IVehicle
    {
        int IVehicle.FuelCapacity { get; set; }
        string IVehicle.Color { get; set; }
        int IVehicle.PassengerOccupancy { get; set; }
        public bool IsElectric { get; set; }
        public void Driving()
        {

        }

        public void Braking()
        {

        }
        void IVehicle.Refueling()
        {

        }
    }
}
