using Structural.Adapter.DbExample.Interface;

namespace Structural.Adapter.DbExample.Logic;

public class DbConnectionAdapter : IDbConnection
{
    private DbConnection _dbConnection;
    
    public DbConnectionAdapter(DbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public void Connect()
    {
        _dbConnection.Connect();
    }

    public void Execute(string query)
    {
        _dbConnection.Execute(query);
    }

    public void ExecuteQuery(string query)
    {
        _dbConnection.Execute(query);
    }
}