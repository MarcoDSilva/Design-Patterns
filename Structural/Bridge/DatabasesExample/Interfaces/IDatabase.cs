namespace Structural.Bridge.DatabasesExample.Interface;

public interface IDatabase
{
    void Connect();
    void Disconnect();
    void ExecuteQuery(string query);
}