using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements
            int favNumber = 11;

            Console.WriteLine("Try to guess my favorite number 1-20");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput <= 10)
            {
                Console.WriteLine("too low");
            }
            else if(userInput >= 12)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            if (userInput == favNumber)
            {
                Console.WriteLine("My favorite number is " + favNumber);
            }

            // Switch/Case statements
            Console.WriteLine("What is your favorite school subject?");
            string schoolSubject = Console.ReadLine();

            switch (schoolSubject)
            {
                case "Math":
                    Console.WriteLine("You like Math");
                    break;
                case "English":
                    Console.WriteLine("You like English");
                    break;
                case "Science":
                    Console.WriteLine("You like Science");
                    break;
                case "History":
                    Console.WriteLine("You like History");
                    break;
                case "Electives":
                    Console.WriteLine("You like Electives");
                    break;
                default:
                    Console.WriteLine("I guess you dont like school");
                    break;

            }

        }
    }
}
