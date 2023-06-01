using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment multiply = new Assignment("Samuel Bennett", "Multiplication");
        multiply.GetSummary();
        
        MathAssignment math1 = new MathAssignment("Robert Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        math1.GetHomeworkList();

        WritingAssignment english1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        english1.GetWritingInformation();
    }
}