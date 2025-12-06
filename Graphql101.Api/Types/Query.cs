public class Query()
{
    public Book GetBook() => new Book("C# in Depth", new Author("Shazni", "Shiraz"));
    
    public IEnumerable<IPet> GetPets() => new List<IPet>
    {
        new Cat("Whiskers", true, CatType.Domestic),
        new Dog("Buddy", "Labrador"),
        new Parrot("Polly", true)
    };

    public IEnumerable<IMammal> GetMammals() => new List<IMammal>
    {
        new Cat("Whiskers", true, CatType.Domestic),
        new Dog("Buddy", "Labrador"),
    };

    public IEnumerable<Cat> GetAllCats(CatType? type){
        var cats = new List<Cat> 
        {
            new Cat("Whiskers", true, CatType.Domestic),
            new Cat("Whiskers", true, CatType.Wild),
            new Cat("Whiskers", true, CatType.Exotic),
        };

        if (type is not null)
        {
            return cats.Where(c => c.Type == type);
        }

        return cats;
    }

    public string GetDogName(Dog dog) => dog.Name;

    public string GetCatOrDogName(DogOrCat dogOrCat) => dogOrCat switch
    {
        DogOrCat(Dog dog, null) => dog.Name,
        DogOrCat(null, Cat cat) => cat.Name,
        _ => throw new InvalidOperationException("Invalid dog or cat")
    };

    public record DogOrCat(Dog? Dog, Cat? Cat);
}