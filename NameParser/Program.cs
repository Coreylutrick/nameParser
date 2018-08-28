using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            firstName.GetName();
            firstName.PrintName();

            var middleName = new MiddleName();
            middleName.GetName(firstName.Name);
            middleName.PrintName();

            var lastName = new LastName();
            lastName.GetName();
            lastName.PrintName();

            Console.WriteLine($"You have a dumb name {firstName.Name} {middleName.Name} {lastName.Name}. Have a good day(press enter to exit).");
            Console.ReadLine();
        }
    }
}
