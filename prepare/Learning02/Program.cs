using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Potato Chopper";
        job1._startYear = 1999;
        job1._endYear = 2005;
        job1._company = "Chips and Chops";

        Job job2 = new Job();
        job2._jobTitle = "Lizard Tamer";
        job2._startYear = 2005;
        job2._endYear = 2018;
        job2._company = "Dino's and Ducks";

        Resume myResume = new Resume();
        myResume._name = "Kerack Dragolich";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
