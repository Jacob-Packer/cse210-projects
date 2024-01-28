using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Resume Builder World!");
        
        Job job1 = new Job("Del Taco",  "Manager",  1798,  1800);
        
        /*
        job1._company = "Del Taco";
        job1._jobTitle = "Manager";
        job1._startYear = 1798;
        job1._endYear = 1800;
        */
        job1.Display();

        Job job2 = new Job( "Google",  "Executive",  1805,  1950);
        /*
        job2._company = "Google";
        job2._jobTitle = "Executive";
        job2._startYear = 1805;
        job2._endYear = 1950;
        */
        job2.Display();

        Resume r = new Resume();
        r._jobs.Add(job1);
        r._jobs.Add(job2);

        r.Display();
    }
}