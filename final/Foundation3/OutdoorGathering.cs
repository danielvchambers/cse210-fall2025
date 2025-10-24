public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather) : base(title, description, dateTime, address)
    {
        _weather = weather;
    }

    public override string Display()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\n" +
        $"Time: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetAddress()}\n" +
        $"Weather: {_weather}\n";
    }

    public override string ShortDisplay()
    {
        return $"Type: Outdoor Gathering\nTitle: {_title}\nDate: {_dateTime.ToShortDateString()}\n";
    }
}
