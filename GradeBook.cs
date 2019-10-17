using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 10.3, 6.11 };
            var result = 0.0;

            foreach (var number in numbers)
            {
                result += number;
            };

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello Stop!!!");
            }
            MyLoop(15, 45, x => ++x);
            //MyLoop(60, 10, x => --x);
        }

        static void MyLoop(int start, int finish, Func<int, int> op)
        {
            for (var i = start; i < finish; i = op(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
