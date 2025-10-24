public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, DateTime dateTime, Address address, string email) : base(title, description, dateTime, address)
    {
        _email = email;
    }

    public override string ShortDisplay()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_dateTime.ToShortDateString()}\n";
    }

    public override string Display()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\n" +
        $"Time: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetAddress()}\n" +
        $"Email for RSVP before the Scheduled Day: {_email}\n";
    }
}
