using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = "Hello World";
            Console.WriteLine(message);
            Console.WriteLine("Press Enter to close...");
            Console.WriteLine("Or perhaps a change is in order... What do you think? Yes or No?");
            string response = Console.ReadLine();
            if (response == "Yes")
                {
                Console.WriteLine("A change has been made.");
            }
            else if (response == "No")
            {
                Console.WriteLine("You were wise.");
            }
            else
            {
                Console.WriteLine("Foolish child");
            }
            Console.ReadLine();

        }
    }
}
