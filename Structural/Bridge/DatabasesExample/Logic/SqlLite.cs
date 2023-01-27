using Structural.Bridge.DatabasesExample.Interface;
namespace Structural.Bridge.DatabasesExample.Logic;

class SQLite : IDatabase
{
    public void Connect()
    {
        System.Console.WriteLine("Connecting SQLite db...");
    }
    public void Disconnect()
    {
        System.Console.WriteLine("Disconnecting SQLite db...");

    }
    public void ExecuteQuery(string query)
    {
        System.Console.WriteLine($"Executing SQLite query: {query}");
    }
}