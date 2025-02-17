using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Course Information:");
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Is Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Fee: $" + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}

class EducationalCourseHeirarchy
{
    static void Main()
    {
        Course course = new Course("Introduction to Programming", 30);
        OnlineCourse onlineCourse = new OnlineCourse("Advanced C# Programming", 40, "Udemy", true);
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Machine Learning", 50, "Coursera", true, 2500, 10.0);

        course.DisplayInfo();
        Console.WriteLine();
        onlineCourse.DisplayInfo();
        Console.WriteLine();
        paidOnlineCourse.DisplayInfo();
    }
}
