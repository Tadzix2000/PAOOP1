using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOOP1
{
    internal class GoalSolver
    {
        private VehicleInventory _inventory;
        private List<Route> _routes = new List<Route>();
        private Display _display;
        public GoalSolver(VehicleInventory inventory, List<Route> routes)
        {
            _inventory = inventory;
            foreach (var route in routes)
            {
                _routes.Add(route);
            }
            _display = new Display();
        }
        public void SolveFirstGoal()
        {
            _display.Print(
                $"Busses:\n" +  $"in operation - {_inventory.CountBusesByStatus(StausEnum.StatusType.inOperation)}\n" +
                $"need repair - {_inventory.CountBusesByStatus(StausEnum.StatusType.needRepair)}\n" +
                $"For scrap - {_inventory.CountBusesByStatus(StausEnum.StatusType.forScrap)}\n" + 
                $"Trams:\n" + $"in operation - {_inventory.CountTramsByStatus(StausEnum.StatusType.inOperation)}\n" +
                $"need repair - {_inventory.CountTramsByStatus(StausEnum.StatusType.needRepair)}\n" +
                $"For scrap - {_inventory.CountTramsByStatus(StausEnum.StatusType.forScrap)}\n" + 
                $"Trolleybuses:\n" + $"in operation - {_inventory.CountTrolleybusesByStatus(StausEnum.StatusType.inOperation)}\n" +
                $"need repair - {_inventory.CountTrolleybusesByStatus(StausEnum.StatusType.needRepair)}\n" +
                $"For scrap - {_inventory.CountTrolleybusesByStatus(StausEnum.StatusType.forScrap)}\n");
        }
    }
}
