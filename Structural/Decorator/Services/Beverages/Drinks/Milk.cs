namespace Structural.Decorator.Beverage;

using Structural.Decorator.Abstractions;

public class Milk : CondimentDecorator
{
    Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
        Description = _beverage.Description + ", Milk";
    }

    public override string GetDescription()
    {
        return this.Description;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }
}