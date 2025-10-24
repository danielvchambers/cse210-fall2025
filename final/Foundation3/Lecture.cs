public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string Display()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\n" +
        $"Time: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetAddress()}\n" +
        $"Speaker: {_speaker}\nCapacity: {_capacity}\n";
    }

    public override string ShortDisplay()
    {
        return $"Type: Lecture\nTitle: {_title}\nDate: {_dateTime.ToShortDateString()}\n";
    }
}
