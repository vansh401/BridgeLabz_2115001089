using System;  

class Patient  
{  
    public static string HospitalName { get; set; }  
    public static int TotalPatients = 0;  
    public readonly int PatientId;  
    public string Name { get; set; }  
    public int Age { get; set; }  
    private string Ailment { get; set; }  

    public Patient(int patientId, string name, int age, string ailment)  
    {  
        this.PatientId = patientId;  
        this.Name = name;  
        this.Age = age;  
        this.Ailment = ailment;  
        TotalPatients++;  
    }  

    public static void GetTotalPatients()  
    {  
        Console.WriteLine("The total number of patients are: " + TotalPatients);  
    }  

    public static void DisplayHospitalName()  
    {  
        Console.WriteLine("Hospital Name: " + HospitalName);  
    }  

    public void SetAilment(string ailment)  
    {  
        this.Ailment = ailment;  
    }  

    public string GetAilment()  
    {  
        return this.Ailment;  
    }  

    public void DisplayDetails()  
    {  
        if (this is Patient)  
        {  
            Console.WriteLine("Patient Details:");  
            Console.WriteLine("Patient Name: " + Name);  
            Console.WriteLine("Patient ID: " + PatientId);  
            Console.WriteLine("Patient Age: " + Age);  
            Console.WriteLine("Ailment: " + Ailment);  
        }  
        else  
        {  
            Console.WriteLine("Invalid Input");  
        }  
    }  
}  

class HospitalManagementSystem  
{  
    static void Main()  
    {  
        Patient.HospitalName = "Clinic";  
        Patient.DisplayHospitalName();  

        Patient patient1 = new Patient(232, "shivam", 21, "Viral Fever");  
        Patient patient2 = new Patient(531, "pankaj", 24, "Elbow Fracture");  

        patient1.DisplayDetails();  
        Patient.DisplayHospitalName();  
        patient2.DisplayDetails();  
        Patient.GetTotalPatients();  
    }  
}  
