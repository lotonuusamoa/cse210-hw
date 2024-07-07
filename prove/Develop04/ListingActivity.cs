public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Name one thing tht you apprecited the most today",
        "What is one thing you did today to support your health goals",
        "What have you done as a service project this week?",
        "Did you feel helped by your faith today?",
        "Who are your role models",
    };

    private List<string> _listed = new List<string>();

    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        DisplayPrompt();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int seconds = GetDuration();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                _listed.Add(userInput);
            }
        }
        DisplayListNumber();
        DisplayEnd();
    }

    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(PromptGenerator());
    }

    private void DisplayListNumber()
    {
        Console.WriteLine($"You listed {_listed.Count} items.");
        Thread.Sleep(3000);
    }
}