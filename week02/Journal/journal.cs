using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry (Entry anEntry){
        anEntry.Display();
        _entries.Add(anEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry recordedJounal in _entries)
        {
            Console.WriteLine($"Date: {recordedJounal._date} - Prompt: {recordedJounal._promptText}");
            Console.WriteLine(recordedJounal._entryText);
            Console.WriteLine();
            
        }
    }
    public void SaveToFile()
    {
        // Get the desire file name from the user
        Console.WriteLine("What is the filename?");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        // Create a file out of the user desire file name
        FileStream myfile = File.Create($"{fileName}.txt");

        // Write the journal entries to the desire file created
        using (StreamWriter outputFile = new StreamWriter(myfile)) {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                

            }
        }

        
    }
    public void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file?");
        Console.Write("> ");
        string fileName = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(fileName);

        _entries = [];

        foreach (string line in lines)
        {
            string [] parts = line.Split("|");

            Entry loadedFileEntry = new Entry();

            loadedFileEntry._date = parts [0].Trim();
            loadedFileEntry._promptText = parts[1].Trim();
            loadedFileEntry._entryText = parts[2].Trim();

            _entries.Add(loadedFileEntry);
        }

    }
}