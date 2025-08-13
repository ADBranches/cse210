using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling bike = new Cycling(new DateTime(2022, 11, 4), 45, 15.0); 
        Swimming swim = new Swimming(new DateTime(2022, 11, 5), 30, 40); 

        List<Activity> activities = new List<Activity> { run, bike, swim };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
