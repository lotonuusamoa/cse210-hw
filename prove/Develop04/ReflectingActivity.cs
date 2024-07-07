public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you helped a stranger.",
        "Think of a time you overcame a fear.",
        "Think of a time when you secretly helped an foe.",
        "Think of a time when you did not claim credit for great work you've done.",
    };
    private List<string> _questions = new List<string> {
        "How did this experience make you feel?",
        "Would you do it again if it happens again?",
        "What was in your mind when you did this?",
        "How did you feel the other guy will react?",
        "What made this experience a little different from other similar occassions before?",
        "What can you take away from this experience?",
        "How would you use this experience tp assist in the future?",
        "What do you think you will do differently after this experience?",
        "Would you be a better disciple of Heavenly Father because of this experience?",
    };

    public ReflectingActivity(string name, string description) : base (name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        Console.WriteLine($"---- {PromptGenerator()} ----");
        DisplayQuestion();
        DisplayEnd();
    }
    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string QuestionGenerator()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    private void DisplayQuestion()
    {
        int seconds = GetDuration();
        while (seconds > 0)
        {
            string question = QuestionGenerator();
            Console.WriteLine(question);
            Countdown();
            seconds -= 3;
        }
    }
    
}