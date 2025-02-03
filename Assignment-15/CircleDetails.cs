using System;

class Circle{
    public double radius;

    public Circle(double radius){
        this.radius = radius;
    }

    public double CalculateArea(){
        return Math.PI * radius * radius;
    }

    public double CalculateCircumference(){
        return 2 * Math.PI * radius;
    }

    public void DisplayResult(){
        Console.WriteLine("Circle area is: " + CalculateArea());
        Console.WriteLine("Circle circumference is: " + CalculateCircumference());
    }
}

class CircleDetails{
    public static void Main(string[] args){
        Circle circle1 = new Circle(5.0); 
        circle1.DisplayResult();
    }
}
