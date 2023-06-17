using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
    public abstract class Vehicle
    {
        protected static int _counter = 0;
        protected DateTime _serviceDate;
        protected int _id;
        public FuelEnum.FuelType fuelType;
        protected string _licensePlateNumber;
        protected int _capacity;
        public Vehicle(int capacity, string licensePlateNumber, DateTime serviceDate) 
        {
            _id = _counter++;
            _capacity = capacity;
            _licensePlateNumber = licensePlateNumber;
            _serviceDate = serviceDate;
        }
        public virtual StausEnum.StatusType GetStatus() 
        {
            var difference = 12 * (DateTime.Today.Year - _serviceDate.Year) + DateTime.Today.Month - _serviceDate.Month;
            if (difference <= 6) return StausEnum.StatusType.inOperation;
            else if (difference <= 36) return StausEnum.StatusType.needRepair;
            return StausEnum.StatusType.forScrap;
        }
    }
}
