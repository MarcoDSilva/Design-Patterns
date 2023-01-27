namespace Structural.Composite.Abstractions;

public abstract class Component
{
    public string Name { get; set; }
    public int Price { get; set; }
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
}