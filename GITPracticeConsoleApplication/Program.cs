using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
                // Intimate the users to input their name
                Console.Write("Enter Your Name:");

                // Get user input from the console window
                string strUserLine = Console.ReadLine();

                // Show the result
                Console.Write("You typed " + strUserLine.Length);
                Console.WriteLine(" character(s) excluding newline.");
                new Program().WriteToFile("GITPractice_ConsoleApp-Output.txt",
                                          "User entered:" + strUserLine);
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
            WriteToFile("GITPractice_ConsoleApp-Output.txt", "Number of command line arguments:" + cmdLineArgs.Length);
        }

        // Function to push the command line args or the user's console input
        // into a text file
        private void WriteToFile(string strFilename, string strMessage)
        {
            StreamWriter writer = new StreamWriter(strFilename);
            try
            {
                writer.Write(strMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating/writing to file {0}:{1}",strFilename, ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
