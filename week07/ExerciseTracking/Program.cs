using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        RunningActivity a1 = new RunningActivity("30 Nov 2025", 28, 15);
        activityList.Add(a1);

        CyclingActivity a2 = new CyclingActivity("02 Dec 2025", 60, 28);
        activityList.Add(a2);

        SwimmingActivity a3 = new SwimmingActivity("05 Dec 2025", 45, 12);
        activityList.Add(a3);

        foreach (Activity a in activityList)
        {
            Console.WriteLine($"{a.GetSummary()}");
        }
    }
}