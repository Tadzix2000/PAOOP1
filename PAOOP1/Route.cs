using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
   
    public class Route
    {

        private List<Station> _stations = new List<Station>();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        public Route (Station firstStation, Station secondStation, List<Station> otherStations)
        {
            _stations.Add(firstStation);
            _stations.Add(secondStation);
            foreach (var station in otherStations)
            {
                _stations.Add(station);
            }
        }
        public Route(Station firstStation, Station secondStation)
        {
            _stations.Add(firstStation);
            _stations.Add(secondStation);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle.GetStatus() == StausEnum.StatusType.inOperation) _vehicles.Add(vehicle);
        }
    }
}
