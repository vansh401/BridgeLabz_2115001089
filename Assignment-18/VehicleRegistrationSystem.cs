using System;  

class Vehicle  
{  
    public static double RegistrationFee { get; set; }  
    public readonly string RegistrationNumber;  
    public string OwnerName { get; set; }  
    public string VehicleType { get; set; }  

    public Vehicle(string ownerName, string vehicleType, string registrationNumber)  
    {  
        this.OwnerName = ownerName;  
        this.VehicleType = vehicleType;  
        this.RegistrationNumber = registrationNumber;  
    }  

    public static void UpdateRegistrationFee(double newFee)  
    {  
        RegistrationFee = newFee;  
    }  

    public void DisplayDetails()  
    {  
        Console.WriteLine("Vehicle Details:");  
        Console.WriteLine("Owner Name: " + OwnerName);  
        Console.WriteLine("Vehicle Type: " + VehicleType);  
        Console.WriteLine("Registration Number: " + RegistrationNumber);  
        Console.WriteLine("Registration Fee: " + RegistrationFee);  
    }  
}  

class VehicleRegistrationSystem  
{  
    static void Main()  
    {  
        Vehicle.UpdateRegistrationFee(1200);  

        Vehicle vehicle1 = new Vehicle("vansh", "Car", "UP85y4231");  
        Vehicle vehicle2 = new Vehicle("yash", "bike", "UP85y1892");  

        vehicle1.DisplayDetails();  

        Vehicle.UpdateRegistrationFee(1500);  
        vehicle2.DisplayDetails();  
    }  
}  
