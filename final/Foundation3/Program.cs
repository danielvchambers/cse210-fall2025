using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        Lecture lecture1 = new Lecture(
            "The Quantum Leap: How AI is Reshaping Modern Medicine",
            "Join visionary technologist Dr. Evelyn Reed for an insightful evening exploring the frontier of artificial intelligence. This lecture will cover groundbreaking advancements in diagnostic AI, personalized treatment algorithms, and the ethical landscapes we must navigate as technology and biology merge.",
            new DateTime(2025, 11, 20, 18, 30, 0),
            new Address("404 Innovation Plaza, Beacon Hill", "Seattle", "Washington", "United States"),
            "Dr. Evelyn Reed",
            300);
        _events.Add(lecture1);

        OutdoorGathering outdoorGathering1 = new OutdoorGathering("The Solstice Bonfire & Community Starwatch",
            "Greet the longest night of the year with us. We'll host a warm, family-friendly bonfire on the beach. Hot cider and marshmallows will be provided. Bring your own blankets, thermos, and a spotting scope if you have one as we look for clear skies and winter constellations.",
            new DateTime(2025, 12, 21, 19, 0, 0),
            new Address("8.7 N Tongass Hwy", "Ketchikan", "Alaska", "United States"),
            "Partly cloudy and crisp. Temperature steady around 33°F with a light northerly breeze. Chance of light snow flurries.");
        _events.Add(outdoorGathering1);

        Reception reception1 = new Reception("The Art of Modern Calligraphy: A Beginner's Workshop",
            "Discover the elegance of pointed-pen calligraphy in this hands-on introductory workshop. We will cover the basic tools, fundamental strokes, and guide you through forming a complete lowercase alphabet. No prior experience is necessary. All materials (pen holder, nib, ink, and practice paper) are included.",
            new DateTime(2025, 12, 6, 13, 0, 0),
            new Address("720 NW 23rd Ave", "Portland", "Oregon", "United States"),
            "studio.rsvp.pdx@gmail.com");
        _events.Add(reception1);

        foreach (Event currentEvent in _events)
        {
            Console.WriteLine(currentEvent.StandardDisplay());
            Console.WriteLine(currentEvent.ShortDisplay());
            Console.WriteLine($"{currentEvent.Display()}\n\n");
        }
    }
}
