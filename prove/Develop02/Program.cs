using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Leave");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                
                    Console.WriteLine("What do you want to answer today?");
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");

                    Console.Write("Your answer: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry(prompt, response);
                    theJournal.AddEntry(newEntry);
                    break;

                case "2":

                    theJournal.ShowEntries();
                    break;

                case "3":
                    
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;

                case "4":
                    
                    Console.Write("Enter the file name to upload: ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    
                    Console.WriteLine("See you later!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}