class Program
{
    static void Main(string[] args)
    {
        string MENU = " 1. John 3:16-17 \n 2. Proverbs 3:6 \n 3. Mathew 7:24-26 \n Please, choose a scripture to memorize: ";
        Console.WriteLine(MENU);
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                string text = "For God so loved the world that he gave* his only Son, so that everyone who believes in him might not perish but might have eternal life. 17 For God did not send his Son into the world to condemn the world, but that the world might be saved through him.";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("John 3", 16, 17);
                UserInterface(scripture1,reference1);
                break;

             case 2:
                text = "Trust in the LORD with all your heart and lean not on your own understanding; 6 in all your ways acknowledge him, and he will make your paths straight.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("Proverbs", 3, 6);

                UserInterface(scripture2,reference2);
                break;

            case 3:
                text = "Therefore whosoever heareth these sayings of mine, and doeth them, I will liken him unto a wise man, which built his house upon a rock: 25 And the rain descended, and the floods came, and the winds blew, and beat upon that house; and it fell not: for it was founded upon a rock. 26 And every one that heareth these sayings of mine, and doeth them not, shall be likened unto a foolish man, which built his house upon the sand";
                Scripture scripture3 = new Scripture(text);
                Reference reference3 = new Reference("Mathew", 7, 24, 26);

                UserInterface(scripture3,reference3);
                break;
        }
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}