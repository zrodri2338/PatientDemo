using System;

/*
Name: Zulisa Rodriguez
Date Completed: August 2026
Program: PatientDemo
Description: This program demonstrates inheritance and
polymorphism using Patient and InsuredPatient objects.
Resources Used: Course materials and class notes.
*/

namespace PatientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient[] patients =
            {
                new Patient(
                    1001,
                    "John Smith",
                    45,
                    2500.00),

                new InsuredPatient(
                    1002,
                    "Maria Lopez",
                    32,
                    5000.00,
                    "Blue Cross",
                    0.80),

                new InsuredPatient(
                    1003,
                    "Robert Johnson",
                    60,
                    3200.00,
                    "Aetna",
                    0.75)
            };

            Console.WriteLine("WRIGHTSTOWN HOSPITAL");
            Console.WriteLine("PATIENT BILLING RECORDS");
            Console.WriteLine("-----------------------");

            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient);
                Console.WriteLine("-----------------------");
            }

            Console.ReadLine();
        }
    }
}