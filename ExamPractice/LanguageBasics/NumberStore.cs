namespace ExamPractice.LanguageBasics;

public delegate void ChangedToZeroHandler(int timesCalled);

public class NumberStore
{
    private int _val;

    private int _zeroCount;

    public int Value
    {
        get => _val;

        set
        {
            var previousValue = _val;
            _val = value;

            if (_val == 0)
            {
                _zeroCount++;
                if (previousValue != 0)
                    ChangedToZero?.Invoke(_zeroCount);
            }
        }
    }

    public event ChangedToZeroHandler ChangedToZero;
}