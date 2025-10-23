public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string Display()
    {
        return "";
    }
}
