using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            var firstName = Console.ReadLine();

            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            var middleName = "";

            if (hasMiddleName == "y")
            {
                Console.WriteLine("Enter your middle name.");
                middleName = Console.ReadLine();
                var i = 0;

                foreach (var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($"{firstName} you are 1/3 less of a person then.");
            }

            Console.WriteLine("Enter your last name.");
            var lastName = Console.ReadLine();
            var lastNameSpaces = "";

            foreach (var letter in lastName)
            {
                lastNameSpaces += letter.ToString().ToUpper() + " ";
            }

            Console.WriteLine(lastNameSpaces.Trim());

            Console.WriteLine($"You have a dumb name {firstName} {middleName} {lastName}. Have a good day(press enter to exit).");
            Console.ReadLine();
        }
    }
}
