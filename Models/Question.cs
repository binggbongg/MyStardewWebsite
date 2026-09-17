namespace MyWebsite.Models;

public class QuizOption
{
    public string Text { get; set; } = string.Empty;
    
    // Key: Character Name (e.g. "Abigail", "Sebastian")
    // Value: Points awarded (typically 1 to 3 points)
    public Dictionary<string, int> CharacterWeights { get; set; } = new();
}

public class Question
{
    public int Id { get; set; }
    public string QuestionItem { get; set; } = string.Empty;
    public List<QuizOption> Options { get; set; } = new();
}