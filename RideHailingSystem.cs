using System;
using System.Collections.Generic;

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    protected Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public virtual void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate per Km: $" + ratePerKm);
    }
}

class Car : Vehicle, IGPS
{
    public Car(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return "Current location of the car.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Car location updated to: " + newLocation);
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Car");
    }
}

class Bike : Vehicle, IGPS
{
    public Bike(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return "Current location of the bike.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Bike location updated to: " + newLocation);
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Bike");
    }
}

class Auto : Vehicle, IGPS
{
    public Auto(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return "Current location of the auto.";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine("Auto location updated to: " + newLocation);
    }

    public override void GetVehicleDetails()
    {
        base.GetVehicleDetails();
        Console.WriteLine("Vehicle Type: Auto");
    }
}

class RideHailingSystem
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(001, "Vansh", 10),
            new Bike(002, "Yash", 5),
            new Auto(003, "Himanshu", 7)
        };

        double distance = 15.0; 

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for " + distance + " km: " + vehicle.CalculateFare(distance));

            IGPS gpsVehicle = vehicle as IGPS;
            if (gpsVehicle != null)
            {
                Console.WriteLine(gpsVehicle.GetCurrentLocation());
                gpsVehicle.UpdateLocation("New Location");
            }
            
            Console.WriteLine();
        }
    }
}
