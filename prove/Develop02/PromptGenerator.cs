public class PromptGenerator {
    
    List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
        "On a scale of 1 to 10, how do you rate your day today?",
        "What made today fun?",
        "WHats one important task I completed today?",
        "What were you most grateful for today?",
        "Whats one thing to do now to make tomorrow better?"
        };
    }

    public string GetPrompt()
        {
            Random rndm = new Random();
            int index = rndm.Next(0, _prompts.Count());
            return _prompts[index];
        }

    }