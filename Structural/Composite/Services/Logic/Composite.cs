using Structural.Composite.Abstractions;

namespace Structural.Composite.Services;

public class Composite : Component
{
    private List<Component> _children = new List<Component>();
    public override void Add(Component c)
    {
        _children.Add(c);
    }
    public override void Remove(Component c)
    {
        _children.Remove(c);
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}