using System;

class Vehicle {
    public string ownerName;
    public string vehicleType;
    public static double registrationFee = 100;

    public Vehicle(string ownerName, string vehicleType) {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails() {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    public static void UpdateRegistrationFee(double newFee) {
        registrationFee = newFee;
        Console.WriteLine("Registration Fee updated to: " + registrationFee);
    }
}

class VehicleRegistrationSystem {
    public static void Main(string[] args) {
        Vehicle vehicle1 = new Vehicle("vansh verma", "Car");
        Vehicle vehicle2 = new Vehicle("Yash", "bike");

        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();
        Console.WriteLine();

        Vehicle.UpdateRegistrationFee(540);

        Console.WriteLine("\nUpdated Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Updated Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();
    }
}
