using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriesApp
{ 
    // Represents journal layer for communication with user
        class Journal
    {
        // Database instance
        private Database database;

        // Initializes instance
             public Journal()
        {
            database = new Database();
        }
        
        // Asks user to enter date and time and returns this value. Keep asking user until you get valid entry.
        private DateTime ReadDateTime()
        {
            Console.WriteLine("Enter date and time of memory as e.g. [01/01/2020 11:00 am or pm], the time is optional:");
            DateTime dateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
                Console.WriteLine("Error. Please enter just the date and/or time: ");
            return dateTime;
        }

        // Prints all memories occurring on given day
        public void PrintMemories(DateTime day)
        {
            List<Memory> memories = database.FindMemories(day, false);
            foreach (Memory memory in memories)
                Console.WriteLine(memory);
        }

        // Asks user for new memory and adds it into database

        public void AddMemory()
        {
            DateTime dateTime = ReadDateTime();
            Console.WriteLine("Enter your memory:");
            string text = Console.ReadLine();
            database.AddMemory(dateTime, text);
        }

        // Lets user search for memories on date entered
        public void SearchMemories()
        {
            // Entering date by user
            DateTime dateTime = ReadDateTime();
            // Searching for memories
            List<Memory> memories = database.FindMemories(dateTime, false);
            // Printing memories
            if (memories.Count() > 0)
            {
                Console.WriteLine("Found memories: ");
                foreach (Memory memory in memories)
                    Console.WriteLine(memory);
            }
            else
                // if no memory is found on that date
                Console.WriteLine("No memories were found for this date.");
        }

        // Lets user delete memories on day they enter
        public void DeleteMemories()
        {
            Console.WriteLine("Entries with exact date and time will be deleted");
            DateTime dateTime = ReadDateTime();
            database.DeleteMemories(dateTime);
        }

        private string GetCaptureInput()
        {
            Console.Write("Enter the sentence you want to reverse: ");
            return Console.ReadLine();
        }
        public void ReverseSentence()
        {
            // Console.Clear();
            Console.WriteLine("Reverse Sentence");
            char[] charArray = GetCaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

         public static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified silly sentence is: {message}");
            string str = message;
            Console.WriteLine("Also, your silly sentence '{0}' is {1} characters long!", str, str.Length);
            Console.Write("\r\nPress Enter to return to the Memories App Main Menu");
            Console.ReadLine();
        }

        // Prints application home screen

        public void PrintHomeScreen()
        {
            Console.Clear();
            string titleArt = @"

 .----------------. .----------------. .----------------. .----------------. .----------------. .----------------. .----------------. .----------------. 
| .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. | .--------------. |
| | ____    ____ | | |  _________   | | | ____    ____ | | |     ____     | | |  _______     | | |     _____    | | |  _________   | | |    _______   | |
| ||_   \  /   _|| | | |_   ___  |  | | ||_   \  /   _|| | |   .'    `.   | | | |_   __ \    | | |    |_   _|   | | | |_   ___  |  | | |   /  ___  |  | |
| |  |   \/   |  | | |   | |_  \_|  | | |  |   \/   |  | | |  /  .--.  \  | | |   | |__) |   | | |      | |     | | |   | |_  \_|  | | |  |  (__ \_|  | |
| |  | |\  /| |  | | |   |  _|  _   | | |  | |\  /| |  | | |  | |    | |  | | |   |  __ /    | | |      | |     | | |   |  _|  _   | | |   '.___`-.   | |
| | _| |_\/_| |_ | | |  _| |___/ |  | | | _| |_\/_| |_ | | |  \  `--'  /  | | |  _| |  \ \_  | | |     _| |_    | | |  _| |___/ |  | | |  |`\____) |  | |
| ||_____||_____|| | | |_________|  | | ||_____||_____|| | |   `.____.'   | | | |____| |___| | | |    |_____|   | | | |_________|  | | |  |_______.'  | |
| |              | | |              | | |              | | |              | | |              | | |              | | |              | | |              | |
| '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' | '--------------' |
 '----------------' '----------------' '----------------' '----------------' '----------------' '----------------' '----------------' '----------------' 

 ";
            // Set the Foreground color to Dark Yellow for title only 
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.WriteLine(titleArt);
            Console.WriteLine("** WELCOME TO THE MEMORIES APP **");
            // Set the Foreground color back to White
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine();
            Console.WriteLine("Current Date & Time: {0}", DateTime.Now);
            Console.WriteLine();
            // prints the homescreen
            Console.WriteLine();
            Console.WriteLine("Today's Memories:\n-----------------");
            PrintMemories(DateTime.Today);
            Console.WriteLine();
            Console.WriteLine("ONE YEAR AGO:\n-------------");
            PrintMemories(DateTime.Now.AddYears(-1));
            Console.WriteLine();
        }
    }
}

