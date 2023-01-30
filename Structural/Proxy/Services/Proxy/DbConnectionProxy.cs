using Structural.Proxy.Services.Interface;
using Structural.Proxy.Services.Model;

namespace Structural.Proxy.Services.Proxy;

public class DbConnectionProxy : IDbConnection
{
    private DbConnection _dbConnection = new DbConnection();
    private bool _isAdmin;

    public DbConnectionProxy(bool isAdmin)
    {
        _isAdmin = isAdmin;
    }

    public void Connect()
    {
        if(_isAdmin) // acts like a proxy, if not true we don't call the OG object
        {
            _dbConnection.Connect();
        }
        else
        {
            System.Console.WriteLine("Access denied, no admin privileges were found");
        }
    }
}