namespace Structural.Facade.Services;

public class Facade
{
    private SubSystemOne _one;
    private SubSystemTwo _two;
    private SubSystemThree _three;

    public Facade()
    {
        _one = new SubSystemOne();
        _two = new SubSystemTwo();
        _three = new SubSystemThree();
    }

    public void MethodA()
    {
        System.Console.WriteLine("\nMethodA called");
        _one.MethodOne();
        _two.MethodTwo();
    }

    public void MethodB()
    {
        System.Console.WriteLine("\nMethodB called");
        _two.MethodTwo();
        _three.MethodThree();
    }
}