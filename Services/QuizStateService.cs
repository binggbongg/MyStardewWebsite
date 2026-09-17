using MyWebsite.Models;

namespace MyWebsite.Services;

public class QuizStateService
{
    public bool HasCompletedQuiz { get; set; } = false;
    public Character? MatchedCharacter { get; set; }
    public event Action? OnStateChange;

    public void CompleteQuiz(Character result)
    {
        HasCompletedQuiz = true;
        MatchedCharacter = result;
        OnStateChange?.Invoke();
    }
}