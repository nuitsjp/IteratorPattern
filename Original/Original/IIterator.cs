namespace Original
{
    public interface IIterator
    {
        bool HasNext { get; }
        object Next();
    }
}