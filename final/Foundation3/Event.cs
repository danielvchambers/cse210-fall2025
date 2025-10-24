public abstract class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string StandardDisplay()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetAddress()}\n";
    }

    public abstract string Display();
    public abstract string ShortDisplay();
}
