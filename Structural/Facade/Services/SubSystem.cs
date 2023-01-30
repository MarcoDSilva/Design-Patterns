namespace Structural.Facade.Services;

public class SubSystemOne
{
    public SubSystemOne() { }
    public void MethodOne()
    {
        System.Console.WriteLine("Subsystem one - method one");
    }
}

public class SubSystemTwo
{
    public SubSystemTwo() {}

    public void MethodTwo()
    {
        System.Console.WriteLine("Subsystem two - method two");
    }
}

public class SubSystemThree
{
    public SubSystemThree() {}

    public void MethodThree()
    {
        System.Console.WriteLine("Subsystem three - method three");
    }
}