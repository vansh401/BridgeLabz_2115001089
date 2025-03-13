using System;
using System.Collections.Generic;

interface IMedicalRecord
{
    void AddRecord(string record);
    string ViewRecords();
}

abstract class Patient
{
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;
    private List<string> medicalHistory;

    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    protected string Diagnosis
    {
        get { return diagnosis; }
        set { diagnosis = value; }
    }
    protected List<string> MedicalHistory
    {
        get { return medicalHistory; }
        set { medicalHistory = value; }
    }

    protected Patient(int patientId, string name, int age, string diagnosis)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.diagnosis = diagnosis;
        this.medicalHistory = new List<string>();
    }

    public abstract double CalculateBill();
    public abstract void AddMedicalRecord(string record);
    public abstract string ViewMedicalRecords();

    public virtual void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Diagnosis: " + diagnosis);
    }
}

class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyRate;

    public int DaysAdmitted
    {
        get { return daysAdmitted; }
        set { daysAdmitted = value; }
    }
    public double DailyRate
    {
        get { return dailyRate; }
        set { dailyRate = value; }
    }

    public InPatient(int patientId, string name, int age, string diagnosis, int daysAdmitted, double dailyRate)
        : base(patientId, name, age, diagnosis)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyRate = dailyRate;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyRate;
    }

    public void AddRecord(string record)
    {
        MedicalHistory.Add(record);
    }

    public string ViewRecords()
    {
        return string.Join(", ", MedicalHistory);
    }

    public override void AddMedicalRecord(string record)
    {
        AddRecord(record);
    }

    public override string ViewMedicalRecords()
    {
        return ViewRecords();
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine("Days Admitted: " + daysAdmitted);
        Console.WriteLine("Daily Rate: $" + dailyRate);
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public double ConsultationFee
    {
        get { return consultationFee; }
        set { consultationFee = value; }
    }

    public OutPatient(int patientId, string name, int age, string diagnosis, double consultationFee)
        : base(patientId, name, age, diagnosis)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        MedicalHistory.Add(record);
    }

    public string ViewRecords()
    {
        return string.Join(", ", MedicalHistory);
    }

    public override void AddMedicalRecord(string record)
    {
        AddRecord(record);
    }

    public override string ViewMedicalRecords()
    {
        return ViewRecords();
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine("Consultation Fee: $" + consultationFee);
    }
}

class HospitalPatientSystem
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(1, "Kapil Kumar", 35, "pneumonia", 5, 1500),
            new OutPatient(2, "Manoj Sharma", 30, "Flu", 200)
        };

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine("Bill: $" + patient.CalculateBill());

            patient.AddMedicalRecord("Initial diagnosis recorded.");
            Console.WriteLine("Medical Records: " + patient.ViewMedicalRecords());

            Console.WriteLine();
        }
    }
}
