public abstract class User
{
    protected Mediator mediator;
    protected string name;

    public User(Mediator mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public abstract void Send(string message);

    public abstract void Receive(string message);
}
