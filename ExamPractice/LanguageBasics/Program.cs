namespace ExamPractice.LanguageBasics;

public class Program
{
    public static void Main(string[] args)
    {
        // Kitten example

        var k = new Kitten();
        k.Purr += count => Console.WriteLine($"Purr: {count}");

        k.Stroke();
        k.Stroke();
        k.Stroke();
        k.Feed();
        k.Feed();
        k.Feed();
        k.Feed();

        Console.WriteLine($"Count: {k.Count}");

        // ---------


        // Aggregate example

        var a = new Aggregate();
        a.IsEven += timesCalled => Console.WriteLine($"Even number called {timesCalled} times");

        try
        {
            a.Sum = 5000;
            a.IncludeValue(1000);
            a.IncludeValue(2000);
            a.IncludeValue(3000);
            a.IncludeValue(7000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // ---------


        // NumberStore example

        var ns = new NumberStore();
        ns.ChangedToZero += timesCalled => Console.WriteLine($"Changed to zero called {timesCalled} times");

        ns.Value = 5;
        ns.Value = 0;
        ns.Value = 0;
        ns.Value = 10;
        ns.Value = 0;

        Console.WriteLine($"Last set value: {ns.Value}");

        // ---------


        // Course example

        var course = new Course();
        course.StudentRegistered += (lastStudent, studentCount) =>
            Console.WriteLine($"Last student registered: {lastStudent}, Total students: {studentCount}");

        course.Register("Alice");
        course.Register("Bob");
        course.Register("Charlie");
        course.Register("Diana");

        Console.WriteLine($"Total students registered: {course.StudentCount}");

        // ---------


        // TemperatureMonitor example

        var tm = new TemperatureMonitor();
        tm.FeverDetected += temp => Console.WriteLine($"Fever detected at {temp}°C");
        try
        {
            tm.CurrentTemperature = 33.5;
            tm.Increase(1.0);
            tm.Increase(1.5);
            tm.Increase(2.0);
            tm.Increase(3.0);
            tm.CurrentTemperature = 70.0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // ---------


        // Area example

        var area = new Area();
        area.SuspiciousValueSet += (newValue, oldValue) =>
            Console.WriteLine($"Suspicious value set: {newValue} (was {oldValue}), " +
                              $"so the difference is {newValue - oldValue}");

        try
        {
            area.SquareKm = 5000;
            area.SquareKm = 12000;
            area.SquareKm += 8000;
            area.SquareKm = -100;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // ---------
    }
}