public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _currentEntry = "";
    public string _fileName = "";
    public Journal()
    {
    }
    public void Save()
    {
        Console.Write("What is the File name? ");
        _fileName = Console.ReadLine();
        using (StreamWriter output = new StreamWriter(_fileName))
        {
            output.WriteLine("Journal Entries");
            foreach (Entry entry in _entries)
            {
                output.WriteLine(
                $"{entry._dateText}~{entry._location}~{entry._prompt}" +
                $"~{entry._entry}"
                );
            }
        }
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(
            $"Date: {entry._dateText} | Location: {entry._location} | Prompt: {entry._prompt}\n" +
            $"Your entry: {entry._entry}\n\n"
            );
        }
    }
    public void Load()
    {
        _entries.Clear();
        Console.Write("What is the name of the file you wish to load? ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines.Skip(1))
        {
            //Console.WriteLine(line);
            string[] parts = line.Split("~");
            //Console.WriteLine(parts);
            Entry loaded = new Entry();
            loaded._dateText = parts[0];
            loaded._location = parts[1];
            loaded._prompt = parts[2];
            loaded._entry = parts[3];
            _entries.Add(loaded);
        }
    }
}
