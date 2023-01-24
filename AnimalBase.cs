public abstract class AnimalBase
{
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public DateTime BirthDate { get; init; }
    public AnimalColor Color { get; init; }
    public int LegsCount { get; set; }
    public Zoo Zoo { get; set; } = null!;
}

public enum AnimalColor : byte
{
    Red,
    Orange,
    Yellow,
    Green,
    Cyan,
    Blue,
    Violet,
    Brown,
    White,
    Gray,
    Black,
    Transparent
}
