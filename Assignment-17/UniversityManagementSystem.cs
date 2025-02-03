using System;

class Student {
    public int rollNumber;
    protected string name;
    private double CGPA;

    public Student(int rollNumber, string name, double CGPA) {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    public void SetCGPA(double CGPA) {
        if (CGPA >= 0.0 && CGPA <= 10.0) {
            this.CGPA = CGPA;
        } else {
            Console.WriteLine("Invalid CGPA value");
        }
    }

    public double GetCGPA() {
        return CGPA;
    }

    public void DisplayStudentDetails() {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + CGPA);
    }
}

class PostgraduateStudent : Student {
    public string specializationTopic;

    public PostgraduateStudent(int rollNumber, string name, double CGPA, string specializationTopic) 
        : base(rollNumber, name, CGPA) {
        this.specializationTopic = specializationTopic;
    }

    public void DisplayPostgraduateDetails() {
        Console.WriteLine("specialization Topic: " + specializationTopic);
    }
}

class UniversityManagementSystem {
    public static void Main(string[] args) {
        Student student1 = new Student(1089, "vansh verma", 8.5);
        student1.DisplayStudentDetails();
        student1.SetCGPA(9.0); 
		
        Console.WriteLine("Updated CGPA: " + student1.GetCGPA());
        

        PostgraduateStudent student2 = new PostgraduateStudent(1145, "yash", 9.2, "Machine Learning");
        student2.DisplayStudentDetails();
        student2.DisplayPostgraduateDetails();
    }
}
