namespace Behavioral.CoR.Services.Abstractions;

public abstract class Handler
{
    protected Handler _next;

    public void SetSucessor(Handler next)
    {
        _next = next;
    }

    public abstract void HandleRequest(int request);
}