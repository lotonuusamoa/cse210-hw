using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("25 June 2024",5.7,30));
        activities.Add(new CyclingActivity("25 May 2024",7.6,30));
        activities.Add(new Swimming("23 April 2024",36,30));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}