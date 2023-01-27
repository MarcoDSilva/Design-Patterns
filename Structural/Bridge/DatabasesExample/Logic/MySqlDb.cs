using Structural.Bridge.DatabasesExample.Interface;
namespace Structural.Bridge.DatabasesExample.Logic;

public class MySQL : IDatabase
{
    public void Connect()
    {
        System.Console.WriteLine("Connecting mysql db...");
    }
    public void Disconnect()
    {
        System.Console.WriteLine("Disconnecting mysql db...");

    }
    public void ExecuteQuery(string query)
    {
        System.Console.WriteLine($"Executing mysql query: {query}");
    }
}