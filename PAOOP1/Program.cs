// See https://aka.ms/new-console-template for more information
using PAOOP1;

Bus firstBus = new Bus(13, "EW", DateTime.Parse("10.11.2015"), 6);
Bus secondBus = new Bus(132, "EQ", DateTime.Parse("10.11.2022"), 3);
Bus thirdBus = new Bus(84, "EW", DateTime.Parse("03.06.2023"), 1);
Bus fourthBus = new Bus(84, "AE", DateTime.Parse("03.06.2023"), 1);
Tram firstTram = new Tram(230, "134", DateTime.Parse("03.05.2023"));
Tram secondTram = new Tram(230, "184", DateTime.Parse("03.05.2022"));
Tram thirdTram = new Tram(230, "1W4", DateTime.Parse("03.05.2016"));
Trolleybus first = new Trolleybus(230, "A", DateTime.Parse("03.05.2016"));
Trolleybus second = new Trolleybus(230, "B", DateTime.Parse("03.05.2022"));
Trolleybus third = new Trolleybus(230, "C", DateTime.Parse("03.05.2023"));
List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(first);
vehicles.Add(second);
vehicles.Add(third);
vehicles.Add(firstTram);
vehicles.Add(secondTram);
vehicles.Add(thirdTram);
vehicles.Add(firstBus);
vehicles.Add(secondBus);
vehicles.Add(thirdBus);
vehicles.Add(fourthBus);
Route one = new Route(new Station("Kabaty"), new Station("Natolin"));
List<Route> routes= new List<Route>();
routes.Add(one);
GoalSolver goalSolver = new GoalSolver(new VehicleInventory(vehicles), routes);
goalSolver.SolveFirstGoal();


