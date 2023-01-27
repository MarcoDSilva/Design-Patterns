namespace Structural.Adapter.DbExample.Interface;

public interface IDbConnection
{
    void Connect();
    void ExecuteQuery(string query);
}