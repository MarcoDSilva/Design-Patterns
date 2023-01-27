using Structural.Composite.Abstractions;

namespace Structural.Composite.Services;

public class Leaf : Component
{
    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }
    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}