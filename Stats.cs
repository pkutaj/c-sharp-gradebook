using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Stats
    {
        public Stats()
        {
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;
            runningSum = 0.0;
            gradesCount = 0;

        }
        public void Add(double gradeParameter)
        {
            runningSum += gradeParameter;
            gradesCount++;
            highGrade = Math.Max(gradeParameter, highGrade);
            lowGrade = Math.Min(gradeParameter, lowGrade);
        }
        public double AverageGrade
        {
            get
            {
                return runningSum / gradesCount;
            }
        }
        public double highGrade;
        public double lowGrade;
        public char letter
        {
            get
            {
                switch (AverageGrade)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double runningSum;
        public int gradesCount;

    }
}