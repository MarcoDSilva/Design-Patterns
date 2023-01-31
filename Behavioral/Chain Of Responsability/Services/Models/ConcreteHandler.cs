using Behavioral.CoR.Services.Abstractions;
namespace Behavioral.CoR.Services.Models;

public class ConcreteHandlerA : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
        {
            System.Console.WriteLine("Request handled by ChA {0} ", request);
        }
        else if (_next != null)
        {
            _next.HandleRequest(request);
        }
    }
}

public class ConcreteHandlerB : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            System.Console.WriteLine("Request handled by ChB {0} ", request);
        }
        else if (_next != null)
        {
            _next.HandleRequest(request);
        }
    }
}

public class ConcreteHandlerC : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            System.Console.WriteLine("Request handled by ChC {0} ", request);
        }
        else if (_next != null)
        {
            _next.HandleRequest(request);
        }
    }
}