namespace Lab_13.Models;

public class QuizResult
{
    private readonly List<Quiz> _quizzes = [];

    public Quiz this[Index index] => _quizzes[index];

    public int Count => _quizzes.Count;

    public void Clear() => _quizzes.Clear();

    public ICollection<Quiz> RightAnswers => _quizzes.FindAll(quiz => quiz.IsRight);

    public void Add(Quiz quiz) => _quizzes.Add(quiz);
}