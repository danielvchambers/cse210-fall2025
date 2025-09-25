using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        bool quit = false;
        //int numEntry = 0;
        //string entrystr;
        while (quit != true)
        {
            Console.WriteLine(
            "The Journal help program!!!\n" +
            "Please select one of the following options:\n" +
            "1. Write\n" +
            "2. Display\n" +
            "3. Load\n" +
            "4. Save\n" +
            "5. Quit\n"
            );
            string option = Console.ReadLine();
            if (option == "1")
            {
                //numEntry += 1;
                //entrystr = numEntry.ToString();
                Entry entry = new Entry();
                entry.GetLocation();
                entry.GivePrompt();
                entry.GetEntry();
                entry.GetTime();
                journal1._entries.Add(entry);
            }
            else if (option == "2")
            {
                journal1.Display();
            }
            else if (option == "3")
            {
                journal1.Load();
                journal1.Display();
            }
            else if (option == "4")
            {
                journal1.Save();
            }
            else
            {
                quit = true;
            }
        }
    }
}
