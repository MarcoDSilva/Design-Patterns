public class ConcreteUser1 : User
{
    public ConcreteUser1(Mediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine("User1 Sending Message: " + message);
        mediator.SendMessage(this, message);
    }

    public override void Receive(string message)
    {
        Console.WriteLine("User1 Received Message: " + message);
    }
}

public class ConcreteUser2 : User
{
    public ConcreteUser2(Mediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine("User2 Sending Message: " + message);
        mediator.SendMessage(this, message);
    }

    public override void Receive(string message)
    {
        Console.WriteLine("User2 Received Message: " + message);
    }
}