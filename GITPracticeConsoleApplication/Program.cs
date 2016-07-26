using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GITPracticeConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                new Program().PrintCommandLine(args);
            }
            else
            {
                Console.WriteLine("Hello World");

                // Intimate the users to input their name
                Console.Write("Enter Your Name: ");

                // Get user input from the console window
                string strUserLine = Console.ReadLine();

                // Show the result
                Console.Write("You typed ");
                Console.Write(strUserLine.Length);
                Console.WriteLine(" character(s)");
            }
        }

        // Function to print the arguments passed in command line
        private void PrintCommandLine(string[] cmdLineArgs)
        {
            Console.WriteLine("Following were the {0} commands that were sent as arguments:", cmdLineArgs.Length);

            // Loop through to read each argument passed
            foreach (string strCmd in cmdLineArgs)
            {
                // Print the argument to the console
                Console.WriteLine(strCmd);
            }
        }
    }
}
