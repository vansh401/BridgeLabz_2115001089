using System;

class HotelBooking{
    public string guestName;
    public string roomType;
    public int nights;

    public HotelBooking() : this("vansh verma", "deluxe", 1) { }

    public HotelBooking(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking other){
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void DisplayDetails(){
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Number of Nights: " + nights);
    }
}

class BookingDetails{
    public static void Main(string[] args){
        HotelBooking defaultBooking = new HotelBooking();
        HotelBooking customBooking = new HotelBooking("Vansh Verma", "Deluxe", 3);
        HotelBooking copiedBooking = new HotelBooking(customBooking);

        Console.WriteLine("Default Booking:");
        defaultBooking.DisplayDetails();

        Console.WriteLine("\nCustom Booking:");
        customBooking.DisplayDetails();

        Console.WriteLine("\nCopied Booking:");
        copiedBooking.DisplayDetails();
    }
}
