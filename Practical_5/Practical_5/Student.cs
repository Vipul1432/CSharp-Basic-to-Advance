
namespace Practical_5
{
    internal class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        public static decimal AverageMarks;
        public decimal CalculateAverageMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                AverageMarks += Marks[i];
            }
            return AverageMarks;
        }
        public string CalculateGrade(decimal marks) =>
            marks switch
            {
                > 90 => "A",
                > 80 => "B",
                > 70 => "C",
                < 70 => "D",
                _ => "Invalid Data",
            };
    }
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
}
