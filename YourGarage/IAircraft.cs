using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal interface IAircraft : IVehicle
    {
        public void Flying();

        public void Landing();
    }
}
