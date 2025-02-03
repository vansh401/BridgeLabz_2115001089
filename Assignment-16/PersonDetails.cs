using System;

class Person{
    public string name;
    public int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    public Person(Person other){
        this.name = other.name;
        this.age = other.age;
    }

    public void DisplayDetails(){
        Console.WriteLine("Person Name: " + name);
        Console.WriteLine("Person Age: " + age);
    }
}

class PersonDetails{
    public static void Main(string[] args){
        Person person1 = new Person("Vansh Verma", 22);
        Person person2 = new Person(person1);

        Console.WriteLine("Original Person:");
        person1.DisplayDetails();

        Console.WriteLine("\nCopied Person:");
        person2.DisplayDetails();
    }
}
