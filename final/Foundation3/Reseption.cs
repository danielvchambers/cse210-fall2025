public class Reseption : Event
{
    private List<string> _registry = new List<string>();

    public Reseption(string title, string description, DateTime date, DateTime time, Address address, List<string> registry) : base(title, description, date, time, address)
    {
        _registry = registry;
    }

    public string Email()
    {
        return "";
    }
}
