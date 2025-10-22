using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Ultimate 30-Minute Weeknight Lasagna", "ProHomeCooks", 1245);
        video1.AddComment("SarahT88", "I made this last night and it was a HUGE hit! My family couldn't believe it only took 30 minutes of prep. This is going into our regular rotation for sure.");
        video1.AddComment("MikeP_Reviews", "Great recipe! Pro-tip: I added a little smoked paprika to the ricotta mixture and it really took it to the next level. Thanks for the amazing content!");
        video1.AddComment("TheRealChillGamer", "I'm not a cook, I'm just here because I was hungry. I actually managed to make this without setting off the smoke alarm. 10/10.");
        videos.Add(video1);
        //video1.Display();

        Video video2 = new Video("The M3 Studio Laptop: Did They Finally Fix It?", "TechFuture", 922);
        video2.AddComment("Alex_Design", "Finally, a review that actually tests the render speeds. That thermal performance is... disappointing. Sticking with my M1 for now. Great video!");
        video2.AddComment("codeWizard_01", "The new keyboard looks amazing, but I'm worried about the port selection. Why remove the SD card slot again?! Appreciate the honest take.");
        video2.AddComment("BethAnneS", "I'm just trying to decide if this is good for my college classes (communications major). It seems like overkill but I love the new 'Midnight' color.");
        video2.AddComment("sysAdminGrumps", "Another year, another dongle. Good review, bad product.");
        videos.Add(video2);
        //video2.Display();

        Video video3 = new Video("I Tried to Beat Cyber-Glitch 2088 With Only a Wrench", "GlitchMaster", 2103);
        video3.AddComment("WrexFan", "The part where you got stuck in the elevator for 5 minutes and had to fight that boss by throwing the wrench... I haven't laughed that hard in ages.");
        video3.AddComment("SpeedrunStats", "This isn't a viable strat, but it's hilarious. The AI pathing for melee is so broken. You could probably optimize this by using the wall-clip on level 4.");
        video3.AddComment("jenny_b", "This is the most chaotic and wonderful thing I have ever watched. The patience you have is unreal. Subscribed!");
        videos.Add(video3);
        //video3.Display();

        Video video4 = new Video("What If the Moon Was a Perfect Mirror?", "AstroScope", 580);
        video4.AddComment("Prof_Haley", "Fascinating concept! You did a great job explaining the 'specular reflection' vs. 'diffuse reflection' aspect. It would be blinding!");
        video4.AddComment("nocturnal_artist", "This is terrifying. Imagine trying to sleep. But also... it would look so beautiful. Great animation!");
        video4.AddComment("TomG_1995", "My question is, how would this affect werewolves? Does the mirrored light still count??");
        videos.Add(video4);
        //video4.Display();

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
