namespace Structural.Decorator.Beverage;


using Structural.Decorator.Abstractions;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    public override double Cost()
    {
        return 1.99;
    }
}