namespace Behavioral.Iterator.Models.Abstractions;

public abstract class IteratorAbstraction
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}