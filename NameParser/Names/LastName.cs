using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class LastName
    {
        public string Name { get; private set; }

        public void GetName()
        {
            Console.WriteLine("Enter your last name.");
            Name = Console.ReadLine();
        }

        public void PrintName()
        {
            var lastNameSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
                lastNameSpaces += letter.ToString().ToUpper() + " ";
            }

            Console.WriteLine(lastNameSpaces.Trim());
        }
    }
}
