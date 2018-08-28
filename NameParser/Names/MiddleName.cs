using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName
    {
        public string Name { get; private set; } = "";

        bool UserHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void GetName( string firstName)
        {
            if (UserHasMiddleName())
            {
                Console.WriteLine("Enter your middle name.");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{firstName} you are 1/3 less of a person then.");
            }
        }

        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
