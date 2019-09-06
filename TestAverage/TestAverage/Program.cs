using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestAverage;
            Console.WriteLine("What is your first test score?");
            var First = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second test score?");
            var Second = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your third test score?");
            var Third = int.Parse(Console.ReadLine());
            var TestAddition = First + Second + Third;
            var answerAverage = TestAddition / 3;
            Console.WriteLine("Your test average is " + answerAverage);
        }
    }
}
