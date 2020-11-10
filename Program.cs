using System;
 
namespace MemoriesApp
{
    class Program
    {
        static void Main(string[] args)
        //use while loop to invoke menu, will iterate as long as that bool value is true
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        //MainMenu method prints the menu options to the console and waits for users input
            private static bool MainMenu()
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

            Console.WriteLine(titleArt);
            Console.WriteLine("*************************************");
            Console.WriteLine("*  What would you like to do today: *");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("1) Record a Memory");
            Console.WriteLine("2) Record a Quote");
            Console.WriteLine("3) Record a Height");
            Console.WriteLine("4) Make Gibberish"); //something silly as requested by my 4 year old daughter
            Console.WriteLine("5) Calculate Age");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            // replaced previous if else with switch statement
            switch (Console.ReadLine())
            {
                case "1":
                    RecordMemory();
                    return true;
                case "2":
                    RecordQuote();
                    return true;
                case "3":
                    RecordHeight();
                    return true;
                case "4":
                    ReverseSentence();
                    return true;
                // case "5":
                    // CalculateAge();
                    // return true;  
                case "6":
                    return false; // exits the program
                default:
                    return true;
            }
        }
        private static string RecordMemory()
        {
            Console.Write("Enter a new memory of your kiddo: ");
            return Console.ReadLine();
        }
        private static string RecordQuote()
        {
            Console.Write("Enter a new quote for your kiddo: ");
            return Console.ReadLine();
        }
        
         private static string RecordHeight()
        {
            Console.Write("Enter an updated height of your kiddo: ");
            return Console.ReadLine();
        }
          private static string CaptureInput
        {
            get
            {
                Console.Write("Enter the sentence you want to reverse: ");
                return Console.ReadLine();
            }
        }
        private static void ReverseSentence()
        {
            Console.Clear();
            Console.WriteLine("Reverse Sentence");
            char[] charArray = CaptureInput.ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

         private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to MemoriesApp Main Menu");
            Console.ReadLine();
        }
    }
}
        