using System.Reflection;

class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;
    public MathAssignment( string textbookSection, string problems) : base(studentName, topic)
    {
        this.studentName = studentName;
        this.topic = topic;
        this.textbookSection = textbookSection;
        this.problems = problems;
    }
    public string GetHomeworkList()
    {
        return ($"Section {textbookSection}, problems {problems}");
    }
}