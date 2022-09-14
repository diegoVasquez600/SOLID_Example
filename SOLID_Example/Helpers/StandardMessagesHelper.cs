using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Example.Helpers
{
    internal class StandardMessagesHelper
    {
        internal static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the SOLID Example");
        }
        internal static void EndApplication()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        internal static void GoodbyeMessage()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
