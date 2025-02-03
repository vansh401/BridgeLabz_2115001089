using System;

class Course {
    public string courseName;
    public int duration;
    public double fee;
    public static string instituteName = "Amity University";

    public Course(string courseName, int duration, double fee) {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails() {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute Name: " + instituteName);
    }

    public static void UpdateInstituteName(string newInstituteName) {
        instituteName = newInstituteName;
        Console.WriteLine("Institute Name updated to: " + instituteName);
    }
}

class CourseManagementSystem {
    public static void Main(string[] args) {
        Course course1 = new Course("java full stack", 12, 1000);
        Course course2 = new Course("Dot net ", 8, 8000);

        Console.WriteLine("Course 1 Details:");
        course1.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Course 2 Details:");
        course2.DisplayCourseDetails();
        Console.WriteLine();

        Course.UpdateInstituteName("GLA University");

        Console.WriteLine("\nUpdated Course 1 Details:");
        course1.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("Updated Course 2 Details:");
        course2.DisplayCourseDetails();
    }
}
