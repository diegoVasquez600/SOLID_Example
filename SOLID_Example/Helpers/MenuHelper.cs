using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example.Helpers
{
    internal class MenuHelper
    {
        internal static void ShowMenu()
        {
            Console.WriteLine("1. Create Person");
            Console.WriteLine("2. List People");
            Console.WriteLine("3. Exit");
        }
    }
}
