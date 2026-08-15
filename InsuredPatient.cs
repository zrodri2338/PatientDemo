using System;

public class InsuredPatient : Patient
{
    private string insuranceCompany;
    private double insurancePercentage;

    public string InsuranceCompany
    {
        get { return insuranceCompany; }
        set { insuranceCompany = value; }
    }

    public double InsurancePercentage
    {
        get { return insurancePercentage; }
        set { insurancePercentage = value; }
    }

    public InsuredPatient(
        int patientId,
        string name,
        int age,
        double amountDue,
        string insuranceCompany,
        double insurancePercentage)
        : base(patientId, name, age, amountDue)
    {
        this.insuranceCompany = insuranceCompany;
        this.insurancePercentage = insurancePercentage;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" +
               $"Insurance Company: {InsuranceCompany}\n" +
               $"Insurance Percentage Paid: {InsurancePercentage:P0}";
    }
}