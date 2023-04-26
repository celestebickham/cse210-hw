using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Simplot";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Walmart";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Celeste Bickham";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}