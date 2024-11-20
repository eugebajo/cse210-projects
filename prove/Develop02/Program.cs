using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Daily Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show the journal");
            Console.WriteLine("3. Leave");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string message = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {message}");
                Console.Write("Response: ");
                string response = Console.ReadLine();

                journal.AddEntry(message, response);
            }
            else if (option == "2")
            {
                journal.DisplayEntries();
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
            }
            else if (option == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Option not valid. Please try again.");
            }
        }
    }
}