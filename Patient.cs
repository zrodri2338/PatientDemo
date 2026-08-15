using System;

public class Patient
{
    private int patientId;
    private string name;
    private int age;
    private double amountDue;

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

    public double AmountDue
    {
        get { return amountDue; }
        set { amountDue = value; }
    }

    public Patient(int patientId, string name, int age, double amountDue)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.amountDue = amountDue;
    }

    public override string ToString()
    {
        return $"Patient ID: {PatientId}\n" +
               $"Name: {Name}\n" +
               $"Age: {Age}\n" +
               $"Amount Due: {AmountDue:C}";
    }
}