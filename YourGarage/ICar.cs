using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal interface ICar : IVehicle
    {
        public bool IsElectric { get; set; }
        public void Driving();

        public void Braking();
    }
}
