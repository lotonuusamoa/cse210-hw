using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Bro Code", "C# Abstract Classes", 145);
        _videos[0].AddComment("Fraps224", "your explanations are awesome");
        _videos[0].AddComment("leonvieira3877", "Quick and simple, nice refresher/intro to the concept. Thanks");
        _videos[0].AddComment("faycaled3058", "After 2 years of coding I finally understand the purpose of abstract thanks to you");

        _videos[1] = new Video("Caleb Curry", "C# Programming Tutorial 66-Encapsulation", 206);
        _videos[1].AddComment("Juznik1389", "2 minutes to explain this concept instead of these other videos milking every minute");
        _videos[1].AddComment("imadabab", "Excellent Tutorial. I have subscribed long ago.");
        _videos[1].AddComment("christianrodier3381", "That was helpful, thanks");
        
        _videos[2] = new Video("Ervis Trupja", "C#-#Inheritance and Polymorphism", 477);
        _videos[2].AddComment("kainzascovia9344", "Finally, i get to understand what my lecturer was trying to explain.");
        _videos[2].AddComment("DodgeCityClub", "Very good and clear explanation.");
        _videos[2].AddComment("rlangers4537", "I have come across your channel and your way describing topics is so clear and concise...");

        _videos[3] = new Video("Computerix", "C# Polymorphism in 5 minutes!", 307);
        _videos[3].AddComment("nwokoeromosele568", "Simple and straight forward");
        _videos[3].AddComment("bongumusamtetwa", "Made it easy and understandble, Thak you");
        _videos[3].AddComment("israelcarmona7355", "So clear! thank you");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}