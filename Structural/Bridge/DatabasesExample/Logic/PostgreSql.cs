using Structural.Bridge.DatabasesExample.Interface;
namespace Structural.Bridge.DatabasesExample.Logic;

public class PostgreSQL : IDatabase
{
    public void Connect()
    {
        System.Console.WriteLine("Connecting PostgreSQL db...");
    }
    public void Disconnect()
    {
        System.Console.WriteLine("Disconnecting PostgreSQL db...");

    }
    public void ExecuteQuery(string query)
    {
        System.Console.WriteLine($"Executing PostgreSQL query: {query}");
    }
}