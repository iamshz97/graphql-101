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