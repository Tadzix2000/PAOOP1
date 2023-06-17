using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
    public class Bus: Vehicle
    {
        protected int _pollutionIndicator;
        public Bus (int capacity, string licensePlateNumber, DateTime serviceDate, int pollutionIndicator) : base (capacity, licensePlateNumber, serviceDate) 
        {
            _pollutionIndicator = pollutionIndicator;
            fuelType = FuelEnum.FuelType.Gas;
        }
        public override StausEnum.StatusType GetStatus()
        {
            var difference = 12 * (DateTime.Today.Year - _serviceDate.Year) + DateTime.Today.Month - _serviceDate.Month;
            if (difference <= 6 && _pollutionIndicator > 5) return StausEnum.StatusType.inOperation;
            else if (difference <= 12 && _pollutionIndicator >= 3) return StausEnum.StatusType.needRepair;
            return StausEnum.StatusType.forScrap;
        }
    }
}
