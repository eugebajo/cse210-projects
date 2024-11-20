public class Entry
{
    public string Prompt { get; set; }
    public string Text { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string text)
    {
        Prompt = prompt;
        Text = text;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompts: {Prompt}");
        Console.WriteLine($"Response: {Text}");
        Console.WriteLine();
    }
}