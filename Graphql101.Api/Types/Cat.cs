public class Cat : IPet
{
    public Cat(string name, bool isEvil)
    {
        IsEvil = isEvil;
        Name = name;
    }

    public string Name { get; set; }
    public bool IsEvil { get; set; }
}