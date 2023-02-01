using Behavioral.Iterator.Models.Abstractions;
using Behavioral.Iterator.Models.Aggregates;

namespace Behavioral.Iterator.Models.Iterators;

public class ConcreteIterator : IteratorAbstraction
{
    private ConcreteAggregate _aggregate;
    private int _current;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this._aggregate = aggregate;
    }

    public override object First()
    {
        return _aggregate[0];
    }

    public override object Next()
    {
        object ret = null;
        if (_current < _aggregate.Count - 1)
        {
            ret = _aggregate[++_current];
        }

        return ret;
    }

    public override object CurrentItem()
    {
        return _aggregate[_current];
    }

    public override bool IsDone()
    {
        return _current >= _aggregate.Count;
    }
}