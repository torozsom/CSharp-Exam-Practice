namespace ExamPractice.LanguageBasics;

public delegate void PurrHandler(int count);

public class Kitten
{
    public int Count { get; set; }
    public event PurrHandler Purr;


    public void Stroke()
    {
        Count += 3;

        if (Count > 12)
            Purr?.Invoke(Count);
    }

    public void Feed()
    {
        Count += 4;

        if (Count > 12)
            Purr?.Invoke(Count);
    }
}