using System;

class Circle{
    public double radius;

    public Circle() : this(1.0) { }

    public Circle(double radius){
        this.radius = radius;
    }

    public void DisplayDetails(){
        Console.WriteLine("Circle radius: " + radius);
    }
}

class CircleDetails{
    public static void Main(string[] args){
        Circle defaultCircle = new Circle();
        Circle customCircle = new Circle(5.5);

        Console.WriteLine("Default Circle:");
        defaultCircle.DisplayDetails();

        Console.WriteLine("user provided Circle:");
        customCircle.DisplayDetails();
    }
}
