public class Zoo
{
    public ICollection<AnimalBase> Animals { get; } = new HashSet<AnimalBase>();
}