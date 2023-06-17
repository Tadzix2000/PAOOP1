using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
    public class VehicleInventory
    {
        public List<Vehicle> Vehicles = new List<Vehicle>();
        public VehicleInventory() { }
        public VehicleInventory(List<Vehicle> Vehicles) {  this.Vehicles = Vehicles; }
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public int CountBusesByStatus(StausEnum.StatusType status) 
        {
            int counter = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.GetStatus() == status && vehicle is Bus) counter++;
            }
            return counter;
        }
        public int CountTramsByStatus(StausEnum.StatusType status) 
        {
            int counter = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.GetStatus() == status && vehicle is Tram) counter++;
            }
            return counter;
        }
        public int CountTrolleybusesByStatus(StausEnum.StatusType status)
        {
            int counter = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.GetStatus() == status && vehicle is Trolleybus) counter++;
            }
            return counter;
        }
    }
}
