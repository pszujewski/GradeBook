using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public string Name = "Grade book";
        private List<float> grades = new List<float>();
        private GradeStatistics stats;

        public GradeBook()
        {
            stats = new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            stats.SetStatistics(grades);
            return stats;
        }
    }
}
