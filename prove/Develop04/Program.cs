using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        bool runProgram = true;
        while (runProgram)
        {
            string MENU = "\nMenu options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Activity Log\n5. Quit";
            Console.WriteLine(MENU);
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput) 
            {
                case 1: //BREATHING ACTIVITY
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by controlling the rate you inhale and exhale. Listen to yourself breathing and apprecite what it does for you.");
                    breathing.StartActivity();
                    breathingLog += 1;
                    break;
                
                case 2: //REFLECTING ACTIVITY
                    ReflectingActivity reflecting = new ReflectingActivity("Reflection Exercise", "This activity will help you be present. Focus on you and the things you are most blessed with. Knowing your strengths and joy can open your minds eyes to more opportunities.");
                    reflecting.StartActivity();
                    reflectingLog += 1;
                    break;
                
                case 3: //LISTING ACTIVITY
                    ListingActivity listing = new ListingActivity("Listing Exercise", "This activity will help you identify the blessings youve enjoyed so far in life, the blessings that is ripe for the taking and the things to do to level up.");
                    listing.StartActivity();
                    listingLog += 1;
                    break;
                
                case 4: //ACTIVITY LOG
                    Console.WriteLine("Activity - Number of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breathingLog} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingLog} times");
                    Console.WriteLine($"Listing Activity: {listingLog} times");
                    break;

                case 5: //QUIT
                    Console.WriteLine("Thanks for using this app! :)");
                    runProgram = false;
                    break;
                
            }
        }
        
    }
    
}