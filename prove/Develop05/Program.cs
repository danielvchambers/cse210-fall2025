using System;

class Program
{
    static void Main(string[] args)
    {
        bool end = false;
        int choice;
        List<Goal> goals = new List<Goal>();
        while (!end)
        {
            Console.WriteLine("\nMenu" +
                "\n1. Create new goal" +
                "\n2. Display goals" +
                "\n3. Save goals" +
                "\n4. Load goals" +
                "\n5. Record Event" +
                "\n6. Quit" +
                "\nSelect a number from the menu: "
            );

            string v = Console.ReadLine();
            choice = int.Parse(v);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nWhat kind of goal would you like to create?" +
                        "\n1. Simple Goal" +
                        "\n2. Eternal Goal" +
                        "\n3. Checklist Goal" +
                        "\nPick a number from the above list: "
                    );
                    v = Console.ReadLine();
                    choice = int.Parse(v);
                    switch (choice)
                    {
                        case 1:
                            //fill
                            break;
                        case 2:
                            //fill
                            break;
                        case 3:
                            //fill
                            break;
                    }
                    break;
                case 2:
                    foreach (Goal goal in goals)
                    {
                        goal.Display();
                    }
                    break;
                case 3:
                    //fill
                    break;
                case 4:
                    //fill
                    break;
                case 5:
                    //fill
                    break;
                case 6:
                    end = true;
                    break;
            }

        }
    }
}
