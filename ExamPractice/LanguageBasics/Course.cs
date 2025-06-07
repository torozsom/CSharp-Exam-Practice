namespace ExamPractice.LanguageBasics;

public delegate void CourseHandler(string lastStudent, int studentCount);

public class Course
{
    public List<string> Students { get; set; } = new();
    public int StudentCount { get; set; }
    public event CourseHandler StudentRegistered;

    public void Register(string student)
    {
        Students.Add(student);
        StudentCount++;
        StudentRegistered?.Invoke(student, StudentCount);
    }
}