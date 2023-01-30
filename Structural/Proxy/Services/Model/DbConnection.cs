using Structural.Proxy.Services.Interface;

namespace Structural.Proxy.Services.Model;

public class DbConnection : IDbConnection
{
    public void Connect()
    {
        System.Console.WriteLine("Connection to db");
    }
}