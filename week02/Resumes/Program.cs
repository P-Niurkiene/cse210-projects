using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();

        Job1._jobTitle = "Data Analyst";
        Job1._company = "KPMG";
        Job1._startYear = 2022;
        Job1._endYear = 2025;
        Job1._description = "storing, sorting, and deeply analyzing company data to provide accurate and useful information to improve company performance.";

        Console.WriteLine($"{Job1._jobTitle} at {Job1._company}, for {Job1._endYear - Job1._startYear} years.");
        Console.WriteLine($"Starting in the year {Job1._startYear}, and ending in the year {Job1._endYear}. ");
        Console.WriteLine($"In my role I was responsable for, {Job1._description}");

        Job Job2 = new Job();

        Job2._jobTitle = "Payment Processing Specialist";
        Job2._company = "Concur Limited";
        Job2._startYear = 2020;
        Job2._endYear = 2022;
        Job2._description = "accurately processing physical and digital invoices in multiple foreign currencies within a 24-hour period.";

        Console.WriteLine($"{Job2._jobTitle} at {Job2._company}, for {Job2._endYear - Job2._startYear} years.");
        Console.WriteLine($"Starting in the year {Job2._startYear}, and ending in the year {Job2._endYear}. ");
        Console.WriteLine($"In my role I was responsable for, {Job2._description}");
    }
}