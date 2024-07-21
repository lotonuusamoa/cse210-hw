using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("6306 Iliili Drive", "Tutuila Is", "American Samoa", "96799", "United States");
        addresses[1] = new Address("1685 Busy St", "South Side Ave", "CA", "96162", "Unoted States");
        addresses[2] = new Address("1007 Rathgar Rd", "South Island", "Auckland", "2023", "New Zealand");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("C# bootcamp","Level up in C Sharp with friends","06/22/2024","10:00am",addresses[0],"Jayden","43 People");
        events[1] = new ReceptionEvent("Ian Milford's Graduation","Lets celebrate together as Ian's friends","05/25/2024","09:00am",addresses[1],"IanMilford@gmail.com");
        events[2] = new OutdoorGatheringEvent("Touch Rugby cardio","Have fun playing a softer version of this warriors game!","06/13/2024","09:00am",addresses[2],"Sunny");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N°: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}