using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    private List<Student> EnrolledStudents = new List<Student>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Students enrolled in " + CourseName + ":");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine(student.StudentName);
        }
    }
}

class Student
{
    public string StudentName;
    private List<Course> EnrolledCourses = new List<Course>();

    public Student(string studentName)
    {
        StudentName = studentName;
    }

    public void EnrollInCourse(Course course)
    {
        EnrolledCourses.Add(course);
        course.EnrollStudent(this);
    }

    public void DisplayCourses()
    {
        Console.WriteLine(StudentName + " is enrolled in the following courses:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}

class School
{
    public string SchoolName;
    private List<Student> Students = new List<Student>();

    public School(string schoolName)
    {
        SchoolName = schoolName;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Students in " + SchoolName + ":");
        foreach (var student in Students)
        {
            Console.WriteLine(student.StudentName);
        }
    }
}

class SchoolManagementSystem
{
    static void Main()
    {
        School school = new School("kmps");
        Student student1 = new Student("vansh");
        Student student2 = new Student("appar");
        Course course1 = new Course("commerce");
        Course course2 = new Course("Science");
        school.AddStudent(student1);
        school.AddStudent(student2);
        student1.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);
        student2.EnrollInCourse(course2);
        school.DisplayStudents();
        student1.DisplayCourses();
        student2.DisplayCourses();
        course1.DisplayStudents();
        course2.DisplayStudents();
    }
}
