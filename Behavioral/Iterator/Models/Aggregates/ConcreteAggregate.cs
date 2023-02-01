using Behavioral.Iterator.Models.Abstractions;
using Behavioral.Iterator.Models.Iterators;

namespace Behavioral.Iterator.Models.Aggregates;

public class ConcreteAggregate : Aggregate
{
    private List<object> _items = new List<object>();

    public override IteratorAbstraction CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return _items.Count; }
    }

    public object this[int index]
    {
        get { return _items[index]; }
        set { _items.Insert(index, value); }
    }
}