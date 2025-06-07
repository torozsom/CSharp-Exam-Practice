namespace ExamPractice.LanguageBasics;

public delegate void EvenNumberHanlder(int timesCalled);

public class Aggregate
{
    private int _includeValueCalled;
    private int _sum;

    public int Sum
    {
        set
        {
            if (value > 6000)
                throw new Exception("Sum cannot exceed 6000.");

            _sum = value;
        }
    }

    public event EvenNumberHanlder IsEven;


    public void IncludeValue(int val)
    {
        _includeValueCalled++;
        _sum += val;

        if (_sum % 2 == 0)
            IsEven?.Invoke(_includeValueCalled);
    }
}