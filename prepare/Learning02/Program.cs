using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._name = "Caleb Leonard";

        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Electron Inc.";
        job1._startYear = 1012;
        job1._endYear = 3012;

        Job job2 = new Job();
        job2._company = "Leonard Engineering";
        job2._jobTitle = "CEO";
        job2._startYear = 2002;
        job2._endYear = 3002;

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
        Console.WriteLine();
    }
}