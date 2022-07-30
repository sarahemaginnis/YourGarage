using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal interface IVehicle
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }
        public void Refueling();
    }
}
