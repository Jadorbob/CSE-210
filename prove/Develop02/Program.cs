using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Resume myResume = new Resume();
        myResume._name = "Joe";
        

        Job job1 = new Job();
        job1._title = "Software Developer";
        job1._startDate = "Jan 02 2003";
        job1._endDate = "Jan 03 2003";

        myResume._jobs.Add(job1);
    }
}