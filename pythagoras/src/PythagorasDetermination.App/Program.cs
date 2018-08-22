using PythagorasDetermination.Lib.Validator;
using System;
using PythagorasDetermination.Lib.Service;

namespace PythagorasDetermination.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            ITriangleValidator validator = new TriangleValidator();
            ITriangleDeterminator service = new TriangleDeterminatorService(validator);

            Console.WriteLine("Guess the triangle");
            Console.WriteLine("==================");

            Console.Write("Enter length of Side 1 :");
            a = GetInt();

            Console.Write("Enter length of Side 2 :");
            b = GetInt();

            Console.Write("Enter length of Side 3 :");
            c = GetInt();

            Console.WriteLine();

            if (!validator.IsValid(a, b, c))
            {
                Console.WriteLine("Sorry, this is not a valid triangle.");
            }
            else
            {
                Console.WriteLine($"Your triangle is a {service.Determine(a, b, c)} triangle.");
            }

            Console.WriteLine("Press a key to exit.");
            Console.ReadKey();

        }

        public static int GetInt()
        {
            string input;
            int i;

            do
            {
                input = Console.ReadLine();
            } while (int.TryParse(input, out i) == false);

            return i;
        }
    }
}
