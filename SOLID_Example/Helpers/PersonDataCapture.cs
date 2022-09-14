using SOLID_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example.Helpers
{
    internal class PersonDataCapture
    {
        internal static Person Create()
        {
            Person output = new();

            Console.Write("Enter first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            output.LastName = Console.ReadLine();

            Console.Write("Enter age: ");
            output.Age = int.Parse(Console.ReadLine());

            return output;
        }
    }
}
