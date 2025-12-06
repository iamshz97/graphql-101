public class Query()
{
    public Book GetBook() => new Book("C# in Depth", new Author("Shazni", "Shiraz"));
    
    public IEnumerable<IPet> GetPets() => new List<IPet>
    {
        new Cat("Whiskers", true),
        new Dog("Buddy", "Labrador"),
        new Parrot("Polly", true)
    };
}


public class Parrot : IPet
{
    public Parrot(string name, bool isCanTalk)
    {
        Name = name;
        IsCanTalk = isCanTalk;
    }

    public string Name { get; set; }
    public bool IsCanTalk { get; set; }
}