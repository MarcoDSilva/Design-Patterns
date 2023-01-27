
using Structural.Decorator.Abstractions;

public class Whip : CondimentDecorator
{
    Beverage _beverage;
    public Whip(Beverage beverage)
    {
        _beverage = beverage;
        Description = beverage.Description + ", Whip";
    }
    public override string GetDescription()
    {
        return this.Description;
    }
    public override double Cost()
    {
        return _beverage.Cost() + 0.15;
    }
}