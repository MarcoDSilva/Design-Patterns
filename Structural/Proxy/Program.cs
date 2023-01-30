using Structural.Proxy.Services.Interface;
using Structural.Proxy.Services.Model;
using Structural.Proxy.Services.Proxy;

IDbConnection dbConnection = new DbConnectionProxy(false);
dbConnection.Connect();

IDbConnection con = new DbConnectionProxy(true);
con.Connect();