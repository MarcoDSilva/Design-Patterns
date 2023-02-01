namespace Behavioral.Iterator.Models.Abstractions;

public abstract class Aggregate
{
    public abstract IteratorAbstraction CreateIterator();
}