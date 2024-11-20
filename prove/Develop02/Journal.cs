using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the diary.");
        }
        else
        {
            foreach (var entry in entries)
            {
                entry.DisplayEntry();
            }
        }
    }
}