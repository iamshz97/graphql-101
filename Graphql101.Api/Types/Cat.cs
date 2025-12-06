public class Cat : IPet, IMammal
{
    public Cat(string name, bool isEvil, CatType type)
    {
        IsEvil = isEvil;
        Name = name;
        Type = type;
    }

    public string Name { get; set; }

    public CatType Type { get; set; }

    public bool IsEvil { get; set; }
}

public enum CatType
{
    Domestic,
    Wild,
    Exotic
}