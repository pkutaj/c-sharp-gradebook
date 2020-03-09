using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name for your Gradebook");
            var bookName = Console.ReadLine();
            IBook book = new DiskBook(bookName);
            Console.WriteLine(book.Name);
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            var stats = book.GetStats();

            Console.WriteLine($"This is for the Book: {book.Name}");
            Console.WriteLine($"The highest grade is {stats.highGrade}");
            Console.WriteLine($"The lowest grade is {stats.lowGrade}");
            Console.WriteLine($"The average grade is {stats.AverageGrade}");
            Console.WriteLine($"The letter grade is {stats.letter}");

        }
        private static void EnterGrades(IBook bookParameter)
        {
            while (true) //while not-done
            {

                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    bookParameter.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Event Fired and Handled: a grade was added ;)");

        }

    }
}