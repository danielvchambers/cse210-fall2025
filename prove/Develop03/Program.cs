// Exceeding requirements I did 2 things
// 1. I made the multiple constructors in the Reference class not needed and reduced it to 1
// by creating a parse reference method that will parce it into the desired output.
// 2. I made it so that it would not only hide 3 words at random but it would not hide the
// same word twice insuring that it will hide 3 words each time.

using System;

class Program
{
    static void Main(string[] args)
    {
        int end = 0;
        bool quit = false;
        Console.Write("What is the Scripture reference without the scripture: ");
        string _reference = Console.ReadLine();
        Console.Write("Copy and paste the scripture you would like to memorize: ");
        string _scripture = Console.ReadLine();
        Scripture _1scripture = new Scripture(_reference, _scripture);
        while (!quit && !_1scripture.AllWordsHidden())
        {
            int test = _1scripture.PEnd();
            Console.WriteLine(test);
            end = 0;
            end += _1scripture.AddInt();
            if (end == _1scripture.PEnd())
            {
                quit = true;
            }
            _1scripture.DisplayScripture();
            _1scripture.HideRandomWords();
            Console.Write("\nTo end early type 'quit' here -> ");
            string _repeat = Console.ReadLine();
            if (_repeat == "quit")
            {
                quit = true;
                Console.WriteLine("2");
            }
            else if (_repeat == "")
            { }
        }
        _1scripture.DisplayScripture();
    }
}
