using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Subject: " + Subject);
    }
}

class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Grade: " + Grade);
    }
}

class Staff : Person
{
    public string Position { get; set; }

    public Staff(string name, int age, string position)
        : base(name, age)
    {
        Position = position;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Position: " + Position);
    }
}

class SchoolSystem
{
    static void Main()
    {
        Person[] people = new Person[]
        {
            new Teacher("Asha", 55, "Hindi"),
            new Student("Arjav", 18, "12th Grade"),
            new Staff("Manoj", 40, "Officer")
        };

        foreach (var person in people)
        {
            person.DisplayRole();
            person.DisplayInfo();
            Console.WriteLine();
        }
    }
}
