using System;
using System.Collections.Generic;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private int vehicleNumber;
    private string type;
    private double rentalRate;
    
    public int VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }
    
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    
    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }
    
    protected Vehicle(int vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }
    
    public abstract double CalculateRentalCost(int days);
    
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Rate: " + rentalRate);
    }
}

class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;
    
    public Car(int vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }
    
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
    
    public double CalculateInsurance()
    {
        return 50000;
    }
    
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }
    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Car");
    }
}

class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;
    
    public Bike(int vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }
    
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
    
    public double CalculateInsurance()
    {
        return 2000;
    }
    
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }
    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Bike");
    }
}

class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;
    
    public Truck(int vehicleNumber, string type, double rentalRate, string insurancePolicyNumber)
        : base(vehicleNumber, type, rentalRate)
    {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }
    
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
    
    public double CalculateInsurance()
    {
        return 4000;
    }
    
    public string GetInsuranceDetails()
    {
        return "Insurance Policy Number: " + insurancePolicyNumber;
    }
    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Truck");
    }
}

class VehicleRentalSystem
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(101, "Sedan", 50, "Car1"),
            new Bike(102, "Sports", 20, "Bike1"),
            new Truck(103, "6Wheel", 100, "Truck1")
        };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("Rental Cost for 5 days: $" + vehicle.CalculateRentalCost(5));

            IInsurable insurableVehicle = vehicle as IInsurable;
            if (insurableVehicle != null)
            {
                Console.WriteLine("Insurance Cost: $" + insurableVehicle.CalculateInsurance());
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
            }

            Console.WriteLine();
        }
    }
}

