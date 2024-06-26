using System;

public class Program
{
    static void Main(string[] args)
    {   
 
        int userInput = -1;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

    do {
        const string MENU = "Please, select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit";
        Console.WriteLine(MENU);

        userInput = int.Parse(Console.ReadLine());
        switch(userInput) //WRITE
        {
            case 1:
                Entry newEntry = new Entry();

                newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
                newEntry._prompt = prompt.GetPrompt();
                Console.WriteLine($"{newEntry._prompt}");
                newEntry._answer = Console.ReadLine();
                journal._entries.Add(newEntry);
                break;
            
            //DISPLAY
            case 2: 
            journal.DisplayJournal();
            break;
            
            //SAVE
            case 3: 
        
            Console.WriteLine("What is the filename?");
            string file = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(file))
            {
                // Add text to the file 
                foreach (Entry entry in journal._entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} {entry._answer}");
                }     
            };
            break;
        
            // LOAD
            case 4: 
            Console.WriteLine("Enter the name of the file: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                journal._entries.Clear();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    char[] separators = {':','-', '?'};
                    Entry reader = new Entry();
                    string[] parts = line.Split(separators);

                    reader._date = parts[1].Trim();
                    reader._prompt = parts[2].Trim() + "?";
                    reader._answer = parts[3].Trim();
                    journal._entries.Add(reader);
                }
            }

            else
            {
                Console.WriteLine($"I couldn't find the file: {fileName}");
            }
            break;
        }    
        } while (userInput != 5);
    }
}   