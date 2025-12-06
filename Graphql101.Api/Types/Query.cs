public class Query()
{
    public Book GetBook() => new Book("C# in Depth", new Author("Shazni", "Shiraz"));
}

public record Book(string Name, Author Author);

public record Author(string Name, string LastName);
