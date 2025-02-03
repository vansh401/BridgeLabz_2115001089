using System;

class CarRental {
    public string customerName;
    public string carModel;
    public int rentalDays;
    public double dailyRate;

    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate) {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.dailyRate = dailyRate;
    }

    public double CalculateTotalCost() {
        return rentalDays * dailyRate;
    }

    public void DisplayDetails() {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Daily Rate: " + dailyRate);
        Console.WriteLine("Total Cost: " + CalculateTotalCost());
    }
}

class CarRentalSystem {
    public static void Main(string[] args) {
        CarRental customRental = new CarRental("Vansh Verma", "innova", 5, 3500);

        Console.WriteLine("Custom Rental:");
        customRental.DisplayDetails();
    }
}
