using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);

            book.AddGrade(76);
            book.AddGrade(12);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine($"Max grade is {stats.maxGrade}\n");
            Console.WriteLine($"Min grade is {stats.minGrade}\n");
            Console.WriteLine($"Average grade is {stats.avgGrade}\n"); 
        }
    }
}
