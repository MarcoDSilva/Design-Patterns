namespace Structural.Decorator.Abstractions;

public abstract class Beverage
{
    public string Description { get; set; }
    public abstract double Cost();
}