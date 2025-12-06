public class Dog : IPet, IMammal
{
    public Dog(string name, string breed)
    {
        Breed = breed;
        Name = name;
    }

    public string Name { get; set; }
    public string Breed { get; set; }
}