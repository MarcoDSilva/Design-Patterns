public class ChatRoom : Mediator
{
    public override void SendMessage(User user, string message)
    {
        Console.WriteLine(DateTime.Now.ToString() + " [" + user.GetName() + "] : " + message);
    }
}