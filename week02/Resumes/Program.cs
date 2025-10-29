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
        Job1._description = "Storing, sorting, and deeply analyzing company data to provide accurate and useful information to improve company performance.";
        Job1.displayJob();

        Job Job2 = new Job();

        Job2._jobTitle = "Payment Processing Specialist";
        Job2._company = "Concur Limited";
        Job2._startYear = 2020;
        Job2._endYear = 2022;
        Job2._description = "Accurately processing physical and digital invoices in multiple foreign currencies within a 24-hour period.";

        Resume Resume1 = new Resume();
        Resume1._name = "Sally Goodall";
        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);
        Resume1._jobs[0]._jobTitle

    }
}