using Structural.Bridge.DatabasesExample.Interface;
namespace Structural.Bridge.DatabasesExample.Logic;

public class DatabaseClient
{
    IDatabase _database;
    public DatabaseClient(IDatabase database)
    {
        _database = database;
    }
    public void Connect()
    {
        _database.Connect();
    }
    public void Disconnect()
    {
        _database.Disconnect();
    }
    public void ExecuteQuery(string query)
    {
        _database.ExecuteQuery(query);
    }
}
