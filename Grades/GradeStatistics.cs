using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeStatistics
    {
        public float maxGrade;
        public float minGrade;
        public float avgGrade;

        public GradeStatistics()
        {
            maxGrade = float.MinValue;
            minGrade = float.MaxValue;
            avgGrade = 0;
        }

        public void SetStatistics(List<float> grades)
        {
            float sum = 0;

            foreach(float grade in grades)
            {
                sum += grade;
                minGrade = Math.Min(minGrade, grade);
                maxGrade = Math.Max(maxGrade, grade);
            }

            avgGrade = sum / grades.Count;
        }
    }
}
