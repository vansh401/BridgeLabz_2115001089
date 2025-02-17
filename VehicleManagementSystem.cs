using System;

interface IRefuelable
{
    void Refuel();
}

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle Model: " + Model);
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
    }
}

class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Charge()
    {
        Console.WriteLine("Charging the electric vehicle.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Electric Vehicle");
    }
}

class PetrolVehicle : Vehicle, IRefuelable
{
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Refuel()
    {
        Console.WriteLine("Refueling the petrol vehicle.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Petrol Vehicle");
    }
}

class VehicleManagementSystem
{
    static void Main()
    {
        Vehicle electricCar = new ElectricVehicle(150, "Tesla S");
        PetrolVehicle petrolCar = new PetrolVehicle(180, "Toyota Supra");

        electricCar.DisplayInfo();
        Console.WriteLine();

        petrolCar.DisplayInfo();
        petrolCar.Refuel();
    }
}
