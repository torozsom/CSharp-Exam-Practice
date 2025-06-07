namespace ExamPractice.LanguageBasics;

public delegate void TemperatureHandler(double temp);

public class TemperatureMonitor
{
    private double _currentTemperature;

    public double CurrentTemperature
    {
        get => _currentTemperature;

        set
        {
            if (value is < -10 or > 60)
                throw new Exception("Temperature out of range.");
            _currentTemperature = value;
        }
    }

    public event TemperatureHandler FeverDetected;

    public void Increase(double val)
    {
        CurrentTemperature += val;

        if (CurrentTemperature > 37)
            FeverDetected?.Invoke(CurrentTemperature);
    }
}