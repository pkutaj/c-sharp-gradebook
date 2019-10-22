using System;
using System.Collections.Generic;

namespace GradeBook

{
    class Book
    {
        public Book() // SAME NAME && NO RETURN TPE
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades;
    }
}