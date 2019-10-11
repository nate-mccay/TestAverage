using System;

namespace TestAverage
{
    class Program
    {
        static int GetUserResponse(string question)
        {
            int integerFromUser;
            bool success = false;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);
            return integerFromUser;
        }
        static void Main(string[] args)
        {
            var scoreFirst = GetUserResponse("What is your first test score?");
            var scoreSecond = GetUserResponse("What is your second test score?");
            var scoreThird = GetUserResponse("What is your third test score?");
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
