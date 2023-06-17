using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
    public class Tram:Vehicle
    {
        public Tram(int capacity, string licensePlateNumber, DateTime serviceDate) : base(capacity, licensePlateNumber, serviceDate)
        {
            fuelType = FuelEnum.FuelType.Electric;
        }
    }
}
