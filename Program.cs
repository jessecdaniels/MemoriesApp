using System;
using System.Collections.Generic;

namespace MemoriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // journal instance
            Journal journal = new Journal();
            char choice = '0';
            // main loop
            while (choice != '5')
            {
                journal.PrintHomeScreen();
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("*  What would you like to do today: *");
                Console.WriteLine("*************************************");
                Console.WriteLine("");
                Console.WriteLine("1) - Add a memory");
                Console.WriteLine("2) - Search for memories");
                Console.WriteLine("3) - Delete memories");
                Console.WriteLine("4) - Make some gibberish"); //something silly as requested by my 4 year old daughter, also counts number of characters in string and returns that information
                Console.WriteLine("5) - End");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reaction to the users choice
                switch (choice)
                {
                    case '1':
                        journal.AddMemory();
                        break;
                    case '2':
                        journal.SearchMemories();
                        Console.ReadKey();
                        break;
                    case '3':
                        journal.DeleteMemories();
                        break;
                    case '4':
                        journal.ReverseSentence();
                        break;
                    case '5':
                        Console.WriteLine("Press any key to quit the Memories App...");
                        break;
                    default:
                        Console.WriteLine("That is not a menu option. Please press any key to choose another action.");
                        break;  
                }
            }
        }
    }
}
