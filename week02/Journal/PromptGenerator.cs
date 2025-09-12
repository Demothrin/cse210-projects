public class PromptGenerator
{
    public List<string> _prompts = new List<string>{"What physical sensations am I experiencing with my anxiety right now? Where do I feel them?",
    "What triggers my anxiety most frequently? What patterns do I notice",
    "What anxious thoughts keep recurring? How can I challenge their validity?",
    "What would I do today if anxiety wasn't holding me back?" };
    public Random _random = new Random();

    public PromptGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];
    }
}