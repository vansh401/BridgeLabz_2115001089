using System;
using System.Collections.Generic;

class Student
{
    public string StudentName { get; set; }
    private List<Course> EnrolledCourses { get; set; }

    public Student(string studentName)
    {
        StudentName = studentName;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        EnrolledCourses.Add(course);
        course.AddStudent(this);
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

class Professor
{
    public string ProfessorName { get; set; }
    private List<Course> AssignedCourses { get; set; }

    public Professor(string professorName)
    {
        ProfessorName = professorName;
        AssignedCourses = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        AssignedCourses.Add(course);
        course.AssignProfessor(this);
    }

    public void DisplayCourses()
    {
        Console.WriteLine(ProfessorName + " is assigned to the following courses:");
        foreach (var course in AssignedCourses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}

class Course
{
    public string CourseName { get; set; }
    private List<Student> Students { get; set; }
    private List<Professor> Professors { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        Students = new List<Student>();
        Professors = new List<Professor>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AssignProfessor(Professor professor)
    {
        Professors.Add(professor);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Students enrolled:");
        foreach (var student in Students)
        {
            Console.WriteLine(student.StudentName);
        }
        Console.WriteLine("Professors assigned:");
        foreach (var professor in Professors)
        {
            Console.WriteLine(professor.ProfessorName);
        }
    }
}

class University
{
    public string UniversityName { get; set; }
    private List<Student> Students { get; set; }
    private List<Professor> Professors { get; set; }
    private List<Course> Courses { get; set; }

    public University(string universityName)
    {
        UniversityName = universityName;
        Students = new List<Student>();
        Professors = new List<Professor>();
        Courses = new List<Course>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddProfessor(Professor professor)
    {
        Professors.Add(professor);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("University Name: " + UniversityName);
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            Console.WriteLine(student.StudentName);
        }
        Console.WriteLine("Professors:");
        foreach (var professor in Professors)
        {
            Console.WriteLine(professor.ProfessorName);
        }
        Console.WriteLine("Courses:");
        foreach (var course in Courses)
        {
            course.DisplayDetails();
        }
    }
}

class UniversityManagementSystem
{
    static void Main()
    {
        University university = new University("Tech University");

        Student student1 = new Student("Vansh");
        Student student2 = new Student("Yash");

        Professor professor1 = new Professor("Dr. Ashok");
        Professor professor2 = new Professor("Dr. Mayank");

        Course course1 = new Course("Mathematics");
        Course course2 = new Course("Computer Science");

        university.AddStudent(student1);
        university.AddStudent(student2);
        university.AddProfessor(professor1);
        university.AddProfessor(professor2);
        university.AddCourse(course1);
        university.AddCourse(course2);

        student1.EnrollCourse(course1);
        student1.EnrollCourse(course2);
        student2.EnrollCourse(course2);

        professor1.AssignCourse(course1);
        professor2.AssignCourse(course2);

        university.DisplayDetails();
    }
}
