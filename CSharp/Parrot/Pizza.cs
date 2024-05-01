// Strategy interface

using System;

interface ITransportStrategy
{
    void Travel(string destination);
}

// Concrete strategies
class DriveStrategy : ITransportStrategy
{
    public void Travel(string destination) => Console.WriteLine($"Driving to {destination}.");
}

class FlightStrategy : ITransportStrategy
{
    public void Travel(string destination) => Console.WriteLine($"Flying to {destination}.");
}

// Context class
class TripPlanner
{
    private readonly ITransportStrategy _transportStrategy;
    public TripPlanner(ITransportStrategy transportStrategy) {
        _transportStrategy = transportStrategy;
    }

    public void PlanTrip(string destination) => _transportStrategy.Travel(destination);
}

class Program
{
    static void Main(string[] args)
    {
        // Choose a strategy based on the type of trip
        ITransportStrategy strategy = new FlightStrategy();

        // if (args[0] == "long")
        // {
        //     strategy = new FlightStrategy();
        // }
        // else
        // {
        //     strategy = new DriveStrategy();
        // }

        // Context class (TripPlanner) uses the chosen strategy
        var tripPlanner = new TripPlanner(strategy);

        // Plan the trip
        tripPlanner.PlanTrip("New York");
        // OUTPUT
        // 
    }
}