namespace ExamPractice.LanguageBasics;

public delegate void AreaHandler(double a1, double a2);

public class Area
{
    private double _squareKm;

    public double SquareKm
    {
        get => _squareKm;

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Square kilometers cannot be negative.");

            if (value > 10000)
                SuspiciousValueSet?.Invoke(value, _squareKm);

            _squareKm = value;
        }
    }

    public event AreaHandler SuspiciousValueSet;
}