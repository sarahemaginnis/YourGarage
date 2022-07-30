using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Aircraft : IVehicle
    {
        int IVehicle.FuelCapacity { get; set; }
        string IVehicle.Color { get; set; }
        int IVehicle.PassengerOccupancy { get; set; }
        public void Flying()
        {
            Console.WriteLine("Yay! You're flying!");
        }

        public void Landing()
        {

        }
        void IVehicle.Refueling()
        {

        }
    }
}
